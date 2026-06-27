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
            txtRisoluzioneVideo = new TextBox();
            label2 = new Label();
            BtnChiudi = new Button();
            TxtRisoluzioneSenzaBarra = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
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
            // FrmInformazioniPC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}