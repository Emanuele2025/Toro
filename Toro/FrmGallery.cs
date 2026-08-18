using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Toro
{
    public partial class FrmGallery : Form
    {
        public FrmGallery()
        {
            InitializeComponent();
        }
        private string[] imgiles;


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




        private void LoadImagesFromFolder(string folderPath)
        {
            try
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // Filtra solo formati immagine comuni
                imgiles = Directory.GetFiles(folderPath, "*.*")
                    ?? Array.Empty<string>();

                imgiles = Array.FindAll(imgiles, file =>
                    file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                    file.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                    file.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                    file.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                    file.EndsWith(".gif", StringComparison.OrdinalIgnoreCase)
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore nel caricamento immagini: {ex.Message}", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                imgiles = Array.Empty<string>();
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
            LoadImagesFromFolder(TxtPercorsoImmagini.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
