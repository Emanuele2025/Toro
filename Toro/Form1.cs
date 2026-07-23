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
            Cursor.Current = Cursors.WaitCursor;
            FrmInformazioniPC infoPc = new FrmInformazioniPC();
            infoPc.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO
            //Icone
            
            //Logo del toro per il programma
            //FARE:
            //Form per immagini di Microsoft bing, blocco schermo e contenuti
            //Vedere se salva impostazioni
            //Titolo per le varie finestre, con la costante 
            //Trovare anche icona del programma
            
            //Funzione generale per trasmoare i byte in gb e così via

        }

        private void mniInformazioni_Click(object sender, EventArgs e)
        {
            FrmInfoToro info = new FrmInfoToro();
            info.ShowDialog();
        }
    }
}
