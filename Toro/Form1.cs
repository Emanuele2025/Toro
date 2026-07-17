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
             
            //Informazioni del sistema operativo con system.Management  
            //Logo del toro
            //Icone https://icons8.com/icons 
             
            
            //Funzione generale per trasmoare i byte in gb e così via

        }

        private void mniInformazioni_Click(object sender, EventArgs e)
        {
            FrmInfoToro info = new FrmInfoToro();
            info.ShowDialog();
        }
    }
}
