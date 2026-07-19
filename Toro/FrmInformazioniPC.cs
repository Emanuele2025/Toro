using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//Per la gestione hardware
using System.Management;
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
            GetInfoRAM();
            GetInfoSchedaGrafica();





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




        /// <summary>
        /// Funzione che rileva le informazioni della scheda grafica
        /// </summary>
        private void GetInfoRAM()
        {

            try
            {
                var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
                var moduli = searcher.Get();

                long totaleRam = 0;
                int moduliInstallati = 0;


                string tipoRam = "";
                string Produttore = "";
                string SlotRam = "";
                foreach (ManagementObject module in moduli)
                {
                    moduliInstallati++;
                    long capacita = Convert.ToInt64(module["Capacity"]);
                    int smbiosType = Convert.ToInt32(module["SMBIOSMemoryType"]);

                    totaleRam += capacita;


                    SlotRam = module["DeviceLocator"]?.ToString();

                    tipoRam = GetTipoRAM(smbiosType);
                  
                    Produttore = module["Manufacturer"]?.ToString();

                }


                var arraySearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemoryArray");
                var arrays = arraySearcher.Get();

                int totaleSlots = 0;
                foreach (ManagementObject arr in arrays)
                {
                    totaleSlots += Convert.ToInt32(arr["MemoryDevices"]);
                }

               
                TxtSlotTotali.Text = totaleSlots.ToString();
                TxtSlotOccupati.Text = moduliInstallati.ToString();
                TxtSlotLiberi.Text = (totaleSlots - moduliInstallati).ToString();
                TxtRamTotale.Text = (totaleRam / (1024 * 1024 * 1024)).ToString() + " GB";
                TxtVelocita.Text = moduli.Count > 0 ? moduli.Cast<ManagementObject>().First()["Speed"]?.ToString() + " MHz" : "N/A";
                txtTipoRam.Text = tipoRam;
                TxtProduttore.Text = Produttore;
                TxtSlotRam.Text = SlotRam;





            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore: " + ex.Message);
                 
            }




        }


        private void GetInfoSchedaGrafica()
        {

            try
            {
                var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");

                foreach (ManagementObject obj in searcher.Get())
                {

                    TxtNomeSchedaGrafica.Text = $"  Scheda grafica: {obj["Name"]}";
                    TxtCapacitaSchedaGrafica.Text = $"  Memoria video: {FormatoUnita(Convert.ToInt64(obj["AdapterRAM"]))}";
                    TxtDriver.Text += $"  Driver: {obj["DriverVersion"]}";
                    TxtProduttoreSchedaGrafica.Text = $"  Produttore: {obj["AdapterCompatibility"]}";
                }
            }
            catch (ManagementException exME)
            { Utility.MessaggioErrore("Errore: " + exME.Message);
            
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore: " + ex.Message);
            }







        }







        string GetTipoRAM(int type)
        {
            return type switch
            {
                20 => "DDR",
                21 => "DDR2",
                24 => "DDR3",
                26 => "DDR4",
                34 => "DDR5",
                _ => $"Sconosciuto (codice {type})"
            };
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

                    TxtSpazioTotale.Text = "";
                    TxtSpazioLibero.Text = "";
                    TxtOccupato.Text = "";
                    txtTipo.Text = "";
                    TxtFileSystem.Text = "";
                    TxtEtichetta.Text = "";
                }






            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Errore: " + ex.Message);
            }
        }
    }
}
