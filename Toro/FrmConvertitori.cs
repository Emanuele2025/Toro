using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Toro
{
    public partial class FrmConvertitori : Form
    {
        public FrmConvertitori()
        {
            InitializeComponent();
        }

        //campi
        private static readonly int[] valori =
           {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        private static readonly string[] simboli =
            {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};




        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConverti_Click(object sender, EventArgs e)
        {
            try
            {

                if (TxtNumero.Text.Trim() == "") return;
                if (!int.TryParse(TxtNumero.Text, out int anno))
                {
                    MessageBox.Show("Errore: inserire un numero intero valido.");
                    return;
                }
                string numeroRomano = ConvertiInNumeriRomano(anno);
                TxtNumeroRomanoRisultato.Text = numeroRomano;


            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void TxtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo numeri (0-9), backspace e cancel
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\r' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Blocca il carattere
            }

        }

        private void BtnConvertiRomanoNumero_Click(object sender, EventArgs e)
        {
            try
            {

                if (TxtRomanoNumero.Text.Trim() == "") return;



            }
            catch (Exception ex)
            {

                throw;
            }
        }




        #region Funzioni

        private  string ConvertiInNumeriRomano(int numero)
        {
            if (numero < 1 || numero > 2100)
                throw new ArgumentOutOfRangeException(nameof(numero),
                    "Il numero deve essere compreso tra 1 e 2100.");

            var risultato = string.Empty;

            for (int i = 0; i < valori.Length; i++)
            {
                while (numero >= valori[i])
                {
                    numero -= valori[i];
                    risultato += simboli[i];
                }
            }

            return risultato;
        }
        #endregion














    }
}
