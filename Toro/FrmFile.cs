using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Toro.Modelli;

namespace Toro
{
    public partial class FrmFile : Form
    {
        public FrmFile()
        {
            InitializeComponent();
        }

        private void FrmFile_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = Utility.TitoloFinestra;




            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore: " + ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;

            }


        }

        private void BtnCercaCartella_Click(object sender, EventArgs e)
        {
            try
            {

                using (OpenFileDialog openDlg = new OpenFileDialog())
                {

                    openDlg.Multiselect = false;

                    openDlg.Filter = "PDF Files (*.pdf) | *.pdf";

                    if (openDlg.ShowDialog(this) == DialogResult.OK)
                    {
                        TxtPercorsoCartella.Text = openDlg.FileName;
                    }

                }



            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);

            }
        }

        private void BtnLeggiCertificatiPdf_Click(object sender, EventArgs e)
        {
            try
            {
                dtgCertificatiFilePdf.DataSource = null;
                //Verifico se è stato selezionato il file
                if (string.IsNullOrEmpty(TxtPercorsoCartella.Text.Trim()))
                {
                    Utility.MessaggioInfo("Selezionare un file PDF.");
                    return;
                }
                List<DtoFirmaDigitale> certificatiTrovati = new List<DtoFirmaDigitale>();
                string pdfPath = @TxtPercorsoCartella.Text.Trim();
                byte[] pdfBytes = File.ReadAllBytes(pdfPath);
                string pdfText = Encoding.ASCII.GetString(pdfBytes);

                // Trova TUTTI i blocchi /Contents <...>
                MatchCollection matches = Regex.Matches(pdfText, @"/Contents\s*<([0-9A-Fa-f]+)>");

                if (matches.Count == 0)
                {
                    Utility.MessaggioInfo("Nessuna firma digitale trovata nel PDF.");
                    return;
                }



                int firmaIndex = 1;
                foreach (Match match in matches)
                {
                    try
                    {
                        byte[] signatureBytes = HexStringToBytes(match.Groups[1].Value);

                        SignedCms cms = new SignedCms();
                        cms.Decode(signatureBytes);

                        foreach (var firma in cms.SignerInfos)
                        {
                            X509Certificate2 cert = firma?.Certificate;
                            if (cert != null)
                            {
                                DtoFirmaDigitale dtoCertificato = new DtoFirmaDigitale()
                                {
                                    NomeFirmatario = cert.GetNameInfo(X509NameType.SimpleName, false),
                                    Oggetto = cert.Subject,
                                    EmessoDa = cert.Issuer,
                                    DataInizio = cert.NotBefore,
                                    DataFine = cert.NotAfter,
                                    Algoritmo = cert.SignatureAlgorithm?.FriendlyName ?? "",
                                    Seriale = cert.SerialNumber


                                };
                                certificatiTrovati.Add(dtoCertificato);
                            }




                        }
                    }
                    catch (Exception ex)
                    {
                        Utility.MessaggioErrore($"Errore nella lettura della firma #{firmaIndex}: {ex.Message}\n");
                    }

                    firmaIndex++;
                }

                dtgCertificatiFilePdf.DataSource = certificatiTrovati;


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);

            }
        }


        #region funzioni


        /// <summary>
        /// Per la firma digitale
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        byte[] HexStringToBytes(string hex)
        {
            if (hex.Length % 2 != 0)
                throw new ArgumentException("Stringa esadecimale non valida.");

            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);

            return bytes;
        }




        private void NascondiDocxInPng(string pathImmaginePng, string pathDocx, string pathNuovoFilePng)

        {

            try

            {





                //Rilevo i byte del file immagine e del file doc

                byte[] pngBytes = File.ReadAllBytes(pathImmaginePng);

                byte[] docxBytes = File.ReadAllBytes(pathDocx);



                //Marcatore per ritrovare il file dopo. 16 byte a caso

                byte[] marcatore = { 0xDE, 0xAD, 0xBE, 0xEF, 0xCA, 0xFE, 0xBA, 0xBE,

                 0xDE, 0xAD, 0xBE, 0xEF, 0xCA, 0xFE, 0xBA, 0xBE };



                //Creo il nuovo file unendo i due array byte

                using (FileStream fs = new FileStream(pathNuovoFilePng, FileMode.Create))

                {

                    fs.Write(pngBytes, 0, pngBytes.Length);

                    fs.Write(marcatore, 0, marcatore.Length);

                    fs.Write(BitConverter.GetBytes(docxBytes.Length), 0, 4);

                    fs.Write(docxBytes, 0, docxBytes.Length);

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show("Errore: " + ex.Message);

            }


        }


        private int IndexOf(byte[] arrayBytePng, byte[] marcatore)

        {

            for (int i = 0; i < arrayBytePng.Length - marcatore.Length; i++)

            {

                bool trovato = true;

                for (int j = 0; j < marcatore.Length; j++)

                {

                    if (arrayBytePng[i + j] != marcatore[j]) { trovato = false; break; }

                }

                if (trovato) return i;

            }

            return -1;

        }





        private void EstraiDocxDaPng(string pathPngConDocx, string pathOutputDocx)

        {

            try

            {





                byte[] tuttiBytes = File.ReadAllBytes(pathPngConDocx);

                byte[] marcatore = { 0xDE, 0xAD, 0xBE, 0xEF, 0xCA, 0xFE, 0xBA, 0xBE,

                 0xDE, 0xAD, 0xBE, 0xEF, 0xCA, 0xFE, 0xBA, 0xBE };



                //Trova il marcatore

                int posizione = IndexOf(tuttiBytes, marcatore);

                if (posizione == -1) throw new Exception("Nessun file trovato");



                posizione += marcatore.Length;

                int dimensioneDocx = BitConverter.ToInt32(tuttiBytes, posizione);

                posizione += 4;



                byte[] docxBytes = new byte[dimensioneDocx];

                Array.Copy(tuttiBytes, posizione, docxBytes, 0, dimensioneDocx);

                File.WriteAllBytes(pathOutputDocx, docxBytes);

            }

            catch (Exception ex)

            {

                MessageBox.Show("Errore: " + ex.Message);

            }


        }















        #endregion



        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnFileVCF_Click(object sender, EventArgs e)
        {
            //Apro la finestra di dialogo per la selezione della cartella
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Seleziona la cartella dove si trovano i file vcf";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    // Imposto il percorso selezionato nella casella di testo
                    TxtPercorsoVCF.Text = folderBrowserDialog.SelectedPath;
                }
            }
        }



        private void BtnRilevaVCF_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                string percorso = TxtPercorsoVCF.Text.Trim();

                if (string.IsNullOrWhiteSpace(percorso))
                {
                    Utility.MessaggioInfo(
                        "Selezionare la cartella contenente i file VCF.");

                    return;
                }

                if (!Directory.Exists(percorso))
                {
                    Utility.MessaggioInfo(
                        "La cartella selezionata non esiste.");

                    return;
                }

                DtoContattiVcf contatti = new DtoContattiVcf();

                List<DtoContattiVcf> listaContatti = contatti.Contatti(percorso);

                if (listaContatti.Count == 0)
                {
                    Utility.MessaggioInfo(
                        "Nessun file VCF presente nella cartella selezionata.");

                    return;
                }

                dtgDatiVcf.DataSource = listaContatti;


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;

            }
        }

        private void BtnSelezionaFileP7m_Click(object sender, EventArgs e)
        {
            try
            {

                using (OpenFileDialog openDlg = new OpenFileDialog())
                {

                    openDlg.Multiselect = false;

                    openDlg.Filter = "PDF Files (*.p7m) | *.p7m";

                    if (openDlg.ShowDialog(this) == DialogResult.OK)
                    {
                        TxtPercorsoFileP7m.Text = openDlg.FileName;
                    }

                }



            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);

            }
        }

        private void BtnEstrapolaFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtPercorsoFileP7m.Text.Trim() == "")
                {
                    Utility.MessaggioInfo("Selezionare un file P7M.");
                    return;
                }
                string PercorsoNomeFile = TxtPercorsoFileP7m.Text.Trim();
                try
                {
                    if (PercorsoNomeFile.Trim() == "")
                    {
                        MessageBox.Show("Selezionare un file firmato digitalmente, di tipo p7m");
                    }
                    byte[] FileFirmatoP7m = File.ReadAllBytes(PercorsoNomeFile);
                    if (FileFirmatoP7m == null)
                        throw new ArgumentNullException("Errore nel file firmato selezionato.");
                    //Uso la classe per estrapolare il fle
                    SignedCms cmsFirmato = new SignedCms();
                    cmsFirmato.Decode(FileFirmatoP7m);
                    if (cmsFirmato.Detached)
                        throw new InvalidOperationException("Errore nella fase di estrapolazione del contenuto dal file firmato.");
                    //Estrapola l'array byte del file firmato
                    byte[] FileRilevato = cmsFirmato.ContentInfo.Content;
                    SaveFileDialog fileDaSalvare = new SaveFileDialog();

                    string NomeFileDaCreare = new FileInfo(PercorsoNomeFile).Name.Replace(new FileInfo(PercorsoNomeFile).Extension, "");
                    fileDaSalvare.FileName = NomeFileDaCreare;
                    if (fileDaSalvare.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(fileDaSalvare.FileName, FileRilevato);
                        Utility.MessaggioInfo("File salvato correttamente in: " + fileDaSalvare.FileName);
                    }

                }
                catch (Exception ex)
                {
                    Utility.MessaggioErrore(ex.Message);
                }




            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);

            }

        }

        private void BtnCreaFile_Click(object sender, EventArgs e)
        {
            try
            {

                if (TxtPercorsoNomeFileImmagine.Text.ToString() == "")
                {

                    Utility.MessaggioInfo("Selezionare un file immagine Png dove si vuole aggiungere il file Word.");
                    return;
                }
                if (TxtPercorsoNomeFileDaNascondere.Text.ToString() == "")
                {

                    Utility.MessaggioInfo("Selezionare un file immagine word che si vuole aggiungere al file immagine.");
                    return;
                }

                SaveFileDialog fileDaSalvare = new SaveFileDialog();

                string NomeFileDaCreare = new FileInfo(TxtPercorsoNomeFileImmagine.Text.ToString()).Name;
                NomeFileDaCreare = "Word_" + NomeFileDaCreare;
                fileDaSalvare.FileName = NomeFileDaCreare;
                fileDaSalvare.Filter = "PNG File (*.png)|*.png";
                if (fileDaSalvare.ShowDialog() == DialogResult.OK)
                {
                    NascondiDocxInPng(TxtPercorsoNomeFileImmagine.Text.ToString(), TxtPercorsoNomeFileDaNascondere.Text.ToString(), fileDaSalvare.FileName);

                    Utility.MessaggioInfo("File salvato correttamente in: " + fileDaSalvare.FileName);
                }




            }
            catch (IOException exio)
            {
                Utility.MessaggioErrore(exio.Message);
            }
            catch (UnauthorizedAccessException exua)
            {
                Utility.MessaggioErrore(exua.Message);
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }
        }

        private void BtnTrovaImmagine_Click(object sender, EventArgs e)
        {

            try
            {
                using (OpenFileDialog openDlg = new OpenFileDialog())
                {

                    openDlg.Multiselect = false;

                    openDlg.Filter = "Immagine Files (*.png) | *.png";

                    if (openDlg.ShowDialog(this) == DialogResult.OK)
                    {
                        TxtPercorsoNomeFileImmagine.Text = openDlg.FileName;
                    }

                }

            }
            catch (IOException exio)
            {
                Utility.MessaggioErrore(exio.Message);
            }
            catch (UnauthorizedAccessException exua)
            {
                Utility.MessaggioErrore(exua.Message);
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }
        }

        private void BtnTrovaFileHacker_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openDlg = new OpenFileDialog())
                {
                    //Per ora solo docx, poi si vedrà per tutti
                    openDlg.Multiselect = false;

                    openDlg.Filter = "Tutti Files (*.docx) | *.docx";

                    if (openDlg.ShowDialog(this) == DialogResult.OK)
                    {
                        TxtPercorsoNomeFileDaNascondere.Text = openDlg.FileName;
                    }

                }

            }
            catch (IOException exio)
            {
                Utility.MessaggioErrore(exio.Message);
            }
            catch (UnauthorizedAccessException exua)
            {
                Utility.MessaggioErrore(exua.Message);
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }
        }

        private void BtnTrovaImmaginePngConFile_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openDlg = new OpenFileDialog())
                {

                    openDlg.Multiselect = false;

                    openDlg.Filter = "Immagine Files (*.png) | *.png";

                    if (openDlg.ShowDialog(this) == DialogResult.OK)
                    {
                        TxtImmagineConWord.Text = openDlg.FileName;
                    }

                }

            }
            catch (IOException exio)
            {
                Utility.MessaggioErrore(exio.Message);
            }
            catch (UnauthorizedAccessException exua)
            {
                Utility.MessaggioErrore(exua.Message);
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }
        }

        private void BtnRilevaFile_Click(object sender, EventArgs e)
        {
            try
            {

                if (TxtImmagineConWord.Text.ToString() == "")
                {

                    Utility.MessaggioInfo("Selezionare un file immagine Png contenente il file Word.");
                    return;
                }
                string PercorsoNomeFileWord = "";
                using (SaveFileDialog salvaDlg = new SaveFileDialog())
                {

                     

                    salvaDlg.Filter = "File Word (*.docx) | *.docx";
                    salvaDlg.Title = "Salva il file Word estratto dal file immagine Png";
                    salvaDlg.FileName = Path.GetFileName(TxtImmagineConWord.Text.ToString()).Replace(".png", ".docx");
                    salvaDlg.InitialDirectory = Path.GetFullPath(TxtImmagineConWord.Text.ToString());

                    if (salvaDlg.ShowDialog(this) == DialogResult.OK)
                    {
                        PercorsoNomeFileWord = salvaDlg.FileName;
                        EstraiDocxDaPng(TxtImmagineConWord.Text.ToString(), PercorsoNomeFileWord);
                        Utility.MessaggioInfo("File salvato correttamente in: " + PercorsoNomeFileWord);
                    }

                }


               



            }
            catch (IOException exio)
            {
                Utility.MessaggioErrore(exio.Message);
            }
            catch (UnauthorizedAccessException exua)
            {
                Utility.MessaggioErrore(exua.Message);
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }
        }
    }
}
