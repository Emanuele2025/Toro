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
            Cursor.Current = Cursors.WaitCursor;
            FrmConvertitori convertitori = new FrmConvertitori();
            convertitori.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void mniVerifiche_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            FrmVerifichecs verifiche = new FrmVerifichecs();
            verifiche.ShowDialog();
            Cursor.Current = Cursors.Default;
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
            //Cursor per le voci menu
            //Logo del toro per il programma
            //FARE:
            //Form per immagini di Microsoft bing, blocco schermo e contenuti
            //Vedere se salva impostazioni
            //Titolo per le varie finestre, con la costante 
            //Trovare anche icona del programma

            //Funzione generale per trasmoare i byte in gb e così via
            //Sito di icone gratuie https://freeicon.com/it/ vedere se utilizzarle


        }

        private void mniInformazioni_Click(object sender, EventArgs e)
        {
            FrmInfoToro info = new FrmInfoToro();
            info.ShowDialog();
        }

        private void gestioneFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO FARE:
            
            //Valutare se estrapolare file da un file p7m
            //Steganografia, mettere un file all'interno di un'immagine png
            //Mettere anche funzionalità vcf, dei contatti
            FrmFile fileForm = new FrmFile();
            fileForm.ShowDialog();


        }
    }
}
