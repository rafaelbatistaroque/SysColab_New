using SysColab.Dominio.Entities;
using SysColab.Dominio.ValueObjects;
using System.Data;

namespace SysColab.Repositorios
{
    interface IFuncionarioRepository
    {
        DataTable ObterTodosFuncionarios();
        Funcionario ObterFuncionario(string cpf);
        void CriarFuncionario(Funcionario funcionario);
        void AtualizarFuncionario(CPF cpf);
        void DeletarFuncionario(string cpf);
    }
}
