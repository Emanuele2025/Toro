using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Toro
{
    public partial class FrmInformazioniPC : Form
    {
        public FrmInformazioniPC()
        {
            InitializeComponent();
        }

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInformazioniPC_Load(object sender, EventArgs e)
        {
            Video();
            TxtNomePC.Text = Environment.MachineName;
            txtNomeUtente.Text = Environment.UserName;
            VarieInformazioni();
        }





        #region Funzioni

        /// <summary>
        /// Fornisce informazioni sul video
        /// </summary>
        private void Video()
        {

            try
            {
                var risoluzione = Screen.PrimaryScreen?.Bounds;


                txtRisoluzioneVideo.Text = risoluzione?.Width + "x" + risoluzione?.Height;
                var risoluzioneSenzaBarra = Screen.PrimaryScreen?.WorkingArea;

                TxtRisoluzioneSenzaBarra.Text = risoluzioneSenzaBarra?.Width + "x" + risoluzioneSenzaBarra?.Height;

            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }



        }


        /// <summary>
        /// Fornisce informazioni di vario genere
        /// </summary>
        private void VarieInformazioni()
        {

            try
            {
                PowerStatus statoBatteria = SystemInformation.PowerStatus;
                float percentualeStatoBatteria = statoBatteria.BatteryLifePercent * 100;
                TxtLivelloBatteria.Text = percentualeStatoBatteria + "%";


                TxtCollegata.Text = statoBatteria.PowerLineStatus == PowerLineStatus.Online ? "Sì" : "No";
                DriveInfo[] drives = DriveInfo.GetDrives();

                foreach (DriveInfo drive in drives)
                {
                    cmbUnita.Items.Add(drive.Name);

                }
                if (cmbUnita.Items.Count > 0)
                    cmbUnita.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore(ex.Message);
            }




        }




        /// <summary>
        /// Funzione che permette di sapere le dimensioni in byte e le converte in un formato leggibile
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns>Restiutisce il formato</returns>
        private string FormatoUnita(long bytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = bytes;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len /= 1024;
            }
            return $"{len:0.##} {sizes[order]}";
        }



















        #endregion















        private void cmbUnita_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DriveInfo unita = new DriveInfo(driveName: cmbUnita?.SelectedItem?.ToString());
                if (unita.IsReady)
                {
                    long totalSize = unita.TotalSize;
                    long freeSpace = unita.AvailableFreeSpace;
                    long usedSpace = totalSize - freeSpace;
                    double usedPercentage = (totalSize > 0)
                        ? (usedSpace / (double)totalSize) * 100
                        : 0;

                    TxtSpazioTotale.Text = FormatoUnita(totalSize);
                    TxtSpazioLibero.Text = FormatoUnita(freeSpace);
                    TxtOccupato.Text = $"  Spazio usato: {FormatoUnita(usedSpace)} ({usedPercentage:F2}%)";
                    txtTipo.Text = unita.DriveType.ToString();
                    TxtFileSystem.Text = unita.DriveFormat;
                    TxtEtichetta.Text = unita.VolumeLabel;
                    TxtUtilizzabile.Text = "Si";
                    
                }
                else
                {
                    TxtUtilizzabile.Text = "No";
                }






            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }
    }
}
