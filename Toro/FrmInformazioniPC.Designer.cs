namespace Toro
{
    partial class FrmInformazioniPC
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            TxtRisoluzioneSenzaBarra = new TextBox();
            label3 = new Label();
            txtRisoluzioneVideo = new TextBox();
            label2 = new Label();
            BtnChiudi = new Button();
            groupBox2 = new GroupBox();
            txtNomeUtente = new TextBox();
            label4 = new Label();
            TxtNomePC = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.Highlight;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 22);
            label1.TabIndex = 3;
            label1.Text = "Toro- Informazioni sul pc";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtRisoluzioneSenzaBarra);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtRisoluzioneVideo);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(6, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Video";
            // 
            // TxtRisoluzioneSenzaBarra
            // 
            TxtRisoluzioneSenzaBarra.Location = new Point(175, 50);
            TxtRisoluzioneSenzaBarra.Name = "TxtRisoluzioneSenzaBarra";
            TxtRisoluzioneSenzaBarra.ReadOnly = true;
            TxtRisoluzioneSenzaBarra.Size = new Size(177, 23);
            TxtRisoluzioneSenzaBarra.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 50);
            label3.Name = "label3";
            label3.Size = new Size(165, 15);
            label3.TabIndex = 2;
            label3.Text = "Risoluzione Video senza barra:";
            // 
            // txtRisoluzioneVideo
            // 
            txtRisoluzioneVideo.Location = new Point(175, 21);
            txtRisoluzioneVideo.Name = "txtRisoluzioneVideo";
            txtRisoluzioneVideo.ReadOnly = true;
            txtRisoluzioneVideo.Size = new Size(177, 23);
            txtRisoluzioneVideo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 21);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 0;
            label2.Text = "Risoluzione Video:";
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Location = new Point(704, 415);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 5;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtNomeUtente);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(TxtNomePC);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(388, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(364, 100);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sistema";
            // 
            // txtNomeUtente
            // 
            txtNomeUtente.Location = new Point(175, 50);
            txtNomeUtente.Name = "txtNomeUtente";
            txtNomeUtente.ReadOnly = true;
            txtNomeUtente.Size = new Size(177, 23);
            txtNomeUtente.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 50);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 2;
            label4.Text = "Nome Utente:";
            // 
            // TxtNomePC
            // 
            TxtNomePC.Location = new Point(175, 21);
            TxtNomePC.Name = "TxtNomePC";
            TxtNomePC.ReadOnly = true;
            TxtNomePC.Size = new Size(177, 23);
            TxtNomePC.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 21);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 0;
            label5.Text = "Nome PC:";
            // 
            // FrmInformazioniPC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(BtnChiudi);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInformazioniPC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Toro - Informazioni PC";
            Load += FrmInformazioniPC_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtRisoluzioneVideo;
        private Label label2;
        private Button BtnChiudi;
        private TextBox TxtRisoluzioneSenzaBarra;
        private Label label3;
        private GroupBox groupBox2;
        private TextBox txtNomeUtente;
        private Label label4;
        private TextBox TxtNomePC;
        private Label label5;
    }
}