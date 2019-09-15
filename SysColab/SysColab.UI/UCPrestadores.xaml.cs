using SysColab.Repositorios.PRESTADORES.PrestadorDAO;
using System.Windows;
using System.Windows.Controls;

namespace SysColab.UI
{
    /// <summary>
    /// Interação lógica para UCPrestadores.xam
    /// </summary>
    public partial class UCPrestadores : UserControl
    {
        PrestadorRepositorio prestadores = new PrestadorRepositorio();

        private static UCPrestadores _intancia;
        public static UCPrestadores Instancia => ObterInstancia();

        static UCPrestadores ObterInstancia()
        {
            if (_intancia == null) _intancia = new UCPrestadores();
            return _intancia;
        }

        public UCPrestadores()
        {
            InitializeComponent();
            CarregarListaPrestadores();
        }
        void CarregarListaPrestadores()
        {
            listaPrestadores.ItemsSource = prestadores.ObterTodosPrestadores();
        }

        private void CarregarPrestador(object sender, RoutedEventArgs e)
        {
            gradePrestadores.Children.Clear();
            var tagBotao = (Button)sender;
            UCFaturasPrestador.Instancia.NomePrestador.Text = tagBotao.Tag.ToString();

            gradePrestadores.Children.Add(UCFaturasPrestador.Instancia);
        }

    }
}
