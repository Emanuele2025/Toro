using System;
using System.Collections.Generic;
using System.Text;

namespace Toro.Modelli
{
    /// <summary>
    /// Per la gestione dei file firmati digitalmente
    /// </summary>
    public class DtoFirmaDigitale
    {
        public string NomeFirmatario { get; set; }

        public string Oggetto { get; set; }

        public DateTime DataInizio { get; set; }

        public DateTime DataFine { get; set; }

    }
}
