using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;
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

        //Campi

        private Image? _currentImage;

        private CancellationTokenSource? _importCancellation;




        private void FrmImmaginiMS_Load(object sender, EventArgs e)
        {

            //TODO salvare il percorso nella cartella utente
            //Fare la visualizzazione solo quando si fa click sul tab 


            try
            {

                this.Text = Utility.TitoloFinestra;

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }

        }

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region funzioni



        /// <summary>
        /// Funzione che permette di scaricare il  file immagine del motore di ricerca bing.
        /// </summary>
        /// <param name="percorsoSalvataggio"></param>
        /// <returns></returns>
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



        private async void CaricaImmaginiDiBloccoSchermo()
        {
            try
            {

                if (TxtPercorsoFileSfondo.Text.Trim() == "")
                {
                    Utility.MessaggioInfo("Selezionare un percorso valido");
                    return;
                }


                //TODO: Fare ricerca solo su certe dimensioni e peso





                //     lstboxFile.DisplayMember =
                //nameof(SpotlightImage.DisplayName);



                // Crea la cartella di destinazione nel caso che non c'è
                Directory.CreateDirectory(TxtPercorsoFileSfondo.Text.Trim());

                // Carica nella ListBox le immagini già presenti
                await LoadDestinationImagesAsync();

                // Aggiorna il testo informativo
                labelInfo.Text =
                    $"Immagini archiviate: {lstboxFile.Items.Count}";











            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }






        }


        #region Gestione schermata di blocco




        private async Task ImportSpotlightImagesAsync()
        {
            // -----------------------------------------------------
            // Annulla eventuale importazione precedente
            // -----------------------------------------------------

            _importCancellation?.Cancel();

            _importCancellation?.Dispose();

            _importCancellation =
                new CancellationTokenSource();

            CancellationToken cancellationToken =
                _importCancellation.Token;

            string spotlightPath = Path.Combine(
           Environment.GetFolderPath(
               Environment.SpecialFolder.LocalApplicationData),
           "Packages",
           "Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy",
           "LocalState",
           "Assets");
            try
            {
                SetUiImportingState(true);


                // -------------------------------------------------
                // Verifica cartella Spotlight
                // -------------------------------------------------

                if (!Directory.Exists(spotlightPath))
                {
                    MessageBox.Show(
                        $"La cartella di Windows Spotlight non è stata trovata:\n\n" +
                        $"{spotlightPath}",
                        "Cartella non trovata",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }


                // -------------------------------------------------
                // Crea cartella destinazione
                // -------------------------------------------------

                Directory.CreateDirectory(
                    TxtPercorsoFileSfondo.Text.Trim());


                // -------------------------------------------------
                // Informazioni iniziali
                // -------------------------------------------------

                labelInfo.Text =
                    "Ricerca delle immagini Spotlight...";


                // -------------------------------------------------
                // Esegue l'importazione in background
                // -------------------------------------------------

                ImportResult result =
                    await Task.Run(
                        () => ImportImages(
                            spotlightPath,
                            TxtPercorsoFileSfondo.Text.Trim(),
                            cancellationToken),
                        cancellationToken);


                cancellationToken.ThrowIfCancellationRequested();


                // -------------------------------------------------
                // Ricarica la ListBox
                // -------------------------------------------------

                await LoadDestinationImagesAsync();


                // -------------------------------------------------
                // Messaggio finale
                // -------------------------------------------------

                labelInfo.Text =
                    $"Archiviate: {result.TotalImages}   |   " +
                    $"Nuove: {result.CopiedImages}   |   " +
                    $"Già presenti: {result.SkippedImages}";


                MessageBox.Show(
                    $"Importazione completata.\n\n" +
                    $"Immagini analizzate: {result.TotalFiles}\n" +
                    $"Immagini 1920 × 1080 > 800 KB: {result.TotalImages}\n" +
                    $"Nuove immagini copiate: {result.CopiedImages}\n" +
                    $"Immagini già presenti: {result.SkippedImages}\n\n" +
                    $"Cartella:\n{TxtPercorsoFileSfondo.Text.Trim()}",
                    "Importazione completata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (OperationCanceledException)
            {
                labelInfo.Text =
                    "Importazione annullata.";
            }
            catch (Exception ex)
            {
                labelInfo.Text =
                    "Errore durante l'importazione.";

                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
            finally
            {
                SetUiImportingState(false);
            }
        }

        private static ImportResult ImportImages(
        string sourceFolder,
        string destinationFolder,
        CancellationToken cancellationToken)
        {
            ImportResult result = new();


            // -----------------------------------------------------
            // Otteniamo tutti i file di Spotlight
            // -----------------------------------------------------

            foreach (string sourceFile in
                     Directory.EnumerateFiles(
                         sourceFolder,
                         "*",
                         SearchOption.TopDirectoryOnly))
            {
                cancellationToken.ThrowIfCancellationRequested();

                result.TotalFiles++;


                try
                {
                    FileInfo fileInfo =
                        new(sourceFile);


                    // ---------------------------------------------
                    // FILTRO DIMENSIONE
                    // > 800 KB
                    // ---------------------------------------------

                    if (fileInfo.Length <= 800 * 1024)
                        continue;


                    // ---------------------------------------------
                    // APERTURA DELL'IMMAGINE
                    // ---------------------------------------------

                    using Image image =
                        Image.FromFile(sourceFile);


                    // ---------------------------------------------
                    // FILTRO RISOLUZIONE
                    // ---------------------------------------------

                    if (image.Width != 1920 ||
                        image.Height != 1080)
                    {
                        continue;
                    }


                    result.TotalImages++;


                    // ---------------------------------------------
                    // Determina il formato reale
                    // ---------------------------------------------

                    string extension =
                        GetImageExtension(image);


                    // ---------------------------------------------
                    // Calcola SHA-256
                    // ---------------------------------------------

                    string hash =
                        CalculateSha256(sourceFile);


                    // ---------------------------------------------
                    // Nome destinazione
                    //
                    // Esempio:
                    //
                    // Spotlight_a83f91....jpg
                    // ---------------------------------------------

                    string destinationFile =
                        Path.Combine(
                            destinationFolder,
                            $"Spotlight_{hash}{extension}");


                    // ---------------------------------------------
                    // Verifica se è già presente
                    // ---------------------------------------------

                    if (File.Exists(destinationFile))
                    {
                        result.SkippedImages++;
                        continue;
                    }


                    // ---------------------------------------------
                    // Copia
                    // ---------------------------------------------

                    File.Copy(
                        sourceFile,
                        destinationFile,
                        overwrite: false);


                    result.CopiedImages++;
                }
                catch (OutOfMemoryException)
                {
                    // File non riconosciuto come immagine
                }
                catch (ArgumentException)
                {
                    // Formato immagine non supportato
                }
                catch (UnauthorizedAccessException)
                {
                    // File non accessibile
                }
                catch (IOException)
                {
                    // File eventualmente in uso
                }
            }


            return result;
        }

        private static string GetImageExtension(
        Image image)
        {
            ImageFormat format =
                image.RawFormat;


            if (format.Guid == ImageFormat.Jpeg.Guid)
                return ".jpg";


            if (format.Guid == ImageFormat.Png.Guid)
                return ".png";


            if (format.Guid == ImageFormat.Gif.Guid)
                return ".gif";


            if (format.Guid == ImageFormat.Bmp.Guid)
                return ".bmp";


            if (format.Guid == ImageFormat.Tiff.Guid)
                return ".tiff";


            if (format.Guid == ImageFormat.Icon.Guid)
                return ".ico";


            // Fallback
            return ".jpg";
        }

        private static string CalculateSha256(
        string filePath)
        {
            using SHA256 sha256 =
                SHA256.Create();

            using FileStream stream =
                File.OpenRead(filePath);

            byte[] hash =
                sha256.ComputeHash(stream);

            return Convert.ToHexString(
                hash).ToLowerInvariant();
        }

        private async Task LoadDestinationImagesAsync()
        {
            try
            {
                List<SpotlightImage> images =
                    await Task.Run(
                        () => GetDestinationImages());


                lstboxFile.BeginUpdate();

                try
                {
                    lstboxFile.Items.Clear();

                    foreach (SpotlightImage image in images)
                    {
                        lstboxFile.Items.Add(image);
                    }
                }
                finally
                {
                    lstboxFile.EndUpdate();
                }
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }


        private List<SpotlightImage> GetDestinationImages()
        {
            List<SpotlightImage> result = [];
            string spotlightPath = Path.Combine(
             Environment.GetFolderPath(
                 Environment.SpecialFolder.LocalApplicationData),
             "Packages",
             "Microsoft.Windows.ContentDeliveryManager_cw5n1h2txyewy",
             "LocalState",
             "Assets");

            if (!Directory.Exists(TxtPercorsoFileSfondo.Text.Trim()))
                return result;


            foreach (string filePath in
                     Directory.EnumerateFiles(
                         TxtPercorsoFileSfondo.Text.Trim(),
                         "*",
                         SearchOption.TopDirectoryOnly))
            {
                try
                {
                    FileInfo fileInfo =
                        new(filePath);


                    using Image image =
                        Image.FromFile(filePath);


                    result.Add(
                        new SpotlightImage
                        {
                            FileName =
                                fileInfo.Name,

                            FullPath =
                                fileInfo.FullName,

                            FileSize =
                                fileInfo.Length,

                            Width =
                                image.Width,

                            Height =
                                image.Height
                        });
                }
                catch
                {
                    // Ignora eventuali file non immagine
                }
            }


            return result
                .OrderByDescending(
                    x => x.FileName)
                .ToList();
        }

        private void ListBoxImages_SelectedIndexChanged(
       object? sender,
       EventArgs e)
        {
            if (lstboxFile.SelectedItem
                is not SpotlightImage selected)
            {
                ClearPreview();
                return;
            }


            try
            {
                // ---------------------------------------------
                // Carica l'immagine
                // ---------------------------------------------

                using Image source =
                    Image.FromFile(
                        selected.FullPath);


                // ---------------------------------------------
                // Crea una copia indipendente dal file
                // ---------------------------------------------

                Bitmap preview =
                    new(
                        source.Width,
                        source.Height);


                using (Graphics graphics =
                       Graphics.FromImage(preview))
                {
                    graphics.DrawImage(
                        source,
                        0,
                        0,
                        source.Width,
                        source.Height);
                }


                // ---------------------------------------------
                // Sostituisce l'immagine precedente
                // ---------------------------------------------

                Image? oldImage =
                    _currentImage;


                _currentImage =
                    preview;


                pcbAnteprima.Image =
                    _currentImage;


                oldImage?.Dispose();


                // ---------------------------------------------
                // Informazioni
                // ---------------------------------------------

                labelInfo.Text =
                    $"{selected.FileName}    |    " +
                    $"{selected.Width} × {selected.Height}    |    " +
                    $"{FormatFileSize(selected.FileSize)}";
            }
            catch (Exception ex)
            {
                ClearPreview();


                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }

        private void ClearPreview()
        {
            Image? oldImage =
                _currentImage;


            _currentImage = null;

            pcbAnteprima.Image = null;

            oldImage?.Dispose();
        }

        private void SetUiImportingState(
        bool importing)
        {


            lstboxFile.Enabled =
                !importing;



        }
        #endregion
        private static string FormatFileSize(
        long bytes)
        {
            if (bytes >= 1024 * 1024)
            {
                double mb =
                    bytes /
                    (1024.0 * 1024.0);

                return $"{mb:F2} MB";
            }


            double kb =
                bytes / 1024.0;


            return $"{kb:F0} KB";
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
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
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
                Utility.MessaggioErrore(Utility.Errore + ex.Message);

            }
        }

        private void tbcImmaginiMS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcImmaginiMS?.SelectedTab?.Name == "tbpImmaginiBlocco")
            {
                //TODO: Gestire in futuro il salvataggio del percorso nel local utente.
                if (TxtPercorsoFileSfondo.Text.Trim() == "")
                {

                    return;
                }
                //      CaricaImmaginiDiBloccoSchermo();
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
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }

        private void MniApri_Click(object sender, EventArgs e)
        {
            try
            {


                string percorsoFileImmagine = "";
                if (tbcImmaginiMS.SelectedTab.Name == "tbpImmaginiBlocco")
                {
                    if (lstboxFile.SelectedIndex < 0)
                    {
                        Utility.MessaggioInfo("Selezionare un file.");
                        return;
                    }
                    if (lstboxFile.SelectedItem
                    is not SpotlightImage selected)
                    {

                        return;
                    }


                    percorsoFileImmagine = selected.FullPath;

                }




                if (!File.Exists(percorsoFileImmagine))
                {
                    return;
                }
                string argument = "/select, \"" + percorsoFileImmagine + "\"";

                Process.Start("explorer.exe", argument);
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }

        private void BtnCercaCartellaPerSfondo_Click(object sender, EventArgs e)
        {
            try
            {
                //Apro la finestra di dialogo per la selezione della cartella
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "Seleziona la cartella di destinazione per salvare l'immagine di sfondo del blocco del pc.";
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Imposto il percorso selezionato nella casella di testo
                        TxtPercorsoFileSfondo.Text = folderBrowserDialog.SelectedPath;
                    }
                }


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);

            }
        }

        private void BtnCopiaSfondo_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtPercorsoFileSfondo.Text.Trim() == "")
                {
                    Utility.MessaggioInfo("Selezionare una cartella per la copia dei file");
                    return;
                }
                //CaricaImmaginiDiBloccoSchermo();
                ImportSpotlightImagesAsync();


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }

        private void BtnContenutiSuggeriti_Click(object sender, EventArgs e)
        {
            try
            {

                try
                {
                    //Apro la finestra di dialogo per la selezione della cartella
                    using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                    {
                        folderBrowserDialog.Description = "Seleziona la cartella di destinazione per salvare l'immagine contenuti suggeriti";
                        if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                        {
                            // Imposto il percorso selezionato nella casella di testo
                            TxtContenutiSuggeriti.Text = folderBrowserDialog.SelectedPath;
                        }
                    }


                }
                catch (Exception ex)
                {
                    Utility.MessaggioErrore(Utility.Errore + ex.Message);

                }




            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }

        private void MniImpostaSfondo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string percorsoFileImmagine = "";
                if (tbcImmaginiMS.SelectedTab.Name == "tbpImmaginiBlocco")
                {




                    if (lstboxFile.SelectedIndex < 0)
                    {
                        Utility.MessaggioInfo("Selezionare un file.");
                        return;
                    }
                    if (lstboxFile.SelectedItem
                    is not SpotlightImage selected)
                    {

                        return;
                    }


                      percorsoFileImmagine = selected.FullPath;
                    
                }
                else
                {
                    if (PctAnteprimaContenuti.Image == null)
                    {
                        Utility.MessaggioInfo("Selezionare un file.");
                        return;
                    }
                }
                if (string.IsNullOrWhiteSpace(percorsoFileImmagine))
                {
                    Utility.MessaggioInfo("Selezionare un file.");
                    return;
                }

                bool risultato = SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, percorsoFileImmagine, SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
                if (!risultato)
                {
                    throw new Exception("Impossibile impostare l'immagine come sfondo del desktop.");
                }
                if (risultato)
                {
                    Utility.MessaggioInfo("Immagine impostata come sfondo.");
                }

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void CmsImpostaComeSfondo_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = (pcbAnteprima.Image == null);
        }

        private void BtnCopiaContenuti_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtPercorsoFileSfondo.Text.Trim() == "")
                {
                    Utility.MessaggioInfo("Selezionare una cartella per la copia dei file");
                    return;
                }





            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(Utility.Errore + ex.Message);
            }
        }
    }
    public sealed class SpotlightImage
    {
        public string FileName { get; init; } =
            string.Empty;


        public string FullPath { get; init; } =
            string.Empty;


        public long FileSize { get; init; }


        public int Width { get; init; }


        public int Height { get; init; }


        // Testo visualizzato nella ListBox
        public string DisplayName
        {
            get
            {
                return
                    $"{FileName}    " +
                    $"{Width} × {Height}    " +
                    $"{FormatSize(FileSize)}";
            }
        }


        private static string FormatSize(
            long bytes)
        {
            if (bytes >= 1024 * 1024)
            {
                double mb =
                    bytes /
                    (1024.0 * 1024.0);

                return $"{mb:F2} MB";
            }


            double kb =
                bytes / 1024.0;


            return $"{kb:F0} KB";
        }


        public override string ToString()
        {
            return DisplayName;
        }
    }

    public sealed class ImportResult
    {
        public int TotalFiles { get; set; }

        public int TotalImages { get; set; }

        public int CopiedImages { get; set; }

        public int SkippedImages { get; set; }
    }
}
