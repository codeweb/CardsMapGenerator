using System;
using System.Linq;
using System.Web.UI;

namespace CardsMapGenerator
{
    public partial class Default : Page
    {
        private int contatoreRed = 9;
        private int contatoreBlu = 8;
        private int contatoreNullo = 7;
        private int contatoreNero = 1;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (Page.IsPostBack)
                return;

            string[] colors = new string[25];
            Random rnd = new Random();

            for (int i = 0; i < colors.Length; i++)
            {
                string color = string.Empty;
                do
                {
                    int choose = rnd.Next(1, 5);
                    color = Choose(choose);
                }
                while (color == string.Empty);
                colors[i] = color;
            }
            rptColori.DataSource = colors;
            rptColori.DataBind();
        }

        private string Choose(int chosen)
        {
            switch (chosen)
            {
                case 1:
                    if (contatoreRed > 0)
                    {
                        contatoreRed--;
                        return "#00f";
                    }
                    break;
                case 2:
                    if (contatoreBlu > 0)
                    {
                        contatoreBlu--;
                        return "#f00";
                    }
                    break;
                case 3:
                    if (contatoreNullo > 0)
                    {
                        contatoreNullo--;
                        return "#F0DC82";
                    }
                    break;
                case 4:
                    if (contatoreNero > 0)
                    {
                        contatoreNero--;
                        return "#000";
                    }
                    break;
                default:
                    return string.Empty;
            }
            return string.Empty;

        }
    }
}