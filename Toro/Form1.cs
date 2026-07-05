namespace Toro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mniChiudi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void convertitoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConvertitori convertitori = new FrmConvertitori();
            convertitori.ShowDialog();

        }

        private void mniVerifiche_Click(object sender, EventArgs e)
        {
            FrmVerifichecs verifiche = new FrmVerifichecs();
            verifiche.ShowDialog();
        }

        private void informazioniPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInformazioniPC infoPc = new FrmInformazioniPC();
            infoPc.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO
            //Icone
            //Finestra informativa
            //Informazioni del sistema operativo con system.Management  


        }
    }
}
