using System;
using System.Collections.Generic;
using System.Text;

namespace Toro
{
    /// <summary>
    /// Classe per la gestione della confiugurazione dell'applicazione.
    /// </summary>
    public class Configurazione
    {
        //Percorso della cartella di configurazione
        private static readonly string PercorsoCartella = Path.Combine(
           Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Toro");

        private static readonly string PercorsoCartellaFileConfigurazione = Path.Combine(PercorsoCartella, "Torosettings.json");













    }
}
