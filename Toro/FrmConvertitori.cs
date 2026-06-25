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

        private void BtnChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConverti_Click(object sender, EventArgs e)
        {
            try
            {

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
    }
}
