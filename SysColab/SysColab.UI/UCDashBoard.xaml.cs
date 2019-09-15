using System.Windows.Controls;

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
