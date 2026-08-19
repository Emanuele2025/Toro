using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace Toro
{
    public partial class FrmGallery : Form
    {
        public FrmGallery()
        {
            InitializeComponent();
        }
        private string[] imgFiles;
        private int indiceCorrente = 0;

        private void FrmGallery_Load(object sender, EventArgs e)
        {
            try
            {


                





            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void BtnTrovaCartella_Click(object sender, EventArgs e)
        {
            try
            {
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    folderBrowserDialog.Description = "Seleziona la cartella dove si trovano i file Immagine";
                    folderBrowserDialog.RootFolder = Environment.SpecialFolder.Desktop;
                    if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Imposto il percorso selezionato nella casella di testo
                        TxtPercorsoImmagini.Text = folderBrowserDialog.SelectedPath;
                    }
                }




            }
            catch (Exception)
            {

                throw;
            }
        }




        private void LoadImagesDaCartella(string cartella)
        {
            try
            {
                if (!Directory.Exists(cartella))
                {
                    Directory.CreateDirectory(cartella);
                }

                // Filtra solo formati immagine comuni
                

                  imgFiles = Directory.GetFiles(cartella)
                    .Where(file =>
                        file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                        file.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                        file.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                        file.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                        file.EndsWith(".gif", StringComparison.OrdinalIgnoreCase)
                    )
                    .ToArray();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nel caricamento immagini: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                imgFiles = Array.Empty<string>();
            }
        }

        private void BtnAvvia_Click(object sender, EventArgs e)
        {
            if (TxtPercorsoImmagini.Text.Trim() == "")
            {
                MessageBox.Show($"Seleziona un percorso dove sono presenti le immagini", "Gallery", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            timer1.Interval = (int)nudSecondi.Value;
            LoadImagesDaCartella(TxtPercorsoImmagini.Text);
            if(imgFiles.Length >0)
                timer1.Start();
            else
                MessageBox.Show("Nessuna immagine trovata nella cartella 'Images'.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                indiceCorrente = (indiceCorrente + 1) % imgFiles.Length;
                pcbGalleria.Image?.Dispose(); // Libera la precedente immagine
                pcbGalleria.Image = Image.FromFile(imgFiles[indiceCorrente]);
            }
            catch (Exception ex)
            {
                timer1.Stop();
                MessageBox.Show($"Errore durante il caricamento dell'immagine: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
