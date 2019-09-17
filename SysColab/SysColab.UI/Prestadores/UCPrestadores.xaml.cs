using MaterialDesignThemes.Wpf;
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
        public ObservableCollection<Prestador> Prestadores { get; set; }
        PrestadorDAO prestadores = new PrestadorDAO();

        public UCPrestadores()
        {
            InitializeComponent();
            CarregarListaPrestadores();
        }
        void CarregarListaPrestadores()
        {
            Prestadores = prestadores.ObterTodosPrestadores();
            listaPrestadores.ItemsSource = Prestadores;
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
