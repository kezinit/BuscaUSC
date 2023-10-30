namespace BuscaUSC
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            pnlTop = new Panel();
            imgClaro = new PictureBox();
            imgEscuro = new PictureBox();
            imgLogo = new PictureBox();
            imgMinimize = new PictureBox();
            imgMaximize = new PictureBox();
            imgSair = new PictureBox();
            pnlMenu = new Panel();
            pnlMapa = new Panel();
            lblMapa = new Label();
            imgMapa = new PictureBox();
            pnlMenuSair = new Panel();
            lblMenuSair = new Label();
            imgMenuSair = new PictureBox();
            pnlBlocos = new Panel();
            lblBlocos = new Label();
            imgBlocos = new PictureBox();
            pnlMenuLateral = new Panel();
            lblMenu = new Label();
            imgMenu = new PictureBox();
            TelaBlocos = new Panel();
            button7 = new Button();
            label2 = new Label();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            vScrollBar1 = new VScrollBar();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            lblBlocosTitle = new Label();
            button1 = new Button();
            TelaMapa = new Panel();
            vScrollBar2 = new VScrollBar();
            pictureBox1 = new PictureBox();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgClaro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgEscuro).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgMinimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgMaximize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgSair).BeginInit();
            pnlMenu.SuspendLayout();
            pnlMapa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgMapa).BeginInit();
            pnlMenuSair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgMenuSair).BeginInit();
            pnlBlocos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgBlocos).BeginInit();
            pnlMenuLateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgMenu).BeginInit();
            TelaBlocos.SuspendLayout();
            TelaMapa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.WhiteSmoke;
            pnlTop.Controls.Add(imgClaro);
            pnlTop.Controls.Add(imgEscuro);
            pnlTop.Controls.Add(imgLogo);
            pnlTop.Controls.Add(imgMinimize);
            pnlTop.Controls.Add(imgMaximize);
            pnlTop.Controls.Add(imgSair);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1296, 66);
            pnlTop.TabIndex = 0;
            pnlTop.MouseDown += pnlTop_MouseDown;
            pnlTop.MouseMove += pnlTop_MouseMove;
            // 
            // imgClaro
            // 
            imgClaro.Image = (Image)resources.GetObject("imgClaro.Image");
            imgClaro.Location = new Point(157, 17);
            imgClaro.Name = "imgClaro";
            imgClaro.Size = new Size(32, 32);
            imgClaro.SizeMode = PictureBoxSizeMode.CenterImage;
            imgClaro.TabIndex = 7;
            imgClaro.TabStop = false;
            imgClaro.Visible = false;
            imgClaro.Click += imgClaro_Click;
            // 
            // imgEscuro
            // 
            imgEscuro.Image = (Image)resources.GetObject("imgEscuro.Image");
            imgEscuro.Location = new Point(157, 17);
            imgEscuro.Name = "imgEscuro";
            imgEscuro.Size = new Size(32, 32);
            imgEscuro.SizeMode = PictureBoxSizeMode.CenterImage;
            imgEscuro.TabIndex = 6;
            imgEscuro.TabStop = false;
            imgEscuro.Click += imgEscuro_Click;
            // 
            // imgLogo
            // 
            imgLogo.Image = (Image)resources.GetObject("imgLogo.Image");
            imgLogo.Location = new Point(11, 8);
            imgLogo.Name = "imgLogo";
            imgLogo.Size = new Size(140, 50);
            imgLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            imgLogo.TabIndex = 5;
            imgLogo.TabStop = false;
            // 
            // imgMinimize
            // 
            imgMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imgMinimize.Image = (Image)resources.GetObject("imgMinimize.Image");
            imgMinimize.Location = new Point(1176, 17);
            imgMinimize.Name = "imgMinimize";
            imgMinimize.Size = new Size(32, 32);
            imgMinimize.SizeMode = PictureBoxSizeMode.CenterImage;
            imgMinimize.TabIndex = 2;
            imgMinimize.TabStop = false;
            imgMinimize.Click += imgMinimize_Click;
            imgMinimize.MouseEnter += imgMinimize_MouseEnter;
            imgMinimize.MouseLeave += imgMinimize_MouseLeave;
            // 
            // imgMaximize
            // 
            imgMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imgMaximize.Image = (Image)resources.GetObject("imgMaximize.Image");
            imgMaximize.Location = new Point(1214, 17);
            imgMaximize.Name = "imgMaximize";
            imgMaximize.Size = new Size(32, 32);
            imgMaximize.SizeMode = PictureBoxSizeMode.CenterImage;
            imgMaximize.TabIndex = 1;
            imgMaximize.TabStop = false;
            imgMaximize.Click += imgMaximize_Click;
            imgMaximize.MouseEnter += imgMaximize_MouseEnter;
            imgMaximize.MouseLeave += imgMaximize_MouseLeave;
            // 
            // imgSair
            // 
            imgSair.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            imgSair.BackColor = Color.Transparent;
            imgSair.Image = (Image)resources.GetObject("imgSair.Image");
            imgSair.Location = new Point(1252, 17);
            imgSair.Name = "imgSair";
            imgSair.Size = new Size(32, 32);
            imgSair.SizeMode = PictureBoxSizeMode.CenterImage;
            imgSair.TabIndex = 0;
            imgSair.TabStop = false;
            imgSair.Click += imgSair_Click;
            imgSair.MouseEnter += imgSair_MouseEnter;
            imgSair.MouseLeave += imgSair_MouseLeave;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.WhiteSmoke;
            pnlMenu.Controls.Add(pnlMapa);
            pnlMenu.Controls.Add(pnlMenuSair);
            pnlMenu.Controls.Add(pnlBlocos);
            pnlMenu.Controls.Add(pnlMenuLateral);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 66);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.RightToLeft = RightToLeft.Yes;
            pnlMenu.Size = new Size(52, 732);
            pnlMenu.TabIndex = 1;
            pnlMenu.MouseEnter += pnlMenu_MouseEnter;
            pnlMenu.MouseLeave += pnlMenu_MouseLeave;
            // 
            // pnlMapa
            // 
            pnlMapa.Controls.Add(lblMapa);
            pnlMapa.Controls.Add(imgMapa);
            pnlMapa.Location = new Point(0, 199);
            pnlMapa.Name = "pnlMapa";
            pnlMapa.Size = new Size(192, 46);
            pnlMapa.TabIndex = 7;
            pnlMapa.Click += pnlMapa_Click;
            pnlMapa.Paint += pnlMapa_Paint;
            pnlMapa.MouseEnter += pnlMapa_MouseEnter;
            pnlMapa.MouseLeave += pnlMapa_MouseLeave;
            // 
            // lblMapa
            // 
            lblMapa.AutoSize = true;
            lblMapa.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblMapa.Location = new Point(59, 12);
            lblMapa.Name = "lblMapa";
            lblMapa.Size = new Size(53, 20);
            lblMapa.TabIndex = 5;
            lblMapa.Text = "MAPA";
            lblMapa.Click += lblMapa_Click;
            // 
            // imgMapa
            // 
            imgMapa.Image = (Image)resources.GetObject("imgMapa.Image");
            imgMapa.Location = new Point(10, 6);
            imgMapa.Name = "imgMapa";
            imgMapa.Size = new Size(32, 32);
            imgMapa.SizeMode = PictureBoxSizeMode.CenterImage;
            imgMapa.TabIndex = 4;
            imgMapa.TabStop = false;
            imgMapa.Click += imgMapa_Click;
            imgMapa.MouseEnter += imgMapa_MouseEnter;
            imgMapa.MouseLeave += imgMapa_MouseLeave;
            // 
            // pnlMenuSair
            // 
            pnlMenuSair.Controls.Add(lblMenuSair);
            pnlMenuSair.Controls.Add(imgMenuSair);
            pnlMenuSair.Dock = DockStyle.Bottom;
            pnlMenuSair.Location = new Point(0, 686);
            pnlMenuSair.Name = "pnlMenuSair";
            pnlMenuSair.Size = new Size(52, 46);
            pnlMenuSair.TabIndex = 7;
            pnlMenuSair.Click += pnlMenuSair_Click;
            pnlMenuSair.MouseEnter += pnlMenuSair_MouseEnter;
            pnlMenuSair.MouseLeave += pnlMenuSair_MouseLeave;
            // 
            // lblMenuSair
            // 
            lblMenuSair.AutoSize = true;
            lblMenuSair.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenuSair.Location = new Point(59, 12);
            lblMenuSair.Name = "lblMenuSair";
            lblMenuSair.Size = new Size(43, 20);
            lblMenuSair.TabIndex = 5;
            lblMenuSair.Text = "SAIR";
            lblMenuSair.Click += pnlMenuSair_Click;
            // 
            // imgMenuSair
            // 
            imgMenuSair.Image = (Image)resources.GetObject("imgMenuSair.Image");
            imgMenuSair.Location = new Point(10, 6);
            imgMenuSair.Name = "imgMenuSair";
            imgMenuSair.Size = new Size(32, 32);
            imgMenuSair.SizeMode = PictureBoxSizeMode.CenterImage;
            imgMenuSair.TabIndex = 4;
            imgMenuSair.TabStop = false;
            imgMenuSair.Click += pnlMenuSair_Click;
            imgMenuSair.MouseEnter += imgMenuSair_MouseEnter;
            imgMenuSair.MouseLeave += imgMenuSair_MouseLeave;
            // 
            // pnlBlocos
            // 
            pnlBlocos.Controls.Add(lblBlocos);
            pnlBlocos.Controls.Add(imgBlocos);
            pnlBlocos.Location = new Point(0, 140);
            pnlBlocos.Name = "pnlBlocos";
            pnlBlocos.Size = new Size(192, 46);
            pnlBlocos.TabIndex = 6;
            pnlBlocos.Click += pnlBlocos_Click;
            pnlBlocos.MouseEnter += pnlBlocos_MouseEnter;
            pnlBlocos.MouseLeave += pnlBlocos_MouseLeave;
            // 
            // lblBlocos
            // 
            lblBlocos.AutoSize = true;
            lblBlocos.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblBlocos.Location = new Point(59, 12);
            lblBlocos.Name = "lblBlocos";
            lblBlocos.Size = new Size(66, 20);
            lblBlocos.TabIndex = 5;
            lblBlocos.Text = "BLOCOS";
            lblBlocos.Click += lblBlocos_Click;
            // 
            // imgBlocos
            // 
            imgBlocos.Image = (Image)resources.GetObject("imgBlocos.Image");
            imgBlocos.Location = new Point(10, 6);
            imgBlocos.Name = "imgBlocos";
            imgBlocos.Size = new Size(32, 32);
            imgBlocos.SizeMode = PictureBoxSizeMode.CenterImage;
            imgBlocos.TabIndex = 4;
            imgBlocos.TabStop = false;
            imgBlocos.Click += imgBlocos_Click;
            imgBlocos.MouseEnter += imgBlocos_MouseEnter;
            imgBlocos.MouseLeave += imgBlocos_MouseLeave;
            // 
            // pnlMenuLateral
            // 
            pnlMenuLateral.Controls.Add(lblMenu);
            pnlMenuLateral.Controls.Add(imgMenu);
            pnlMenuLateral.Dock = DockStyle.Top;
            pnlMenuLateral.Location = new Point(0, 0);
            pnlMenuLateral.Name = "pnlMenuLateral";
            pnlMenuLateral.Size = new Size(52, 46);
            pnlMenuLateral.TabIndex = 5;
            pnlMenuLateral.Click += pnlMenuLateral_Click;
            pnlMenuLateral.MouseEnter += pnlMenuLateral_MouseEnter;
            pnlMenuLateral.MouseLeave += pnlMenuLateral_MouseLeave;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenu.Location = new Point(59, 12);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(54, 20);
            lblMenu.TabIndex = 5;
            lblMenu.Text = "MENU";
            lblMenu.Click += lblMenu_Click;
            // 
            // imgMenu
            // 
            imgMenu.Image = (Image)resources.GetObject("imgMenu.Image");
            imgMenu.Location = new Point(10, 6);
            imgMenu.Name = "imgMenu";
            imgMenu.Size = new Size(32, 32);
            imgMenu.SizeMode = PictureBoxSizeMode.CenterImage;
            imgMenu.TabIndex = 4;
            imgMenu.TabStop = false;
            imgMenu.Click += imgMenu_Click;
            imgMenu.MouseEnter += imgMenu_MouseEnter;
            imgMenu.MouseLeave += imgMenu_MouseLeave;
            // 
            // TelaBlocos
            // 
            TelaBlocos.AutoScroll = true;
            TelaBlocos.Controls.Add(button7);
            TelaBlocos.Controls.Add(label2);
            TelaBlocos.Controls.Add(button8);
            TelaBlocos.Controls.Add(button9);
            TelaBlocos.Controls.Add(button10);
            TelaBlocos.Controls.Add(button11);
            TelaBlocos.Controls.Add(button12);
            TelaBlocos.Controls.Add(vScrollBar1);
            TelaBlocos.Controls.Add(button6);
            TelaBlocos.Controls.Add(button5);
            TelaBlocos.Controls.Add(button4);
            TelaBlocos.Controls.Add(button3);
            TelaBlocos.Controls.Add(lblBlocosTitle);
            TelaBlocos.Controls.Add(button1);
            TelaBlocos.Dock = DockStyle.Fill;
            TelaBlocos.Location = new Point(52, 66);
            TelaBlocos.Name = "TelaBlocos";
            TelaBlocos.Size = new Size(1244, 732);
            TelaBlocos.TabIndex = 2;
            TelaBlocos.Visible = false;
            // 
            // button7
            // 
            button7.Location = new Point(839, 234);
            button7.Name = "button7";
            button7.Size = new Size(135, 43);
            button7.TabIndex = 14;
            button7.Text = "BLOCO O";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(286, 54);
            label2.Name = "label2";
            label2.Size = new Size(542, 20);
            label2.TabIndex = 13;
            label2.Text = "Clique para acessar as informações de cada bloco e suas respectivas graduações";
            // 
            // button8
            // 
            button8.Location = new Point(698, 234);
            button8.Name = "button8";
            button8.Size = new Size(135, 43);
            button8.TabIndex = 12;
            button8.Text = "BLOCO L";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(557, 234);
            button9.Name = "button9";
            button9.Size = new Size(135, 43);
            button9.TabIndex = 11;
            button9.Text = "BLOCO K";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(416, 234);
            button10.Name = "button10";
            button10.Size = new Size(135, 43);
            button10.TabIndex = 10;
            button10.Text = "BLOCO J";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(275, 234);
            button11.Name = "button11";
            button11.Size = new Size(135, 43);
            button11.TabIndex = 9;
            button11.Text = "BLOCO H";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(134, 234);
            button12.Name = "button12";
            button12.Size = new Size(135, 43);
            button12.TabIndex = 8;
            button12.Text = "BLOCO G";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Dock = DockStyle.Right;
            vScrollBar1.Location = new Point(1227, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 732);
            vScrollBar1.TabIndex = 7;
            // 
            // button6
            // 
            button6.Location = new Point(775, 129);
            button6.Name = "button6";
            button6.Size = new Size(135, 43);
            button6.TabIndex = 6;
            button6.Text = "BLOCO F";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(634, 130);
            button5.Name = "button5";
            button5.Size = new Size(135, 43);
            button5.TabIndex = 5;
            button5.Text = "BLOCO E";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(493, 129);
            button4.Name = "button4";
            button4.Size = new Size(135, 43);
            button4.TabIndex = 4;
            button4.Text = "BLOCO D";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(352, 129);
            button3.Name = "button3";
            button3.Size = new Size(135, 43);
            button3.TabIndex = 3;
            button3.Text = "BLOCO C";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // lblBlocosTitle
            // 
            lblBlocosTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblBlocosTitle.AutoSize = true;
            lblBlocosTitle.BackColor = SystemColors.Window;
            lblBlocosTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBlocosTitle.Location = new Point(489, 16);
            lblBlocosTitle.Name = "lblBlocosTitle";
            lblBlocosTitle.Size = new Size(119, 37);
            lblBlocosTitle.TabIndex = 1;
            lblBlocosTitle.Text = "BLOCOS";
            // 
            // button1
            // 
            button1.Location = new Point(211, 130);
            button1.Name = "button1";
            button1.Size = new Size(135, 43);
            button1.TabIndex = 0;
            button1.Text = "BLOCO AB";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TelaMapa
            // 
            TelaMapa.AutoScroll = true;
            TelaMapa.Controls.Add(pictureBox1);
            TelaMapa.Controls.Add(vScrollBar2);
            TelaMapa.Dock = DockStyle.Fill;
            TelaMapa.Location = new Point(52, 66);
            TelaMapa.Name = "TelaMapa";
            TelaMapa.Size = new Size(1244, 732);
            TelaMapa.TabIndex = 3;
            TelaMapa.Visible = false;
            // 
            // vScrollBar2
            // 
            vScrollBar2.Dock = DockStyle.Right;
            vScrollBar2.Location = new Point(1227, 0);
            vScrollBar2.Name = "vScrollBar2";
            vScrollBar2.Size = new Size(17, 732);
            vScrollBar2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1227, 732);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1296, 798);
            Controls.Add(TelaMapa);
            Controls.Add(TelaBlocos);
            Controls.Add(pnlMenu);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "p";
            Load += Form1_Load;
            pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgClaro).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgEscuro).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgMinimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgMaximize).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgSair).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlMapa.ResumeLayout(false);
            pnlMapa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgMapa).EndInit();
            pnlMenuSair.ResumeLayout(false);
            pnlMenuSair.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgMenuSair).EndInit();
            pnlBlocos.ResumeLayout(false);
            pnlBlocos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgBlocos).EndInit();
            pnlMenuLateral.ResumeLayout(false);
            pnlMenuLateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgMenu).EndInit();
            TelaBlocos.ResumeLayout(false);
            TelaBlocos.PerformLayout();
            TelaMapa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private PictureBox imgMinimize;
        private PictureBox imgMaximize;
        private PictureBox imgSair;
        private Panel pnlMenu;
        private PictureBox imgMenu;
        private Panel pnlMenuLateral;
        private Label lblMenu;
        private Panel pnlBlocos;
        private Label lblBlocos;
        private PictureBox imgBlocos;
        private Panel pnlMenuSair;
        private Label lblMenuSair;
        private PictureBox imgMenuSair;
        private Panel TelaBlocos;
        private Label lblBlocosTitle;
        private Button button1;
        private VScrollBar vScrollBar1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Label label2;
        private PictureBox imgLogo;
        private Panel pnlMapa;
        private Label lblMapa;
        private PictureBox imgMapa;
        private Button button7;
        private PictureBox imgClaro;
        private PictureBox imgEscuro;
        private Panel TelaMapa;
        private VScrollBar vScrollBar2;
        private PictureBox pictureBox1;
    }
}