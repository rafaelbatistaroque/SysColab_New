using MaterialDesignThemes.Wpf;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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

        private async void AbrirPages(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            if (GridConteudo != null) GridConteudo.Children.Clear();

            switch (botao.Name)
            {
                case "btnPrestador":
                    GridConteudo.Children.Add(new UCPrestadores());
                    TextoDoTituloMenu.Text = "Prestadores de Serviços";
                    break;
                case "btnHome":
                    GridConteudo.Children.Add(UCDashBoard.Instancia);
                    TextoDoTituloMenu.Text = "Home";
                    break;
                case "btnRH":
                    break;
                default:
                    break;
            }

        }
    }
}
