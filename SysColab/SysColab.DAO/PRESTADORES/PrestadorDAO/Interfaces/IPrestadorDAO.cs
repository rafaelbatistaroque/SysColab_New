using SysColab.Dominio.PRESTADORES.Entities;
using System.Collections.ObjectModel;

namespace SysColab.DAO.PRESTADORES.PrestadorDAO.Interfaces
{
    interface IPrestadorDAO
    {
        ObservableCollection<Prestador> ObterTodosPrestadores();
        Prestador ObterPrestador(int id);
        void CriarPrestador(Prestador prestador);
        void AtualizarPrestador(Prestador prestador);
        void DeletarPrestador(int id);
    }
}
