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
                Utility.MessaggioErrore(ex.Message);
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
                int numero = ConvertiRomanoInNumero(TxtRomanoNumero.Text);
                TxtRomaNumeroRisultato.Text = numero.ToString();

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Utility.MessaggioErrore("Errore:" + ex.Message);
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }

 
             
        }




        #region Funzioni


        /// <summary>
        /// Funzione che permette di cambiare numeri in numeri dell'antica Roma
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private string ConvertiInNumeriRomano(int numero)
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


        /// <summary>
        /// Funzione per convertire un valore romano in numero
        /// </summary>
        /// <param name="romano"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        private int ConvertiRomanoInNumero(string romano)
        {
            if (string.IsNullOrWhiteSpace(romano))
                throw new ArgumentException("Il numero romano non può essere vuoto.");

            romano = romano.ToUpper();

            //Associo simboli a numeri
            var mappa = new Dictionary<char, int>
        {
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
            {'C', 100}, {'D', 500}, {'M', 1000}
        };

            int totale = 0;
            int valorePrecedente = 0;

            foreach (char c in romano)
            {
                if (!mappa.ContainsKey(c))
                    throw new ArgumentException($"Simbolo romano non valido: {c}");

                int valore = mappa[c];

                //Se il valore attuale è maggiore del precedente, significa sottrazione
                if (valore > valorePrecedente)
                {
                    totale += valore - 2 * valorePrecedente;
                }
                else
                {
                    totale += valore;
                }

                valorePrecedente = valore;
            }

            //Valido se la conversine è andata a buon fine, trasformandolo in numero romano
            string ricostruito = ConvertiInNumeriRomano(totale);
            if (ricostruito != romano)
                throw new ArgumentException("Numero romano non valido o formato scorretto.");

            return totale;
        }









        #endregion






        private void TxtCaselle_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Yellow;
        }

        private void TxtCaselle_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }






    }
}
