using MaterialDesignThemes.Wpf;
using SysColab.DAO.PRESTADORES.PrestadorDAO;
using SysColab.Dominio.PRESTADORES.Entities;
using SysColab.Servicos.NotificacaoServico;
using SysColab.Servicos.NotificacaoServico.Enums;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;


namespace SysColab.UI
{
    public partial class UCPrestadores : UserControl
    {
        public ObservableCollection<Prestador> Prestadores { get; set; }
        PrestadorDAO prestadoresDAO = new PrestadorDAO();

        public UCPrestadores()
        {
            InitializeComponent();
            CarregarListaPrestadores();
        }
        void CarregarListaPrestadores()
        {
            Prestadores = prestadoresDAO.ObterTodosPrestadores();
            listaPrestadores.ItemsSource = Prestadores;
        }

        private void CarregarListaDeServicosPrestados(object sender, RoutedEventArgs e)
        {
            var idPrestador = ((Button)sender).Tag.ToString();

            MainWindow janelaPrincial = (MainWindow)Application.Current.MainWindow;

            janelaPrincial.GridConteudo.Children.Clear();
            janelaPrincial.GridConteudo.Children.Add(new UCServicosPrestados(idPrestador));
        }

        private void SalvarNovoPrestador(object sender, RoutedEventArgs e)
        {
            try
            {
                var prestador = new Prestador(txtPrestador.Text, txtInfoAdicionais.Text);
                Prestadores.Add(prestador);
                prestadoresDAO.CriarPrestador(prestador);
            }
            catch (Exception err)
            {
                Notificacao.Notificar(err.Message, ETipoNotificacao.Erro);
            }
        }
    }
}



//var person = new Person
//{
//    FirstName = "John",
//    LastName = "Doe"
//};
//await MaterialDesignThemes.Wpf.DialogHost.Show(person);