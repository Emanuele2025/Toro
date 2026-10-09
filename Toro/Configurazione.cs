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



        public (string PercorsoFile, DateTime DataUltimoDownload) OttieniPercorso()
        {

            try
            {

                if (!File.Exists(PercorsoCartellaFileConfigurazione)) return ("", DateTime.MinValue);
                string FileJson = File.ReadAllText(PercorsoCartellaFileConfigurazione);
                var Opzioni = new JsonSerializerOptions { ReadCommentHandling = JsonCommentHandling.Skip };
                var PercorsoSalvato = JsonSerializer.Deserialize<Impostazioni>(FileJson, Opzioni);

                if (PercorsoSalvato != null)
                {

                    return (PercorsoSalvato.PercorsoCartellaFileSfondi, PercorsoSalvato.DataUltimoDownload);
                }


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }
            return ("", DateTime.MinValue);
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
