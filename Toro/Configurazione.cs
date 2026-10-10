using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

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



        public string OttieniCartellaSfondi()
        {
            string percorsoCartellaSfondi = "";
            try
            {
                if (File.Exists(PercorsoCartellaFileConfigurazione))
                {
                    string FileJson = File.ReadAllText(PercorsoCartellaFileConfigurazione);
                    var Opzioni = new JsonSerializerOptions { ReadCommentHandling = JsonCommentHandling.Skip };
                    var PercorsoSalvato = JsonSerializer.Deserialize<Impostazioni>(FileJson, Opzioni);
                    if (PercorsoSalvato != null)
                    {

                        percorsoCartellaSfondi = PercorsoSalvato.PercorsoCartellaFileSfondi;
                    }

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        
        return percorsoCartellaSfondi;


        }
 


    }

    class Impostazioni
    {
        /// <summary>
        /// Percorso 
        /// </summary>
        public string PercorsoCartellaFileSfondi { get; set; } = "";

        public DateTime DataUltimoDownload { get; set; }

    }





}
