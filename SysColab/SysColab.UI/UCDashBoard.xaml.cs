using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SysColab.UI
{
    /// <summary>
    /// Interação lógica para UCDashBoard.xam
    /// </summary>
    public partial class UCDashBoard : UserControl
    {

        private static UCDashBoard _intancia;
        public static UCDashBoard Instancia => ObterInstancia();

        static UCDashBoard ObterInstancia()
        {
            if (_intancia == null) _intancia = new UCDashBoard();
            return _intancia;
        }

        public UCDashBoard()
        {
            InitializeComponent();
        }
    }
}
