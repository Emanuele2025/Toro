using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Toro
{
    public partial class FrmVerifichecs : Form
    {
        public FrmVerifichecs()
        {
            InitializeComponent();
        }

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVerificaIban_Click(object sender, EventArgs e)
        {

        }

        private void BtnVerificaPalindromo_Click(object sender, EventArgs e)
        {

            try
            {
                if (TxtPalindromo.Text.Trim() == "")
                {
                    Utility.MessaggioInfo("Inserire del testo nella casella di testo");
                    return;
                }
                isPalindromo(TxtPalindromo.Text.Trim());


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }


        }


        #region Funzioni




        private void isPalindromo(string testo)

        {

            string testoInvertito = new(testo.Reverse().ToArray());

            if (testo == testoInvertito)

            {

                TxtPalindromoRisultato.Text = "Il testo è un palindromo";

            }

            else

            {

                TxtPalindromoRisultato.Text = "Il testo non è un palindromo";

            }

        }


        #endregion




        private void TxtPalindromo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Consente solo lettere e carattere di controllo (es. backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
