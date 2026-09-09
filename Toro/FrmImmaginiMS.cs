using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
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
        //Dichiarazione API per impostare lo sfondo del Desktop.
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        private const int SPI_SETDESKWALLPAPER = 20;
        private const int SPIF_UPDATEINIFILE = 0x01;
        private const int SPIF_SENDWININICHANGE = 0x02;



        private void FrmImmaginiMS_Load(object sender, EventArgs e)
        {
            //TODO: PEr le immagini di windows, non aprirle nelle cartelle ma visualizzarle in altra cartlella così rimangono salvate
            try
            {
                //Per ora download da bing
                this.Text = Utility.TitoloFinestra;

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

        /// <summary>
        /// Verificare se tenerla
        /// </summary>
        private void TrovaImmaginiBloccoSchermo()
        {

            try
            {
                string percorsoImmaginiBloccoSchermo = @"\Packages\Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy\LocalState\Assets";






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



        private void CaricaImmaginiDiBloccoSchermo()
        {
            try
            {

                //TODO: Fare ricerca solo su certe dimensioni e peso





            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }






        }




        #endregion










        /// <summary>
        /// Per il download delle immagini  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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

        private void tbcImmaginiMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcImmaginiMS?.SelectedTab?.Name == "tbpImmaginiBlocco")
            {
                CaricaImmaginiDiBloccoSchermo();
            }
            else if (tbcImmaginiMS?.SelectedTab?.Name == "tbpContenuti")
            {

            }
        }

        private void MniSalva_Click(object sender, EventArgs e)
        {
            try
            {
                //TODO: rendere il menu visibile solo se sono presenti i file
                //TODO: Prendere spunto da Lupo







            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }
        }

        private void MniApri_Click(object sender, EventArgs e)
        {
            try
            {

                //TODO: in base al tab aperto
                //if (lsbListaFile.SelectedItem == null)
                //    return;

                //if (lsbListaFile.Items.Count == 0)
                //{
                //    Utility.MessaggioInfo("Nessun file presente nella lista.");
                //    return;
                //}

                //string percorsoFileDaAprire = Path.Combine(percorsoCartella, lsbListaFile.SelectedItem.ToString());
                //if (!File.Exists(percorsoFileDaAprire))
                //{
                //    return;
                //}
                //string argument = "/select, \"" + percorsoFileDaAprire + "\"";

                //Process.Start("explorer.exe", argument);
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }
        }

        private void BtnCercaCartellaPerSfondo_Click(object sender, EventArgs e)
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
                        TxtPercorsoFileSfondo.Text = folderBrowserDialog.SelectedPath;
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
