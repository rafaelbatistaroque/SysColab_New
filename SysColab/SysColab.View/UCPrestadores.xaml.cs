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

namespace SysColab.View
{
    /// <summary>
    /// Interação lógica para UCPrestadores.xam
    /// </summary>
    public partial class UCPrestadores : UserControl
    {
        PrestadorRepositorio prestadores = new PrestadorRepositorio();
        public UCPrestadores()
        {
            InitializeComponent();
            CarregarListaPrestadores();
        }
        void CarregarListaPrestadores()
        {
            listaPrestadores.ItemsSource = prestadores.ObterTodosPrestadoresReader();
        }
    }
}
