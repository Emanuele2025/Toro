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












    }
}
