using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;

//Per la gestione hardware
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using Toro.Modelli;
 



namespace Toro
{
    public partial class FrmInformazioniPC : Form
    {
        
        public FrmInformazioniPC()
        {
            InitializeComponent();
        }
        UsbDetection detector = new UsbDetection();
        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInformazioniPC_Load(object sender, EventArgs e)
        {
            try
            {
                //TODO: prossime funzionalità
                //Info Microfono audio ed altoparlanti 
                //Info stampanti
                //Info monitor, vedere tipo di monitor, marca, etc
                //Info scheda madre come marca, prouttore, modello etc
                //Info scheda di rete tipo marca, produttore modello etc
                
                //Valutare più avanti se aprire i dati quando si clicca sul tab

                Video();
                TxtNomePC.Text = Environment.MachineName;
                txtNomeUtente.Text = Environment.UserName;
                VarieInformazioni();
                GetInfoRAM();
                GetInfoSchedaGrafica();
                GetInfoPC();
                GetCpuDetails();
                var ip = GetLocalIPv4();

                if (ip != null)
                    TxtIPComputer.Text = ip.ToString();
                else
                    TxtIPComputer.Text = "Nessun indirizzo IPv4 disponibile.";

                GetInfoWebCam();

                   GetStampanti();
              //  LoadPrinters();
                GetInternet();

               
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore: " + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;

            }

        }





        #region Funzioni

        /// <summary>
        /// Fornisce informazioni sul video
        /// </summary>
        private void Video()
        {

            try
            {
                var risoluzione = Screen.PrimaryScreen?.Bounds;


                txtRisoluzioneVideo.Text = risoluzione?.Width + "x" + risoluzione?.Height;
                var risoluzioneSenzaBarra = Screen.PrimaryScreen?.WorkingArea;

                TxtRisoluzioneSenzaBarra.Text = risoluzioneSenzaBarra?.Width + "x" + risoluzioneSenzaBarra?.Height;

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }



        }


        /// <summary>
        /// Fornisce informazioni di vario genere
        /// </summary>
        private void VarieInformazioni()
        {

            try
            {
                PowerStatus statoBatteria = SystemInformation.PowerStatus;
                float percentualeStatoBatteria = statoBatteria.BatteryLifePercent * 100;
                TxtLivelloBatteria.Text = percentualeStatoBatteria + "%";


                TxtCollegata.Text = statoBatteria.PowerLineStatus == PowerLineStatus.Online ? "Sì" : "No";
                DriveInfo[] drives = DriveInfo.GetDrives();

                foreach (DriveInfo drive in drives)
                {
                    cmbUnita.Items.Add(drive.Name);

                }
                if (cmbUnita.Items.Count > 0)
                    cmbUnita.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }




        }




        /// <summary>
        /// Funzione che permette di sapere le dimensioni in byte e le converte in un formato leggibile
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns>Restiutisce il formato</returns>
        private string FormatoUnita(long bytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = bytes;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len /= 1024;
            }
            return $"{len:0.##} {sizes[order]}";
        }




        /// <summary>
        /// Funzione che rileva le informazioni della scheda grafica
        /// </summary>
        private void GetInfoRAM()
        {

            try
            {
                var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
                var moduli = searcher.Get();

                long totaleRam = 0;
                int moduliInstallati = 0;


                string tipoRam = "";
                string Produttore = "";
                string SlotRam = "";
                foreach (ManagementObject module in moduli)
                {
                    moduliInstallati++;
                    long capacita = Convert.ToInt64(module["Capacity"]);
                    int smbiosType = Convert.ToInt32(module["SMBIOSMemoryType"]);

                    totaleRam += capacita;


                    SlotRam = module["DeviceLocator"]?.ToString() ?? "";

                    tipoRam = GetTipoRAM(smbiosType);

                    Produttore = module["Manufacturer"]?.ToString() ?? "";

                }


                var arraySearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemoryArray");
                var arrays = arraySearcher.Get();

                int totaleSlots = 0;
                foreach (ManagementObject arr in arrays)
                {
                    totaleSlots += Convert.ToInt32(arr["MemoryDevices"]);
                }


                TxtSlotTotali.Text = totaleSlots.ToString();
                TxtSlotOccupati.Text = moduliInstallati.ToString();
                TxtSlotLiberi.Text = (totaleSlots - moduliInstallati).ToString();
                TxtRamTotale.Text = (totaleRam / (1024 * 1024 * 1024)).ToString() + " GB";
                TxtVelocita.Text = moduli.Count > 0 ? moduli.Cast<ManagementObject>().First()["Speed"]?.ToString() + " MHz" : "N/A";
                txtTipoRam.Text = tipoRam;
                TxtProduttore.Text = Produttore;
                TxtSlotRam.Text = SlotRam;





            }
            catch (ManagementException exME)
            {
                Utility.MessaggioErrore("Errore: " + exME.Message);

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore: " + ex.Message);

            }




        }

