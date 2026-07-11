namespace Toro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            mnsMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            mniChiudi = new ToolStripMenuItem();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            informazioniPCToolStripMenuItem = new ToolStripMenuItem();
            funzionalitàToolStripMenuItem = new ToolStripMenuItem();
            convertitoriToolStripMenuItem = new ToolStripMenuItem();
            mniVerifiche = new ToolStripMenuItem();
            mnsMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Highlight;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 24);
            label1.Name = "label1";
            label1.Size = new Size(800, 22);
            label1.TabIndex = 0;
            label1.Text = "Toro- Strumenti per Windows - Gestione Hardware ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // mnsMenu
            // 
            mnsMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, sistemaToolStripMenuItem, funzionalitàToolStripMenuItem });
            mnsMenu.Location = new Point(0, 0);
            mnsMenu.Name = "mnsMenu";
            mnsMenu.Size = new Size(800, 24);
            mnsMenu.TabIndex = 1;
            mnsMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mniChiudi });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // mniChiudi
            // 
            mniChiudi.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mniChiudi.Image = Properties.Resources.chiudi_16;
            mniChiudi.Name = "mniChiudi";
            mniChiudi.Size = new Size(180, 22);
            mniChiudi.Text = "Chiudi";
            mniChiudi.Click += mniChiudi_Click;
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informazioniPCToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(60, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // informazioniPCToolStripMenuItem
            // 
            informazioniPCToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            informazioniPCToolStripMenuItem.Name = "informazioniPCToolStripMenuItem";
            informazioniPCToolStripMenuItem.Size = new Size(175, 22);
            informazioniPCToolStripMenuItem.Text = "Informazioni PC...";
            informazioniPCToolStripMenuItem.Click += informazioniPCToolStripMenuItem_Click;
            // 
            // funzionalitàToolStripMenuItem
            // 
            funzionalitàToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { convertitoriToolStripMenuItem, mniVerifiche });
            funzionalitàToolStripMenuItem.Name = "funzionalitàToolStripMenuItem";
            funzionalitàToolStripMenuItem.Size = new Size(83, 20);
            funzionalitàToolStripMenuItem.Text = "Funzionalità";
            // 
            // convertitoriToolStripMenuItem
            // 
            convertitoriToolStripMenuItem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            convertitoriToolStripMenuItem.Name = "convertitoriToolStripMenuItem";
            convertitoriToolStripMenuItem.Size = new Size(152, 22);
            convertitoriToolStripMenuItem.Text = "Convertitori...";
            convertitoriToolStripMenuItem.ToolTipText = "Permettono di convertire numeri in testo, numeri in valori rumani ed altro";
            convertitoriToolStripMenuItem.Click += convertitoriToolStripMenuItem_Click;
            // 
            // mniVerifiche
            // 
            mniVerifiche.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mniVerifiche.Name = "mniVerifiche";
            mniVerifiche.Size = new Size(152, 22);
            mniVerifiche.Text = "Verifiche...";
            mniVerifiche.Click += mniVerifiche_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(mnsMenu);
            MainMenuStrip = mnsMenu;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tools - Strumento per Windows e varie funzionalità";
            Load += Form1_Load;
            mnsMenu.ResumeLayout(false);
            mnsMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip mnsMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem mniChiudi;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem funzionalitàToolStripMenuItem;
        private ToolStripMenuItem informazioniPCToolStripMenuItem;
        private ToolStripMenuItem convertitoriToolStripMenuItem;
        private ToolStripMenuItem mniVerifiche;
    }
}
