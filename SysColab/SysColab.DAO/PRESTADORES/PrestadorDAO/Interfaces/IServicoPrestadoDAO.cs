using SysColab.Dominio.PRESTADORES.Entities;
using System.Collections.ObjectModel;

namespace SysColab.DAO.PRESTADORES.PrestadorDAO.Interfaces
{
    interface IServicoPrestadoDAO
    {
        ObservableCollection<ServicoPrestado> ObterTodasAsFaturasDeServicosPrestados(string idPrestador);
        ServicoPrestado ObterFaturaDeServicoPrestado(int id);
        void CriarFaturaServicoPrestado(ServicoPrestado fatura);
        void AtualizarFaturaServicoPrestado(ServicoPrestado fatura);
        void DeletarServicoPrestado(string id);
    }
}