        /// <summary>
        /// Funzione per rilevare le informazioni sulla scheda grafica
        /// </summary>
        private void GetInfoSchedaGrafica()
        {

            try
            {
                var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");

                foreach (ManagementObject obj in searcher.Get())
                {

                    TxtNomeSchedaGrafica.Text = $"  Scheda grafica: {obj["Name"]}";
                    TxtCapacitaSchedaGrafica.Text = $"  Memoria video: {FormatoUnita(Convert.ToInt64(obj["AdapterRAM"]))}";
                    TxtDriver.Text += $"  Driver: {obj["DriverVersion"]}";
                    TxtProduttoreSchedaGrafica.Text = $"  Produttore: {obj["AdapterCompatibility"]}";
                }
            }
            catch (ManagementException exME)
            {
                Utility.MessaggioErrore("Errore: " + exME.Message);

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore: " + ex.Message);
            }



        }


        /// <summary>
        /// Fornisce informazioni sul nome del pc o versione
        /// </summary>
        private void GetInfoPC()
        {


            try
            {

                using (var searcher = new ManagementObjectSearcher("SELECT Name, Version FROM Win32_ComputerSystemProduct"))
                {
                    foreach (ManagementObject mo in searcher.Get())
                    {
                        string nomePC = mo["Name"]?.ToString() ?? ""; // (mo["Name"] ?? "").ToString().Trim() ;
                        string versione = mo["Version"]?.ToString() ?? "";//  (mo["Version"] ?? "")?.ToString()?.Trim();
                        TxtModelloPC.Text = string.IsNullOrEmpty(versione) ? nomePC : (nomePC + " " + versione).Trim();
                    }
                }

            }
            catch (ManagementException exME)
            {
                Utility.MessaggioErrore("Errore: " + exME.Message);

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore: " + ex.Message);
            }





        }

        /// <summary>
        /// Metodo per rilevare informazioni sulla CPU
        /// </summary>
        /// <returns></returns>
        private void GetCpuDetails()
        {
            try
            {


                var searcher = new ManagementObjectSearcher("select * from Win32_Processor");
                //var cpuInfo = "";

                foreach (ManagementObject obj in searcher.Get())
                {
                    TxtNomeCPU.Text += obj["Name"]?.ToString();
                    //cpuInfo += $"Nome CPU: {obj["Name"]}\n";
                    TxtProduttoreCPU.Text += obj["Manufacturer"]?.ToString();
                    // cpuInfo += $"Produttore: {obj["Manufacturer"]}\n";
                    TxtDescrizioneCPU.Text += obj["Description"]?.ToString();
                    // cpuInfo += $"Descrizione: {obj["Description"]}\n";
                    TxtNumeroCore.Text += obj["NumberOfCores"]?.ToString();
                    //  cpuInfo += $"Numero Core: {obj["NumberOfCores"]}\n";
                    TxtNumeroLogici.Text += obj["NumberOfLogicalProcessors"]?.ToString();
                    //     cpuInfo += $"Numero Logici: {obj["NumberOfLogicalProcessors"]}\n";
                    TxtVelocitaCPU.Text += obj["MaxClockSpeed"]?.ToString();
                    //    cpuInfo += $"Velocità (MHz): {obj["MaxClockSpeed"]}\n";
                    TxtIdProcessore.Text += obj["ProcessorId"]?.ToString();
                    // cpuInfo += $"ID Processore: {obj["ProcessorId"]}\n";
                }
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore: " + ex.Message);
            }
            // return cpuInfo;
        }


        /// <summary>
        /// Verifica il tipo di RAM
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        string GetTipoRAM(int type)
        {
            return type switch
            {
                20 => "DDR",
                21 => "DDR2",
                24 => "DDR3",
                26 => "DDR4",
                34 => "DDR5",
                _ => $"Sconosciuto (codice {type})"
            };
        }


        #endregion




