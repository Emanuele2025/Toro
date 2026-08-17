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
                    folderBrowserDialog.RootFolder =  Environment.SpecialFolder.Desktop;
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
    }
}
