using SysColab.Dominio.PRESTADORES.Entities;
using System.Data;

namespace SysColab.Repositorios.PRESTADORES.PrestadorDAO.Interfaces
{
    interface IPrestadorRepositorio
    {
        DataTable ObterTodosPrestadores();
        Prestador ObterPrestador(int id);
        void CriarPrestador(Prestador prestador);
        void AtualizarPrestador(Prestador prestador);
        void DeletarPrestador(int id);
    }
}
