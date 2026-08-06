using System;
using System.Collections.Generic;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;

namespace Toro.Modelli
{
    public class NetworkAdapterManager
    {
        /// <summary>
        /// Recupera tutte le schede di rete installate nel sistema
        /// </summary>
        public static List<NetworkAdapterInfo> GetAllNetworkAdapters()
        {
            List<NetworkAdapterInfo> adapters = new List<NetworkAdapterInfo>();

            try
            {
                // Metodo 1: Utilizzo di NetworkInterface per informazioni di base
                NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();

                foreach (NetworkInterface ni in interfaces)
                {
                    try
                    {
                        var adapterInfo = GetAdapterBasicInfo(ni);
                        adapters.Add(adapterInfo);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore nel recupero dettagli scheda {ni.Name}: {ex.Message}");
                    }
                }

                // Metodo 2: Integrazione con WMI per informazioni avanzate
                EnrichAdaptersWithWMI(adapters);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore nel recupero schede di rete: {ex.Message}");
            }

            return adapters;
        }

        /// <summary>
        /// Recupera le informazioni di base di una scheda di rete
        /// </summary>
        private static NetworkAdapterInfo GetAdapterBasicInfo(NetworkInterface ni)
        {
            var ipProperties = ni.GetIPProperties();
            var ipv4Config = ipProperties.GetIPv4Properties();
            var stats = ni.GetIPStatistics();

            var info = new NetworkAdapterInfo
            {
                Name = ni.Name,
                Description = ni.Description,
                InterfaceType = ni.NetworkInterfaceType,
                Status = ni.OperationalStatus,
                IsConnected = ni.OperationalStatus == OperationalStatus.Up &&
                              ni.NetworkInterfaceType != NetworkInterfaceType.Loopback,
                MacAddress = ni.GetPhysicalAddress().ToString(),
                Speed = ni.Speed,
                UnicastAddressesCount = ni.GetIPProperties().UnicastAddresses.Count,
                BytesSent = stats.BytesSent,
                BytesReceived = stats.BytesReceived,
                ErrorsSent = stats.OutgoingPacketsDiscarded,
                ErrorsReceived = stats.IncomingPacketsDiscarded
            };

            // Recuperare indirizzi IP
            foreach (var unicastAddress in ipProperties.UnicastAddresses)
            {
                if (unicastAddress.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    info.IpAddress = unicastAddress.Address.ToString();
                    info.SubnetMask = unicastAddress.IPv4Mask.ToString();
                }
                else if (unicastAddress.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6)
                {
                    info.IpV6Address = unicastAddress.Address.ToString();
                }
            }

            // Recuperare Gateway
            var gateways = ipProperties.GatewayAddresses;
            if (gateways.Count > 0)
            {
                info.Gateway = string.Join(", ", gateways.Select(g => g.Address.ToString()));
            }

            // Recuperare server DNS
            var dnsServers = ipProperties.DnsAddresses;
            if (dnsServers.Count > 0)
            {
                info.DnsServers = string.Join(", ", dnsServers.Select(d => d.ToString()));
            }

            // Controllare se DHCP è abilitato
            info.IsDhcpEnabled = ipProperties.GetIPv4Properties().IsDhcpEnabled;

            return info;
        }

