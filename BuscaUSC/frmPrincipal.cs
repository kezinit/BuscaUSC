using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.DataFormats;
using System.Runtime.InteropServices;
using BuscaUSC.Views;

namespace BuscaUSC
{
    public partial class frmPrincipal : Form
    {
        string modo;
        public frmPrincipal()
        {
            InitializeComponent();

        }

        MoveForm mv = new MoveForm();
        public struct MoveForm
        {
            public int X;
            public int Y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            modo = "claro";
        }

        private void imgSair_Click(object sender, EventArgs e)
        {
            const string message = "Tem Certeza que deseja sair do aplicativo?";
            const string caption = "Fechar o Aplicativo";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void imgSair_MouseEnter(object sender, EventArgs e)
        {
            imgSair.BackColor = Color.Red;
        }

        private void imgSair_MouseLeave(object sender, EventArgs e)
        {
            imgSair.BackColor = Color.WhiteSmoke;
        }

        private void imgMaximize_MouseEnter(object sender, EventArgs e)
        {
            imgMaximize.BackColor = Color.Gainsboro;
        }
        private void imgMaximize_MouseLeave(object sender, EventArgs e)
        {
            imgMaximize.BackColor = Color.WhiteSmoke;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            this.Left = mv.X + MousePosition.X;
            this.Top = mv.Y + MousePosition.Y;
        }

        private void imgMaximize_Click(object sender, EventArgs e)
        {
            Rectangle workingAreaRect = Screen.PrimaryScreen.WorkingArea;
            Size workingsize = workingAreaRect.Size;

            if (this.WindowState == FormWindowState.Normal)
            {
                MaximumSize = workingsize;
                WindowState = FormWindowState.Maximized;
                TopMost = false;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void imgMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            mv.X = this.Left - MousePosition.X;
            mv.Y = this.Top - MousePosition.Y;
        }

        private void imgMinimize_MouseEnter(object sender, EventArgs e)
        {
            imgMinimize.BackColor = Color.Gainsboro;
        }

        private void imgMinimize_MouseLeave(object sender, EventArgs e)
        {
            imgMinimize.BackColor = Color.WhiteSmoke;
        }

        private void imgMenu_Click(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void pnlMenuLateral_Click(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void pnlMenuSair_Click(object sender, EventArgs e)
        {
            const string message = "Tem Certeza que deseja sair do aplicativo?";
            const string caption = "Fechar o Aplicativo";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void imgBlocos_Click(object sender, EventArgs e)
        {
            if (TelaMapa.Visible == true)
            {
                Utils.ExibePanel(TelaBlocos);
                TelaMapa.Visible = false;
            }
            else
            {
                Utils.ExibePanel(TelaBlocos);
            }
        }

        private void lblBlocos_Click(object sender, EventArgs e)
        {
            if (TelaMapa.Visible == true)
            {
                Utils.ExibePanel(TelaBlocos);
                TelaMapa.Visible = false;
            }
            else
            {
                Utils.ExibePanel(TelaBlocos);
            }
        }

        private void pnlBlocos_Click(object sender, EventArgs e)
        {
            if (TelaMapa.Visible == true)
            {
                Utils.ExibePanel(TelaBlocos);
                TelaMapa.Visible = false;
            }
            else
            {
                Utils.ExibePanel(TelaBlocos);
            }
        }

        private void imgEscuro_Click(object sender, EventArgs e)
        {
            if (modo == "claro")
            {
                modo = "escuro";
                imgClaro.Visible = true;
                imgEscuro.Visible = false;
            }
            else
            {
                modo = "claro";
                imgClaro.Visible = false;
                imgEscuro.Visible = true;
            }
        }

        private void imgClaro_Click(object sender, EventArgs e)
        {
            if (modo == "escuro")
            {
                modo = "claro";
                imgClaro.Visible = true;
                imgEscuro.Visible = false;
            }
            else
            {
                modo = "escuro";
                imgClaro.Visible = false;
                imgEscuro.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmBlocoAB tela = new frmBlocoAB();
            tela.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmBlocoC tela = new frmBlocoC();
            tela.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmBlocoD tela = new frmBlocoD();
            tela.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmBlocoE tela = new frmBlocoE();
            tela.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmBlocoF tela = new frmBlocoF();
            tela.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmBlocoG tela = new frmBlocoG();
            tela.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmBlocoH tela = new frmBlocoH();
            tela.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmBlocoJ tela = new frmBlocoJ();
            tela.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmBlocoK tela = new frmBlocoK();
            tela.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            frmBlocoL tela = new frmBlocoL();
            tela.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmBlocoO tela = new frmBlocoO();
            tela.Show();
        }

        private void pnlMenu_MouseEnter(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void pnlMenu_MouseLeave(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void pnlBlocos_MouseLeave(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void pnlBlocos_MouseEnter(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void pnlMenuLateral_MouseEnter(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void pnlMenuLateral_MouseLeave(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void pnlMenuSair_MouseEnter(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void pnlMenuSair_MouseLeave(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void imgBlocos_MouseEnter(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void imgBlocos_MouseLeave(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void imgMenu_MouseEnter(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void imgMenu_MouseLeave(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void imgMapa_MouseEnter(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void imgMapa_MouseLeave(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void pnlMapa_MouseEnter(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void pnlMapa_MouseLeave(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void imgMenuSair_MouseEnter(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void imgMenuSair_MouseLeave(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void lblBlocos_MouseEnter(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void lblBlocos_MouseLeave(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void lblMapa_MouseEnter(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void lblMapa_MouseLeave(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void lblMenu_MouseEnter(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void lblMenu_MouseLeave(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void lblMenuSair_MouseEnter(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void lblMenuSair_MouseLeave(object sender, EventArgs e)
        {
            Utils.ExibeMenu(pnlMenu);
        }

        private void imgMapa_Click(object sender, EventArgs e)
        {
            if (TelaBlocos.Visible == true)
            {
                Utils.ExibePanel(TelaMapa);
                TelaBlocos.Visible = false;
            }
            else
            {
                Utils.ExibePanel(TelaMapa);
            }
        }

        private void pnlMapa_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlMapa_Click(object sender, EventArgs e)
        {
            if (TelaBlocos.Visible == true)
            {
                Utils.ExibePanel(TelaMapa);
                TelaBlocos.Visible = false;
            }
            else
            {
                Utils.ExibePanel(TelaMapa);
            }
        }

        private void lblMapa_Click(object sender, EventArgs e)
        {
            if (TelaBlocos.Visible == true)
            {
                Utils.ExibePanel(TelaMapa);
                TelaBlocos.Visible = false;
            }
            else
            {
                Utils.ExibePanel(TelaMapa);
            }
        }
    }
}