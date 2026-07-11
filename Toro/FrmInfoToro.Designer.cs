namespace Toro
{
    partial class FrmInfoToro
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
            BtnChiudi = new Button();
            pctLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctLogo).BeginInit();
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
            label1.TabIndex = 1;
            label1.Text = "Informazioni sul programma gratuito Toro - Strumenti per Windows";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Location = new Point(689, 415);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 6;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            BtnChiudi.Click += BtnChiudi_Click;
            // 
            // pctLogo
            // 
            pctLogo.Image = Properties.Resources.toro;
            pctLogo.Location = new Point(0, 23);
            pctLogo.Name = "pctLogo";
            pctLogo.Size = new Size(279, 220);
            pctLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pctLogo.TabIndex = 7;
            pctLogo.TabStop = false;
            // 
            // FrmInfoToro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pctLogo);
            Controls.Add(BtnChiudi);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInfoToro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Informazoini sul programma Toro";
            ((System.ComponentModel.ISupportInitialize)pctLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button BtnChiudi;
        private PictureBox pctLogo;
    }
}