namespace BuscaUSC.Views
{
    partial class frmBlocoH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBlocoH));
            pnlTop = new Panel();
            pictureBox3 = new PictureBox();
            imgLogo = new PictureBox();
            lblBlocosTitle = new Label();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.WhiteSmoke;
            pnlTop.Controls.Add(pictureBox3);
            pnlTop.Controls.Add(imgLogo);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(800, 66);
            pnlTop.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 18);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // imgLogo
            // 
            imgLogo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imgLogo.Image = (Image)resources.GetObject("imgLogo.Image");
            imgLogo.Location = new Point(648, 8);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(140, 50);
            imgLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            imgLogo.TabIndex = 11;
            imgLogo.TabStop = false;
            // 
            // lblBlocosTitle
            // 
            lblBlocosTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBlocosTitle.AutoSize = true;
            lblBlocosTitle.BackColor = SystemColors.Window;
            lblBlocosTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBlocosTitle.Location = new Point(320, 69);
            lblBlocosTitle.Name = "lblBlocosTitle";
            lblBlocosTitle.Size = new Size(132, 37);
            lblBlocosTitle.TabIndex = 4;
            lblBlocosTitle.Text = "BLOCO H";
            // 
            // frmBlocoH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lblBlocosTitle);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmBlocoH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmBlocoH";
            pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTop;
        private PictureBox pictureBox3;
        private PictureBox imgLogo;
        private Label lblBlocosTitle;
    }
}