using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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



        #endregion












        private void BtnScaricaSfondoBing_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
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
