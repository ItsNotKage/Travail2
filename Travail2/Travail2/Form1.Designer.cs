
namespace Travail2
{
    partial class JeuFuturama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JeuFuturama));
            this.BtnCommencer = new System.Windows.Forms.Button();
            this.BtnQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbParametre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCommencer
            // 
            this.BtnCommencer.Location = new System.Drawing.Point(105, 192);
            this.BtnCommencer.Name = "BtnCommencer";
            this.BtnCommencer.Size = new System.Drawing.Size(113, 56);
            this.BtnCommencer.TabIndex = 0;
            this.BtnCommencer.Text = "Commencer";
            this.BtnCommencer.UseVisualStyleBackColor = true;
            this.BtnCommencer.Click += new System.EventHandler(this.BtnCommencer_Click);
            // 
            // BtnQuitter
            // 
            this.BtnQuitter.Location = new System.Drawing.Point(105, 346);
            this.BtnQuitter.Name = "BtnQuitter";
            this.BtnQuitter.Size = new System.Drawing.Size(113, 56);
            this.BtnQuitter.TabIndex = 1;
            this.BtnQuitter.Text = "Quitter";
            this.BtnQuitter.UseVisualStyleBackColor = true;
            this.BtnQuitter.Click += new System.EventHandler(this.BtnQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jeu Futurama";
            // 
            // cmbParametre
            // 
            this.cmbParametre.FormattingEnabled = true;
            this.cmbParametre.Location = new System.Drawing.Point(106, 297);
            this.cmbParametre.Name = "cmbParametre";
            this.cmbParametre.Size = new System.Drawing.Size(113, 21);
            this.cmbParametre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choisir Difficulté";
            // 
            // PbLogo
            // 
            this.PbLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo.Image")));
            this.PbLogo.ImageLocation = "";
            this.PbLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("PbLogo.InitialImage")));
            this.PbLogo.Location = new System.Drawing.Point(105, 103);
            this.PbLogo.Name = "PbLogo";
            this.PbLogo.Size = new System.Drawing.Size(114, 60);
            this.PbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbLogo.TabIndex = 5;
            this.PbLogo.TabStop = false;
            // 
            // JeuFuturama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 450);
            this.Controls.Add(this.PbLogo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbParametre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnQuitter);
            this.Controls.Add(this.BtnCommencer);
            this.Name = "JeuFuturama";
            this.Text = "Futurama game";
            this.Load += new System.EventHandler(this.JeuFuturama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCommencer;
        private System.Windows.Forms.Button BtnQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbParametre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox PbLogo;
    }
}

