namespace Toro
{
    partial class FrmImmaginiMS
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
            tbcImmaginiMS = new TabControl();
            tbpImmagineBing = new TabPage();
            tbpImmaginiBlocco = new TabPage();
            BtnChiudi = new Button();
            tbcImmaginiMS.SuspendLayout();
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
            label1.Text = "Toro- Strumenti e funzionalità per Windows - Gestione  Immagini  Microsoft";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // tbcImmaginiMS
            // 
            tbcImmaginiMS.Controls.Add(tbpImmagineBing);
            tbcImmaginiMS.Controls.Add(tbpImmaginiBlocco);
            tbcImmaginiMS.Dock = DockStyle.Top;
            tbcImmaginiMS.Location = new Point(0, 22);
            tbcImmaginiMS.Name = "tbcImmaginiMS";
            tbcImmaginiMS.SelectedIndex = 0;
            tbcImmaginiMS.Size = new Size(800, 305);
            tbcImmaginiMS.TabIndex = 2;
            // 
            // tbpImmagineBing
            // 
            tbpImmagineBing.Location = new Point(4, 24);
            tbpImmagineBing.Name = "tbpImmagineBing";
            tbpImmagineBing.Padding = new Padding(3);
            tbpImmagineBing.Size = new Size(792, 277);
            tbpImmagineBing.TabIndex = 0;
            tbpImmagineBing.Text = "Immagini da Bing";
            tbpImmagineBing.UseVisualStyleBackColor = true;
            // 
            // tbpImmaginiBlocco
            // 
            tbpImmaginiBlocco.Location = new Point(4, 24);
            tbpImmaginiBlocco.Name = "tbpImmaginiBlocco";
            tbpImmaginiBlocco.Padding = new Padding(3);
            tbpImmaginiBlocco.Size = new Size(792, 277);
            tbpImmaginiBlocco.TabIndex = 1;
            tbpImmaginiBlocco.Text = "Immagini di blocco di Windows";
            tbpImmaginiBlocco.UseVisualStyleBackColor = true;
            // 
            // BtnChiudi
            // 
            BtnChiudi.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnChiudi.Image = Properties.Resources.chiudi_16;
            BtnChiudi.ImageAlign = ContentAlignment.MiddleRight;
            BtnChiudi.Location = new Point(713, 352);
            BtnChiudi.Name = "BtnChiudi";
            BtnChiudi.Size = new Size(75, 23);
            BtnChiudi.TabIndex = 6;
            BtnChiudi.Text = "Chiudi";
            BtnChiudi.UseVisualStyleBackColor = true;
            // 
            // FrmImmaginiMS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnChiudi);
            Controls.Add(tbcImmaginiMS);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmImmaginiMS";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Toro - Strumenti e funzionalità per Windows";
            tbcImmaginiMS.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TabControl tbcImmaginiMS;
        private TabPage tbpImmagineBing;
        private TabPage tbpImmaginiBlocco;
        private Button BtnChiudi;
    }
}