using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Toro
{
    public partial class FrmConvertitori : Form
    {
        public FrmConvertitori()
        {
            InitializeComponent();
        }
        #region Campi


        //campi
        private static readonly int[] valori =
           {1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
        private static readonly string[] simboli =
            {"M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};

        private static readonly string[] Unita = { "zero", "uno", "due", "tre", "quattro", "cinque", "sei", "sette", "otto", "nove" };

        private static readonly string[] Decine = { "", "dieci", "venti", "trenta", "quaranta", "cinquanta", "sessanta", "settanta", "ottanta", "novanta" };

        private static readonly string[] DecineSpeciali = { "dieci", "undici", "dodici", "tredici", "quattordici", "quindici", "sedici", "diciassette", "diciotto", "diciannove" };


        private static string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };



        private static string[] tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };



        private static string[] thousands = { "", "Thousand", "Million", "Billion" };

        //Fine campi
        #endregion


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






        public string ConvertiEuroInLettere(decimal importo, bool centesimiTesto = false)

        {

            if (importo == 0)

                return "zero euro";



            string euroParte = ConvertiNumeroInLettere((long)importo);

            int centesimiParte = (int)((importo - Math.Floor(importo)) * 100);

            if (centesimiTesto == false)

                return $"{euroParte} euro /{centesimiParte:00}";

            else

            {

                //tutto lettere

                string centesimiParteTesto = ConvertiNumeroInLettere((long)((importo - Math.Floor(importo)) * 100));



                return $"{euroParte} euro e {centesimiParteTesto} centesimi";

            }



        }



        private string ConvertiNumeroInLettere(long numero)

        {

            if (numero < 10)

                return Unita[numero];

            if (numero < 20)

                return DecineSpeciali[numero - 10];

            if (numero < 100)

                return Decine[numero / 10] + (numero % 10 > 0 ? Unita[numero % 10] : "");

            if (numero < 1000)

                return (numero / 100 == 1 ? "cento" : Unita[numero / 100] + "cento") + (numero % 100 > 0 ? ConvertiNumeroInLettere(numero % 100) : "");

            if (numero < 1000000)

                return (numero / 1000 == 1 ? "mille" : ConvertiNumeroInLettere(numero / 1000) + "mila") + (numero % 1000 > 0 ? ConvertiNumeroInLettere(numero % 1000) : "");

            if (numero < 1000000000)

                return (numero / 1000000 == 1 ? "un milione" : ConvertiNumeroInLettere(numero / 1000000) + " milioni") + (numero % 1000000 > 0 ? ConvertiNumeroInLettere(numero % 1000000) : "");



            return (numero / 1000000000 == 1 ? "un miliardo" : ConvertiNumeroInLettere(numero / 1000000000) + " miliardi") + (numero % 1000000000 > 0 ? ConvertiNumeroInLettere(numero % 1000000000) : "");

        }



        public   string ConvertNumberToWords(decimal number)

        {

            if (number == 0)

                return "Zero Dollars";



            int intPart = (int)number;



            int decimalPart = (int)((number - intPart) * 100);



            string words = "";



            int thousandCounter = 0;



            while (intPart > 0)

            {

                if (intPart % 1000 != 0)

                {

                    words = ConvertHundreds(intPart % 1000) + thousands[thousandCounter] + " " + words;

                }

                intPart /= 1000;

                thousandCounter++;

            }



            words = words.Trim();





            if (decimalPart > 0)

            {

                words += " and " + ConvertHundreds(decimalPart) + " Cents";

            }



            words += " Dollars";

            return words;



        }

        private   string ConvertHundreds(int number)

        {

            string result = "";

            if (number >= 100)

            {

                result += ones[number / 100] + " Hundred ";

                number %= 100;

            }



            if (number >= 20)

            {

                result += tens[number / 10] + " ";

                number %= 10;

            }





            if (number > 0)

            {

                result += ones[number] + " ";

            }



            return result.Trim();



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

        private void FrmConvertitori_Load(object sender, EventArgs e)
        {

        }

        private void BtnConvertiNumeroTesto_Click(object sender, EventArgs e)
        {
            try
            {
                txtNumeroTestoRisultato.Text = ConvertiEuroInLettere(nudNumeroTesto.Value, true);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void BtnDollariTesto_Click(object sender, EventArgs e)
        {
            TxtImportoDollariRisultato.Text = ConvertNumberToWords(nudDollari.Value);
        }
    }
}
