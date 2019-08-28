using MySql.Data.MySqlClient;
using SysColab.Dominio.RH.Entities;
using SysColab.Dominio.RH.ValueObjects;
using SysColab.Repositorios.ConexaoDAO;
using SysColab.Repositorios.RH.FuncionarioDAO.Interfaces;
using System;
using System.Data;
using System.Data.Common;

namespace SysColab.Repositorios.RH.FuncionarioDAO
{
    public class FuncionarioRepositorio : IFuncionarioRepositorio
    {
        private DbConnection _conexao;
        DbCommand SqlComando(string sqlComando)
        {
            _conexao = DAO.ObterConexao();
            DbCommand comando = DAO.ObterComando(_conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = sqlComando;

            return comando;
        }
        public DataTable ObterTodosFuncionarios()
        {
            DbCommand comando = SqlComando("SELECT * FROM tblFuncionarios");
            DbDataReader reader = DAO.LerDadosRecebidosDoBanco(comando);

            DataTable dadosFuncionarios = new DataTable();
            dadosFuncionarios.Load(reader);

            reader.Close();
            DAO.FecharConexao(_conexao);

            return dadosFuncionarios;
        }
        public void AtualizarFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }

        public void CriarFuncionario(Funcionario funcionario)
        {
            DbCommand comando = SqlComando("INSERT INTO tblFuncionarios" +
                                            "(PRIMEIRONOME, SOBRENOME, CPF, CTPS_NUMERO, CTPS_SERIE, CTPS_UF, DATANASCIMENTO, EMAIL)" +
                                            "VALUES (@primeiroNome, @sobreNome, @cpf, @ctsNumero, @ctpsSerie, @ctpsUf, @dataNasc, @email)");

            comando.Parameters.Add(new MySqlParameter("@primeiroNome", funcionario.Nome.PrimeiroNome));
            comando.Parameters.Add(new MySqlParameter("@sobreNome", funcionario.Nome.SobreNome));
            comando.Parameters.Add(new MySqlParameter("@cpf", funcionario.CPF.NumeroCPF));
            comando.Parameters.Add(new MySqlParameter("@ctsNumero", funcionario.CTPS.Numero));
            comando.Parameters.Add(new MySqlParameter("@ctpsSerie", funcionario.CTPS.Serie));
            comando.Parameters.Add(new MySqlParameter("@ctpsUf", funcionario.CTPS.Uf));
            comando.Parameters.Add(new MySqlParameter("@dataNasc", funcionario.DataNasc));
            comando.Parameters.Add(new MySqlParameter("@email", funcionario.Email.NomeEmail));
            comando.ExecuteNonQuery();
        }

        public void DeletarFuncionario(string cpf)
        {
            DbCommand comando = SqlComando("DELETE FROM tblFuncionarios WHERE CPF = @cpf");
            comando.Parameters.Add(new MySqlParameter("@cpf", cpf));
            comando.ExecuteNonQuery();
        }
        public Funcionario ObterFuncionario(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}
