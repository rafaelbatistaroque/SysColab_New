﻿using SysColab.Dominio.RH.Entities;
using SysColab.Dominio.RH.ValueObjects;
using System.Data;

namespace SysColab.DAO.RH.FuncionarioDAO.Interfaces
{
    interface IFuncionarioDAO
    {
        DataTable ObterTodosFuncionarios();
        Funcionario ObterFuncionario(string cpf);
        void CriarFuncionario(Funcionario funcionario);
        void AtualizarFuncionario(Funcionario funcionario);
        void DeletarFuncionario(string cpf);
    }
}