        private void cmbUnita_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                // Verifica che sia effettivamente selezionata un'unità valida
                var selected = cmbUnita?.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(selected))
                {
                    // Nessuna unità selezionata: svuota i campi e esci
                    TxtUtilizzabile.Text = "";
                    TxtSpazioTotale.Text = "";
                    TxtSpazioLibero.Text = "";
                    TxtOccupato.Text = "";
                    txtTipo.Text = "";
                    TxtFileSystem.Text = "";
                    TxtEtichetta.Text = "";
                    return;
                }

                DriveInfo unita = new DriveInfo(selected);
                if (unita.IsReady)
                {
                    long totalSize = unita.TotalSize;
                    long freeSpace = unita.AvailableFreeSpace;
                    long usedSpace = totalSize - freeSpace;
                    double usedPercentage = (totalSize > 0)
                        ? (usedSpace / (double)totalSize) * 100
                        : 0;

                    TxtSpazioTotale.Text = FormatoUnita(totalSize);
                    TxtSpazioLibero.Text = FormatoUnita(freeSpace);
                    TxtOccupato.Text = $"  Spazio usato: {FormatoUnita(usedSpace)} ({usedPercentage:F2}%)";
                    txtTipo.Text = unita.DriveType.ToString();
                    TxtFileSystem.Text = unita.DriveFormat;
                    TxtEtichetta.Text = unita.VolumeLabel;
                    TxtUtilizzabile.Text = "Si";
                }
                else
                {
                    TxtUtilizzabile.Text = "No";
                    TxtSpazioTotale.Text = "";
                    TxtSpazioLibero.Text = "";
                    TxtOccupato.Text = "";
                    txtTipo.Text = "";
                    TxtFileSystem.Text = "";
                    TxtEtichetta.Text = "";
                }




            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore: " + ex.Message);
            }
        }

        //Gestione IP
        bool IsAdattatoreVirtuale(NetworkInterface ni)
        {
            string tipo = (ni.Description + " " + ni.Name).ToLowerInvariant();

            string[] keywords =
            {
            "virtual",
            "vmware",
            "virtualbox",
            "hyper-v",
            "vethernet",
            "docker",
            "tap",
            "tun",
            "vpn",
            "loopback"
        };

            return keywords.Any(k => tipo.Contains(k));
        }

        bool HasGateway(NetworkInterface ni)
        {
            return ni.GetIPProperties()
                     .GatewayAddresses
                     .Any(g =>
                         g.Address.AddressFamily == AddressFamily.InterNetwork &&
                         !g.Address.Equals(IPAddress.Any));
        }



        IPAddress? GetFirstAvailableIPv4()
        {
            var adapters = NetworkInterface.GetAllNetworkInterfaces()
                .Where(n =>
                    n.OperationalStatus == OperationalStatus.Up &&
                    n.NetworkInterfaceType != NetworkInterfaceType.Loopback &&
                    !IsAdattatoreVirtuale(n))
                .OrderByDescending(HasGateway);

            foreach (var adapter in adapters)
            {
                foreach (var addr in adapter.GetIPProperties().UnicastAddresses)
                {
                    if (addr.Address.AddressFamily != AddressFamily.InterNetwork)
                        continue;

                    if (IPAddress.IsLoopback(addr.Address))
                        continue;

                    string ip = addr.Address.ToString();

                    // Esclude APIPA
                    if (ip.StartsWith("169.254."))
                        continue;

                    return addr.Address;
                }
            }

            return null;
        }
        IPAddress? GetLocalIPv4()
        {

            try
            {
                using Socket socket = new Socket(AddressFamily.InterNetwork,
                                                 SocketType.Dgram,
                                                 ProtocolType.Udp);

                socket.Connect("8.8.8.8", 65530);

                if (socket.LocalEndPoint is IPEndPoint ep)
                    return ep.Address;
            }
            catch
            {

            }


            return GetFirstAvailableIPv4();
        }
        //Fine gestione IP


        /// <summary>
        /// Rileva le informazioni riguardante la webcam 
        /// </summary>
        private void GetInfoWebCam()
        {
            try
            {


                var searcher = new ManagementObjectSearcher(
                                @"SELECT * FROM Win32_PnPEntity WHERE PNPClass='Camera'");

                foreach (ManagementObject mnoDevice in searcher.Get())
                {
                    TxtNome.Text = mnoDevice["Name"].ToString();
                    TxtProduttoreWebCam.Text = mnoDevice["Manufacturer"].ToString();
                    TxtDeviceID.Text = mnoDevice["DeviceID"].ToString();
                    TxtPNPID.Text = mnoDevice["PNPDeviceID"].ToString();
                    TxtStato.Text = mnoDevice["Status"].ToString();

                    string pnpId = mnoDevice["PNPDeviceID"]?.ToString() ?? "";

                    var match = System.Text.RegularExpressions.Regex.Match(
                        pnpId,
                        @"VID_([0-9A-F]{4}).*PID_([0-9A-F]{4})");

                    if (match.Success)
                    {
                        TxtVendorID.Text = match.Groups[1].Value;
                        TxtProductID.Text = match.Groups[2].Value;
                    }
                }
            }
            catch (ManagementException exMe)
            {

                Utility.MessaggioErrore("Errore: " + exMe.Message);
            }

            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore: " + ex.Message);
            }

        }


        private void GetStampanti()
        {
            try
            {
                List<DtoStampante> stampanti =  GetPrinters();

                // Forza il refresh della DataGrid
                dtgStampante.DataSource = null;
                dtgStampante.DataSource = stampanti;

                // Formattazione rapida delle colonne (Opzionale)
                //dtgStampante.Columns["Nome"].HeaderText = "Nome Stampante";
                //dtgStampante.Columns["NomeDriver"].HeaderText = "Modello / Driver";
                //dtgStampante.Columns["Online"].HeaderText = "Dispositivo Online";
                //dtgStampante.Columns["Stato"].HeaderText = "Stato Corrente";



            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore: " + ex.Message);
            }




        }

        private void GetInternet()
        {
            try
            {

                bool isInternet = NetworkInterface.GetIsNetworkAvailable();
                if (isInternet)
                    TxtInternet.Text = "Collegato ad internet";
                else
                    TxtInternet.Text = "Nessun collegamento ad internet";

            }
            catch (ManagementException exMe)
            {

                Utility.MessaggioErrore("Errore: " + exMe.Message);
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore: " + ex.Message);
            }




        }


        #region Gestione stampante


         



       private List<DtoStampante> GetPrinters()
        {
            var listaStampanti = new List<DtoStampante>();

            // Interrogazione WMI alla classe nativa Win32_Printer
            string query = "SELECT Name, DriverName, PortName, Default, Network, WorkOffline, PrinterStatus FROM Win32_Printer";

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(query))
            {
                using (ManagementObjectCollection coll = searcher.Get())
                {
                    foreach (ManagementObject mo in coll)
                    {
                        try
                        {
                            // Lettura sicura dei valori booleani (gestendo eventuali null)
                            bool workOffline = mo["WorkOffline"] != null && (bool)mo["WorkOffline"];
                            bool isNetwork = mo["Network"] != null && (bool)mo["Network"];
                            bool isDefault = mo["Default"] != null && (bool)mo["Default"];

                            // Lettura dello stato numerico di stampa
                            ushort statusCode = mo["PrinterStatus"] != null ? (ushort)mo["PrinterStatus"] : (ushort)0;

                            var info = new DtoStampante
                            {
                                Nome = mo["Name"]?.ToString() ?? "Sconosciuto",
                                NomeDriver = mo["DriverName"]?.ToString() ?? "Modello non specificato",
                                Porta = mo["PortName"]?.ToString() ?? "N/D",
                                Predefinita = isDefault,
                                Rete = isNetwork,
                                // Una stampante è online se NON è impostata in "WorkOffline" 
                                // e lo stato hardware non è esplicitamente Offline (7)
                                Online = !workOffline && statusCode != 7,
                                Stato = GetStato(statusCode, workOffline)
                            };

                            listaStampanti.Add(info);
                        }
                        catch (Exception ex)
                        {
                            // Gestione errori del singolo record WMI per non bloccare il ciclo
                            System.Diagnostics.Debug.WriteLine($"Errore lettura stampante: {ex.Message}");
                        }
                    }
                }
            }

            return listaStampanti;
        }


        /// <summary>
        /// -----------------------------------------------
        /// </summary>
        /// <param name="printers"></param>

        private void LoadPrinters()
        {
            try
            {
                List<DtoStampante> allPrinters =  GetAllPrinters();

                // Pulire i controlli
                
                dtgStampante.Rows.Clear();

                // Popolare la lista di tutte le stampanti
                

                // Separare online e offline
                var onlinePrinters =  GetOnlinePrinters(allPrinters);
                var offlinePrinters =  GetOfflinePrinters(allPrinters);

                //foreach (var printer in onlinePrinters)
                //{
                //    listBoxOnline.Items.Add($"✓ {printer.Name}");
                //}

                //foreach (var printer in offlinePrinters)
                //{
                //    listBoxOffline.Items.Add($"✗ {printer.Name}");
                //}

                // Popolare il DataGridView con tutti i dettagli
                dtgStampante.DataSource = allPrinters;


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore: {ex.Message}", "Errore");
            }
        }

        List<DtoStampante> GetAllPrinters()
        {
            List<DtoStampante> printers = new List<DtoStampante>();

            try
            {
                // Metodo 1: Utilizzo di PrinterSettings per le stampanti di base
                foreach (string printerName in PrinterSettings.InstalledPrinters)
                {
                    try
                    {
                        var printerInfo = GetPrinterDetails(printerName);
                        printers.Add(printerInfo);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Errore nel recupero dettagli stampante {printerName}: {ex.Message}");
                    }
                }

                // Metodo 2: Integrazione con WMI per informazioni aggiuntive
                EnrichPrintersWithWMI(printers);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore nel recupero stampanti: {ex.Message}");
            }

            return printers;
        }


        DtoStampante GetPrinterDetails(string printerName)
        {
            var settings = new PrinterSettings { PrinterName = printerName };
            var defaultSettings = new PrinterSettings();

            var info = new DtoStampante
            {
                Nome = printerName,
                Predefinita = printerName == defaultSettings.PrinterName,
                Rete = settings.PrinterName.Contains("\\\\"),
                Porta = settings.PrintToFile ? "FILE:" : GetPortName(printerName)
            };

            return info;
        }


        void EnrichPrintersWithWMI(List<DtoStampante> printers)
        {
            try
            {
                ManagementScope scope = new ManagementScope(@"\\.\root\cimv2");
                scope.Connect();

                // Query per stampanti
                ObjectQuery query = new ObjectQuery("SELECT * FROM Win32_Printer");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

                foreach (ManagementObject printer in searcher.Get())
                {
                    string printerName = printer["Name"]?.ToString();
                    if (string.IsNullOrEmpty(printerName))
                        continue;

                    var existingPrinter = printers.FirstOrDefault(p =>
                        p.Nome.Equals(printerName, StringComparison.OrdinalIgnoreCase));

                    if (existingPrinter != null)
                    {
                        existingPrinter.NomeDriver = printer["DriverName"]?.ToString();
                        existingPrinter.Descrizione = printer["Description"]?.ToString();
                        existingPrinter.Stato = printer["Status"]?.ToString();
                        existingPrinter.Modello = printer["Model"]?.ToString();
                        existingPrinter.NumeroLavoro = Convert.ToInt32(printer["JobCountSinceLastReset"] ?? 0);

                        // Determinare lo stato online/offline
                        existingPrinter.Online = DeterminePrinterStatus(printer);
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
        bool DeterminePrinterStatus(ManagementObject printer)
        {
            try
            {
                // Controllare lo stato della stampante
                uint[] printJobStatus = printer["PrintJobDataType"] != null
                    ? (uint[])printer["PrintJobDataType"]
                    : Array.Empty<uint>();

                string status = printer["Status"]?.ToString() ?? "Unknown";
                string availability = printer["Availability"]?.ToString() ?? "0";

                // Codici di stato: 0 = Unknown, 1 = Other, 2 = OK, 3 = Degraded, etc.
                if (status.Equals("OK", StringComparison.OrdinalIgnoreCase) ||
                    status.Equals("Idle", StringComparison.OrdinalIgnoreCase) ||
                    status.Equals("Printing", StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }

                if (int.TryParse(availability, out int availabilityCode))
                {
                    return availabilityCode == 3; // 3 = Running/Available
                }

                return false;
            }
            catch
            {
                return false;
            }
        }


        private static string GetPortName(string printerName)
        {
            try
            {
                using (var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    $@"SYSTEM\CurrentControlSet\Control\Print\Printers\{printerName}"))
                {
                    if (key != null)
                    {
                        return key.GetValue("Port")?.ToString() ?? "Sconosciuta";
                    }
                }
            }
            catch
            {
                // Ignorare errori di accesso al Registro
            }
            return "Sconosciuta";
        }








        public static List<DtoStampante> GetOnlinePrinters(List<DtoStampante> printers)
        {
            return printers.Where(p => p.Online).ToList();
        }


        public static List<DtoStampante> GetOfflinePrinters(List<DtoStampante> printers)
        {
            return printers.Where(p => !p.Online).ToList();
        }


        string GetStato(uint codiceStato, bool nonInLinea)
        {
            if (nonInLinea) return "Offline (Impostazione utente)";

            // Codici ufficiali Win32_Printer PrinterStatus
            return codiceStato switch
            {
                1 => "Altro",
                2 => "Sconosciuto",
                3 => "Pronta (Inattiva)",
                4 => "In stampa...",
                5 => "Riscaldamento",
                6 => "In pausa",
                7 => "Offline",
                _ => "Pronta"
            };
        }



        #endregion



    }
}
