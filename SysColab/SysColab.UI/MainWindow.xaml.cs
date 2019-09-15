using SysColab.Repositorios.PRESTADORES.PrestadorDAO;
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
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MoverForm(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void FecharAplicativo(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MaximizarOrMinimizar(object sender, MouseButtonEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else WindowState = WindowState.Normal;
        }

        private void AbrirPages(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            if(GridConteudo != null) GridConteudo.Children.Clear();

            switch (botao.Name)
            {
                case "btnPrestador":
                    GridConteudo.Children.Add(UCPrestadores.Instancia);
                    break;
                case "btnHome":
                    GridConteudo.Children.Add(UCDashBoard.Instancia);
                    break;
                default:
                    break;
            }
        }
    }
}
