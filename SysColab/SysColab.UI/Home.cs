using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysColab.UI
{
    public partial class Home : MaterialForm
    {
        MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
        public Home()
        {
            InitializeComponent();
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700,
                Primary.Indigo700, Accent.Lime400,
                TextShade.WHITE
                );

            pageFuncionarios.BringToFront();
        }

        private void BtnRH_Click(object sender, EventArgs e)
        {
            pageFuncionarios.BringToFront();

            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Blue600, Primary.Blue700,
            Primary.Indigo700, Accent.Lime400,
            TextShade.WHITE
            );
        }

        private void BtnServicos_Click(object sender, EventArgs e)
        {
            pagePrestadores.BringToFront();

            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.Green600, Primary.Green700,
            Primary.Indigo700, Accent.Lime400,
            TextShade.WHITE
            );
        }
    }
}
