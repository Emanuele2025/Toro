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
    public partial class FrmInfoToro : Form
    {
        public FrmInfoToro()
        {
            InitializeComponent();
        }

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnlEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "mailto:emanuelemattei@tutanota.com",
                UseShellExecute = true
            };

            try
            {
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Impossibile aprire il programma di posta elettronica: " + ex.Message);

            }
        }

        private void LnkIcon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "https://icons8.it/",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Impossibile aprire il sito: " + ex.Message);

            }
        }

        private void lnkduckduckgo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "https://duck.ai/",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                Utility.MessaggioErrore("Impossibile aprire il sito: " + ex.Message);

            }
        }

        private void FrmInfoToro_Load(object sender, EventArgs e)
        {
            // https://icons8.it/icons/set/chiudi
            //<a target="_blank" href="https://icons8.com/icon/13903/close-window">Chiudi La Finestra</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>

        }
    }
}
