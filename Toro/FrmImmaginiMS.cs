using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Toro
{
    public partial class FrmImmaginiMS : Form
    {
        public FrmImmaginiMS()
        {
            InitializeComponent();
        }

        private void FrmImmaginiMS_Load(object sender, EventArgs e)
        {
            //TODO: fare anche il tab per le immagini di lettura contenuti
            try
            {
                //Per ora download da bing


                TrovaImmaginiBloccoSchermo();


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }

        }

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region funzioni

        private void TrovaImmaginiBloccoSchermo()
        {

            try
            {

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore: " + ex.Message);
            }







        }

        static async Task DownloadImmagine(string percorsoSalvataggio)
        {
            //Percorso di Bing dove estrapolare l'immagine
            string bingApiUrl = "https://www.bing.com/HPImageArchive.aspx?format=js&idx=0&n=1&mkt=it-IT";

            //Richiesta http
            using HttpClient client = new HttpClient();

            try
            {
                //Rilevo codice html per la gestione JSON
                string json = await client.GetStringAsync(bingApiUrl);

                //Estraggo il nome dell'immagine ed il percorso dell'immagine bing
                using JsonDocument doc = JsonDocument.Parse(json);
                string urlBase = doc.RootElement
                    .GetProperty("images")[0]
                    .GetProperty("urlbase")
                    .GetString();

                //Nome del file da salvare
                string nomeFile = urlBase?.Split(".").Length > 1 ? urlBase.Split(".")[1] : urlBase;
                //rileva il sito preciso con l'immagine
                string imageUrl = $"https://www.bing.com{urlBase}_1920x1080.webp";
                nomeFile = percorsoSalvataggio + "\\" + nomeFile + ".webp";

                //Scarico l'immagine in array di byte
                byte[] imageBytes = await client.GetByteArrayAsync(imageUrl);
                await File.WriteAllBytesAsync(nomeFile, imageBytes);


                Utility.MessaggioInfo("File salvato con successo.");



            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }
        }




        #endregion












        private async void BtnScaricaSfondoBing_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                if (TxtPercorsoCartella.Text.Trim() == "")
                {

                    Utility.MessaggioInfo("Impostare un percorso dove salvare l'immagine.");
                    return;
                }
                


                await DownloadImmagine(TxtPercorsoCartella.Text.Trim());
                
                var files = new DirectoryInfo(TxtPercorsoCartella.Text.Trim()).GetFiles()
                    .Select(file => new
                    {
                        NomeFile = file.Name,
                        DataCreazione = file.CreationTime
                    })
                    .Where(file => file.NomeFile.EndsWith(".webp", StringComparison.OrdinalIgnoreCase))
                    .OrderByDescending(file => file.DataCreazione)
                    .ToList();

                List<string> fileNames = files.Select(f => f.NomeFile).ToList();
               // lsbListaFile.DataSource = fileNames;

                // Se ci sono file, seleziona il primo e carica l'immagine
                if (fileNames.Count > 0)
                {
                    //lsbListaFile.SelectedIndex = 0;
                    //CaricaImmagineDaListBox();
                }
                

                



            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void BtnCercaCartella_Click(object sender, EventArgs e)
        {
            try
            {
                //Apro la finestra di dialogo per la selezione della cartella
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "Seleziona la cartella di destinazione per salvare l'immagine di bing";
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Imposto il percorso selezionato nella casella di testo
                        TxtPercorsoCartella.Text = folderBrowserDialog.SelectedPath;
                    }
                }


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);

            }
        }
    }
}
