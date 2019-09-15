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
        public int IdPrestador { get; }
        private ObservableCollection<ServicoPrestado> servicosPrestados { get; set; }

        ServicoPrestadoDAO faturaServicoPrestado = new ServicoPrestadoDAO();
        public UCServicosPrestados(int idPrestador)
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
            int index = Convert.ToInt32(((Button)sender).Tag);
            var fatura = servicosPrestados.Where(x => x.IdFatura.Equals(index)).FirstOrDefault();

            servicosPrestados.Remove(fatura);//Remove da lista
            faturaServicoPrestado.DeletarServicoPrestado(index);//Remove do banco
        }
        private void AlterarStatusFaturaDaPrestacaoDeServico(object sender, RoutedEventArgs e)
        {
            int index = Convert.ToInt32(((ToggleButton)sender).Tag);
            var faturaLocalizada = servicosPrestados.Where(x => x.IdFatura.Equals(index)).FirstOrDefault();

            if (faturaLocalizada.Status.Equals(EStatusFaturaPrestadorServico.Aberta))
                faturaLocalizada.AlterarStatusDeFatura(EStatusFaturaPrestadorServico.Paga);
            else
                faturaLocalizada.AlterarStatusDeFatura(EStatusFaturaPrestadorServico.Aberta);

            faturaServicoPrestado.AtualizarFaturaServicoPrestado(faturaLocalizada);//Altera valor no Banco
        }
        private void CarregarPrestador(object sender, RoutedEventArgs e)
        {
            MainWindow mw = (MainWindow)Application.Current.MainWindow;

            mw.GridConteudo.Children.Clear();
            mw.GridConteudo.Children.Add(new UCPrestadores());
        }

    }
}
