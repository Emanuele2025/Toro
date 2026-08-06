using System;
using System.Collections.Generic;
using System.Text;
using static System.Windows.Forms.AxHost;

namespace Toro.Modelli
{
    public class DtoSchedaRete
    {
        public string Nome { get; set; }

        public string Modello { get; set; }

        public string Driver { get; set; }
        public string Descrizione { get; set; }

        public string Tipo { get; set; }

        public string Stato { get; set; }

        public string Velocita { get; set; }

        public string Mac { get; set; }

        public string Gateway { get; set; }

        public bool SupportaIPv4 { get; set; }

        public bool SupportaIPv46 { get; set; }
        public string SupportaIPv6 { get; set; }
        public string IP { get; set; }
        public string SubnetMask { get; internal set; }
        public string DnsServers { get; internal set; }
        public string IsDhcpEnabled { get; internal set; }
    }
}