        /// <summary>
        /// Arricchisce i dati delle schede di rete con informazioni WMI
        /// </summary>
        private static void EnrichAdaptersWithWMI(List<NetworkAdapterInfo> adapters)
        {
            try
            {
                ManagementScope scope = new ManagementScope(@"\\.\root\cimv2");
                scope.Connect();

                // Query per schede di rete
                ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_NetworkAdapter");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

                foreach (ManagementObject adapter in searcher.Get())
                {
                    string adapterName = adapter["Name"]?.ToString();
                    if (string.IsNullOrEmpty(adapterName))
                        continue;

                    var existingAdapter = adapters.FirstOrDefault(a =>
                        a.Description.Equals(adapterName, StringComparison.OrdinalIgnoreCase));

                    if (existingAdapter != null)
                    {
                        existingAdapter.Model = adapter["Model"]?.ToString();
                        existingAdapter.Manufacturer = adapter["Manufacturer"]?.ToString();
                        existingAdapter.DriverName = adapter["ServiceName"]?.ToString();
                    }
                }

                // Query per informazioni di rete aggiuntive
                ObjectQuery configQuery = new ObjectQuery("SELECT * FROM Win32_NetworkAdapterConfiguration");
                ManagementObjectSearcher configSearcher = new ManagementObjectSearcher(scope, configQuery);

                foreach (ManagementObject config in configSearcher.Get())
                {
                    string description = config["Description"]?.ToString();
                    if (string.IsNullOrEmpty(description))
                        continue;

                    var existingAdapter = adapters.FirstOrDefault(a =>
                        a.Description.Equals(description, StringComparison.OrdinalIgnoreCase));

                    if (existingAdapter != null && existingAdapter.IpAddress == null)
                    {
                        // Recuperare IP Address se non già presente
                        object[] ipAddresses = config["IPAddress"] as object[];
                        if (ipAddresses != null && ipAddresses.Length > 0)
                        {
                            existingAdapter.IpAddress = ipAddresses[0].ToString();
                        }

                        // Recuperare Subnet Mask
                        object[] subnetMasks = config["IPSubnet"] as object[];
                        if (subnetMasks != null && subnetMasks.Length > 0)
                        {
                            existingAdapter.SubnetMask = subnetMasks[0].ToString();
                        }
                    }
                }

                // Query per informazioni driver
                ObjectQuery driverQuery = new ObjectQuery("SELECT * FROM Win32_PnPSignedDriver WHERE DeviceClass='NET'");
                ManagementObjectSearcher driverSearcher = new ManagementObjectSearcher(scope, driverQuery);

                foreach (ManagementObject driver in driverSearcher.Get())
                {
                    string description = driver["Description"]?.ToString();
                    if (string.IsNullOrEmpty(description))
                        continue;

                    var existingAdapter = adapters.FirstOrDefault(a =>
                        a.Description.Equals(description, StringComparison.OrdinalIgnoreCase) ||
                        a.Model?.Equals(description, StringComparison.OrdinalIgnoreCase) == true);

                    if (existingAdapter != null)
                    {
                        existingAdapter.DriverVersion = driver["DriverVersion"]?.ToString();
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Accesso negato a WMI. Eseguire come amministratore per ottenere informazioni complete.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore nell'accesso a WMI: {ex.Message}");
            }
        }

        /// <summary>
        /// Filtra le schede di rete connesse
        /// </summary>
        public static List<NetworkAdapterInfo> GetConnectedAdapters(List<NetworkAdapterInfo> adapters)
        {
            return adapters.Where(a => a.IsConnected).ToList();
        }

        /// <summary>
        /// Filtra le schede di rete disconnesse
        /// </summary>
        public static List<NetworkAdapterInfo> GetDisconnectedAdapters(List<NetworkAdapterInfo> adapters)
        {
            return adapters.Where(a => !a.IsConnected).ToList();
        }

        /// <summary>
        /// Filtra per tipo di interfaccia (Ethernet, Wireless, ecc.)
        /// </summary>
        public static List<NetworkAdapterInfo> GetAdaptersByType(
            List<NetworkAdapterInfo> adapters,
            NetworkInterfaceType type)
        {
            return adapters.Where(a => a.InterfaceType == type).ToList();
        }

        /// <summary>
        /// Ottiene statistiche dettagliate di una scheda di rete specifica
        /// </summary>
        public static NetworkAdapterInfo GetAdapterStats(string adapterName)
        {
            NetworkInterface ni = NetworkInterface.GetAllNetworkInterfaces()
                .FirstOrDefault(n => n.Name.Equals(adapterName, StringComparison.OrdinalIgnoreCase));

            if (ni == null)
                return null;

            return GetAdapterBasicInfo(ni);
        }
    }
    public class NetworkAdapterInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string MacAddress { get; set; }
        public NetworkInterfaceType InterfaceType { get; set; }
        public OperationalStatus Status { get; set; }
        public bool IsConnected { get; set; }
        public string IpAddress { get; set; }
        public string SubnetMask { get; set; }
        public string Gateway { get; set; }
        public string DnsServers { get; set; }
        public bool IsDhcpEnabled { get; set; }
        public long Speed { get; set; }
        public string DriverName { get; set; }
        public string DriverVersion { get; set; }
        public long BytesSent { get; set; }
        public long BytesReceived { get; set; }
        public long ErrorsSent { get; set; }
        public long ErrorsReceived { get; set; }
        public long UnicastAddressesCount { get; set; }
        public string IpV6Address { get; set; }
    }
}