using System;
using System.Collections.Generic;
using System.Text;

namespace Toro.Modelli
{
    public class DtoStampante
    {
        public string Nome { get; set; } = string.Empty;
        public string NomeDriver { get; set; } = string.Empty;
        public string Porta { get; set; } = string.Empty;
        public bool Rete { get; set; }
        public bool Predefinita { get; set; }
        public string Stato { get; set; } = string.Empty;
        //public string Modello { get; set; }
        //public string Descrizione { get; set; }
        public bool Online { get; set; }
        public int NumeroLavoro { get; set; }
    }
}
