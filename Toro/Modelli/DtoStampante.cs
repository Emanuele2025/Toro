using System;
using System.Collections.Generic;
using System.Text;

namespace Toro.Modelli
{
    public class DtoStampante
    {
        public string Nome { get; set; }
        public string NomeDriver { get; set; }
        public string Porta { get; set; }
        public bool Rete { get; set; }
        public bool Predefinita { get; set; }
        public string Stato { get; set; }
        //public string Modello { get; set; }
        //public string Descrizione { get; set; }
        public bool Online { get; set; }
        public int NumeroLavoro { get; set; }
    }
}
