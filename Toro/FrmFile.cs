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
                //TODO:
                //https://emanuelemattei.blogspot.com/2025/04/c-classe-per-gestire-i-file-vcf.html


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
                            X509Certificate2 cert = firma.Certificate;
                            if (cert != null)
                            {
                                DtoFirmaDigitale dtoCertificato = new DtoFirmaDigitale()
                                {
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
                if (TxtPercorsoVCF.Text.Trim() == "")
                {
                    Utility.MessaggioInfo("Selezionare la cartella contenente i file VCF.");
                    return;
                }
                
                
                DtoContattiVcf contatti = new DtoContattiVcf();
                var listaContatti = contatti.Contatti(TxtPercorsoVCF.Text.Trim());
                if (listaContatti.Count == 0)
                {
                    Utility.MessaggioInfo("File VCF non presente nella cartella selezionata");
                }

                dtgDatiVcf.DataSource = listaContatti.ToList();

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
    }
}
