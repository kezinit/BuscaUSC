using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;

namespace BuscaUSC
{
    internal class Utils
    {

        public static void ArredondaCantosdoForm(Form nomeform)
        {

            GraphicsPath PastaGrafica = new GraphicsPath();
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, nomeform.Size.Width, nomeform.Size.Height));

            //Arredondar canto superior esquerdo        
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, 1, 10, 10));
            PastaGrafica.AddPie(1, 1, 20, 20, 180, 90);

            //Arredondar canto superior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(nomeform.Width - 12, 1, 12, 13));
            PastaGrafica.AddPie(nomeform.Width - 24, 1, 24, 26, 270, 90);

            //Arredondar canto inferior esquerdo
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(1, nomeform.Height - 10, 10, 10));
            PastaGrafica.AddPie(1, nomeform.Height - 20, 20, 20, 90, 90);

            //Arredondar canto inferior direito
            PastaGrafica.AddRectangle(new System.Drawing.Rectangle(nomeform.Width - 12, nomeform.Height - 13, 13, 13));
            PastaGrafica.AddPie(nomeform.Width - 24, nomeform.Height - 26, 24, 26, 0, 90);

            PastaGrafica.SetMarkers();
            nomeform.Region = new Region(PastaGrafica);
        }

        public static void ExibeMenu(Panel nomemenu)
        {
            if (nomemenu.Width == 52)
            {
                nomemenu.Width = 193;
            }
            else
            {
                nomemenu.Width = 52;
            }
        }
        public static void ExibePanel(Panel nomemenu)
        {
            if (nomemenu.Visible == false)
            {
                nomemenu.Visible = true;
            }
            else
            {
                nomemenu.Visible = false;
            }
        }
        public static void FechaForm(Form nomeform)
        {
            nomeform.Close();
        }

    }
}
