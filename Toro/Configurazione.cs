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

                        percorsoCartellaSfondi = PercorsoSalvato.PercorsoCartellaFileSfondiSalvati;
                    }

                }
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        
        return percorsoCartellaSfondi;


        }

        public bool SalvaDati(string percorsoCartellaDownload, DateTime ultimoDownload)
        {
            bool esito = false;
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(PercorsoCartellaFileConfigurazione));
                Impostazioni impostazioniDaSalvare = new Impostazioni();
                var Opzioni = new JsonSerializerOptions { WriteIndented = true };
                impostazioniDaSalvare.PercorsoCartellaFileSfondiSalvati = percorsoCartellaDownload;
              //  impostazioniDaSalvare.DataUltimoDownload = ultimoDownload;

                string serializzoImpostaioni = JsonSerializer.Serialize(impostazioniDaSalvare, Opzioni);

                File.WriteAllText(PercorsoCartellaFileConfigurazione, serializzoImpostaioni);


            }
            catch (Exception ex)
            {

                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }


            return esito;

        }

    }

    class Impostazioni
    {
        /// <summary>
        /// Percorso 
        /// </summary>
        public string PercorsoCartellaFileSfondiSalvati { get; set; } = "";

        public string PercorsoCartellaFileSfondiSuggeritiSalvati { get; set; } = "";

    }





}
