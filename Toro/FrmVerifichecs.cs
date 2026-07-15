using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtIBan.Text, @"^IT\d{2}[ ][a-zA-Z]\d{3}[ ]\d{4}[ ]\d{4}[ ]\d{4}[ ]\d{4}[ ]\d{3}|IT\d{2}[a-zA-Z]\d{22}"))
            {
                Utility.MessaggioInfo("IBAN valido");
            }
            else
            {
                Utility.MessaggioInfo("IBAN non valido");
            }
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


        public static double TestWriteSpeed(string driveLetter)
        {
            string fileName = Path.Combine(driveLetter, "filetestVelocita.bin");

            // 100 MB
            const int fileSize = 100 * 1024 * 1024;
            byte[] buffer = new byte[1024 * 1024]; // 1 MB

            new Random().NextBytes(buffer);

            Stopwatch sw = Stopwatch.StartNew();

            using (FileStream fs = new FileStream(
                fileName,
                FileMode.Create,
                FileAccess.Write,
                FileShare.None,
                buffer.Length,
                FileOptions.WriteThrough))
            {
                int written = 0;

                while (written < fileSize)
                {
                    fs.Write(buffer, 0, buffer.Length);
                    written += buffer.Length;
                }

                fs.Flush(true);
            }

            sw.Stop();

            double seconds = sw.Elapsed.TotalSeconds;
            double mb = fileSize / 1024.0 / 1024.0;

            return mb / seconds;
        }



        public static double TestReadSpeed(string driveLetter)
        {
            string fileName = Path.Combine(driveLetter, "filetestVelocita.bin");

            byte[] buffer = new byte[1024 * 1024];

            Stopwatch sw = Stopwatch.StartNew();

            using (FileStream fs = new FileStream(
                fileName,
                FileMode.Open,
                FileAccess.Read))
            {
                while (fs.Read(buffer, 0, buffer.Length) > 0)
                {
                }
            }

            sw.Stop();

            double mb = new FileInfo(fileName).Length / 1024.0 / 1024.0;

            return mb / sw.Elapsed.TotalSeconds;
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


        private void TxtPalindromo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Consente solo lettere e carattere di controllo (es. backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmVerifichecs_Load(object sender, EventArgs e)
        {
            //Caricare unità nella combo
            try
            {
                foreach (DriveInfo InfoUnita in DriveInfo.GetDrives())
                {
                    if (InfoUnita.DriveType == DriveType.Removable && InfoUnita.IsReady)
                    {
                        CmbUnitaUSB.Items.Add(InfoUnita.Name);
                         
                    }
                }
                if (CmbUnitaUSB.Items.Count>0)
                {
                    CmbUnitaUSB.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }



        }

        private void BtnVerificaUSB_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (CmbUnitaUSB.Text.Trim() != "")
                {
                    double write = TestWriteSpeed(@CmbUnitaUSB.Text.Trim());
                    TxtVelocitaScrittura.Text = $"Scrittura: {write:F2} MB/s";
                    double read = TestReadSpeed(@CmbUnitaUSB.Text.Trim());
                    txtVelocitaLettura.Text = $"Lettura:  {read:F2} MB/s";
                    if (Path.Exists(@CmbUnitaUSB.Text.Trim() + "filetestVelocita.bin" ) )
                    {
                        File.Delete(@CmbUnitaUSB.Text.Trim() + "filetestVelocita.bin");
                    }

                }
    
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
    }
}
