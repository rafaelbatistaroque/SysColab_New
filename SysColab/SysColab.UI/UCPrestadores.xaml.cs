using SysColab.DAO.PRESTADORES.PrestadorDAO;
using SysColab.Dominio.PRESTADORES.Entities;
using SysColab.Servicos.NotificacaoServico;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;


namespace SysColab.UI
{
    //FAZER: Implementar o ObservableColletion
    public partial class UCPrestadores : UserControl
    {

        public string ValorBadged { get; set; } = "3";
        public ObservableCollection<Prestador> Prestadores { get; set; }

        public UCPrestadores()
        {
            InitializeComponent();
            //NotificarQuantidadesDeFaturasVencidas();
            CarregarListaPrestadores();
        }
        void CarregarListaPrestadores()
        {
            PrestadorDAO prestadores = new PrestadorDAO();
            listaPrestadores.ItemsSource = prestadores.ObterTodosPrestadores();
        }

        private void CarregarListaDeServicosPrestados(object sender, RoutedEventArgs e)
        {
            int idPrestador = Convert.ToInt32(((Button)sender).Tag);

            MainWindow mw = (MainWindow)Application.Current.MainWindow;

            mw.GridConteudo.Children.Clear();
            mw.GridConteudo.Children.Add(new UCServicosPrestados(idPrestador));

        }
    }
}
