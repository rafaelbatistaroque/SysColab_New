using SysColab.DAO.PRESTADORES.PrestadorDAO;
using SysColab.Dominio.PRESTADORES.Entities;
using SysColab.Servicos.NotificacaoServico;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;
using System.Windows.Data;
using SysColab.Dominio.PRESTADORES.Enums;
using System.Windows.Media;

namespace SysColab.UI
{

    public partial class UCServicosPrestados : UserControl
    {
        public string IdPrestador { get; }
        private ObservableCollection<ServicoPrestado> servicosPrestados { get; set; }

        ServicoPrestadoDAO faturaServicoPrestado = new ServicoPrestadoDAO();
        public UCServicosPrestados(string idPrestador)
        {
            this.IdPrestador = idPrestador;
            InitializeComponent();
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            CarregarListFaturas();
        }
        private void CarregarListFaturas()
        {
            servicosPrestados = faturaServicoPrestado.ObterTodasAsFaturasDeServicosPrestados(IdPrestador);
            listaFaturas.ItemsSource = servicosPrestados;
        }
        private void RemoverFatura(object sender, RoutedEventArgs e)
        {
            var index = ((Button)sender).Tag.ToString();
            var fatura = servicosPrestados.Where(x => x.IdFatura.Equals(index)).FirstOrDefault();

            servicosPrestados.Remove(fatura);//Remove da lista
            faturaServicoPrestado.DeletarServicoPrestado(index);//Remove do banco
        }
        private void AlterarStatusFaturaDaPrestacaoDeServico(object sender, RoutedEventArgs e)
        {
            var index = ((ToggleButton)sender).Tag.ToString();
            var faturaLocalizada = servicosPrestados.Where(x => x.IdFatura.Equals(index)).FirstOrDefault();

            if (faturaLocalizada.Status.Equals(EStatusFaturaPrestadorServico.Aberta))
                faturaLocalizada.AlterarStatusDeFatura(EStatusFaturaPrestadorServico.Paga);
            else
                faturaLocalizada.AlterarStatusDeFatura(EStatusFaturaPrestadorServico.Aberta);

            faturaServicoPrestado.AtualizarFaturaServicoPrestado(faturaLocalizada);//Altera valor no Banco
        }
        private void CarregarPrestador(object sender, RoutedEventArgs e)
        {
            MainWindow janelaPrincial = (MainWindow)Application.Current.MainWindow;

            janelaPrincial.GridConteudo.Children.Clear();
            janelaPrincial.GridConteudo.Children.Add(new UCPrestadores());
        }

    }
}
