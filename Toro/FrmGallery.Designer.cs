namespace Toro
{
    partial class FrmGallery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pcbGalleria = new PictureBox();
            nudSecondi = new NumericUpDown();
            BtnTrovaCartella = new Button();
            TxtPercorsoImmagini = new TextBox();
            label3 = new Label();
            BtnAvvia = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pcbGalleria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSecondi).BeginInit();
            SuspendLayout();
            // 
            // pcbGalleria
            // 
            pcbGalleria.Location = new Point(100, 34);
            pcbGalleria.Name = "pcbGalleria";
            pcbGalleria.Size = new Size(1022, 688);
            pcbGalleria.TabIndex = 0;
            pcbGalleria.TabStop = false;
            // 
            // nudSecondi
            // 
            nudSecondi.Increment = new decimal(new int[] { 1000, 0, 0, 0 });
            nudSecondi.Location = new Point(100, 743);
            nudSecondi.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudSecondi.Minimum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudSecondi.Name = "nudSecondi";
            nudSecondi.Size = new Size(120, 23);
            nudSecondi.TabIndex = 1;
            nudSecondi.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // BtnTrovaCartella
            // 
            BtnTrovaCartella.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnTrovaCartella.Location = new Point(804, 742);
            BtnTrovaCartella.Name = "BtnTrovaCartella";
            BtnTrovaCartella.Size = new Size(30, 29);
            BtnTrovaCartella.TabIndex = 21;
            BtnTrovaCartella.Text = "...";
            BtnTrovaCartella.TextAlign = ContentAlignment.TopLeft;
            BtnTrovaCartella.UseVisualStyleBackColor = true;
            BtnTrovaCartella.Click += BtnTrovaCartella_Click;
            // 
            // TxtPercorsoImmagini
            // 
            TxtPercorsoImmagini.Location = new Point(243, 742);
            TxtPercorsoImmagini.Name = "TxtPercorsoImmagini";
            TxtPercorsoImmagini.ReadOnly = true;
            TxtPercorsoImmagini.Size = new Size(555, 23);
            TxtPercorsoImmagini.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(243, 724);
            label3.Name = "label3";
            label3.Size = new Size(204, 15);
            label3.TabIndex = 19;
            label3.Text = "Percorso della cartella delle immagini";
            // 
            // BtnAvvia
            // 
            BtnAvvia.Location = new Point(102, 784);
            BtnAvvia.Name = "BtnAvvia";
            BtnAvvia.Size = new Size(75, 23);
            BtnAvvia.TabIndex = 22;
            BtnAvvia.Text = "Avvia";
            BtnAvvia.UseVisualStyleBackColor = true;
            BtnAvvia.Click += BtnAvvia_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // FrmGallery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1301, 812);
            Controls.Add(BtnAvvia);
            Controls.Add(BtnTrovaCartella);
            Controls.Add(TxtPercorsoImmagini);
            Controls.Add(label3);
            Controls.Add(nudSecondi);
            Controls.Add(pcbGalleria);
            Name = "FrmGallery";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FrmGallery_Load;
            ((System.ComponentModel.ISupportInitialize)pcbGalleria).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSecondi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbGalleria;
        private NumericUpDown nudSecondi;
        private Button BtnTrovaCartella;
        private TextBox TxtPercorsoImmagini;
        private Label label3;
        private Button BtnAvvia;
        private System.Windows.Forms.Timer timer1;
    }
}