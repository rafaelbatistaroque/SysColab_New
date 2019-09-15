using SysColab.Dominio.PRESTADORES.Entities;
using System.Collections.Generic;

namespace SysColab.Repositorios.PRESTADORES.PrestadorDAO.Interfaces
{
    interface IPrestadorRepositorio
    {
        List<Prestador> ObterTodosPrestadores();
        Prestador ObterPrestador(int id);
        void CriarPrestador(Prestador prestador);
        void AtualizarPrestador(Prestador prestador);
        void DeletarPrestador(int id);
    }
}
