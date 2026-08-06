using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
                //Verifico se è stato selezionato il file
                if (string.IsNullOrEmpty(TxtPercorsoCartella.Text.Trim()))
                {
                    Utility.MessaggioInfo("Selezionare un file PDF.");
                    return;
                }





            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);

            }
        }
    }
}
