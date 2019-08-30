using SysColab.Dominio.RH.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using SysColab.Dominio.Compartilhados.ValueObjects;

namespace SysColab.Dominio.RH.Entities
{
    public class Funcionario
    {
        private IList<Salario> _salarios;
        private IList<Contrato> _contratos;
        private IList<ContaBancaria> _contaBancaria;
        private IList<Arquivo> _arquivos;

        public IReadOnlyCollection<Salario> Salarios => _salarios.ToArray();
        public IReadOnlyCollection<Contrato> Contratos => _contratos.ToArray();
        public IReadOnlyCollection<ContaBancaria> ContaBancaria => _contaBancaria.ToArray();
        public IReadOnlyCollection<Arquivo> Arquivos => _arquivos.ToArray();

        public int Id { get; private set; }
        public Nome Nome { get; private set; }
        public CPF CPF { get; private set; }
        public CTPS CTPS { get; private set; }
        public PIS PIS { get; private set; }
        public DateTime DataNasc { get; private set; }
        public Email Email { get; private set; }

        public Funcionario(Nome nome, CPF cCPF, CTPS cCTPS, PIS pis, DateTime dataNasc, Email email)
        {
            Nome = nome;
            CPF = cCPF;
            CTPS = cCTPS;
            PIS = pis;
            DataNasc = dataNasc;
            Email = email;
        }
        public void AdicionarNovoContratoDeTrabalho(Contrato contrato)
        {
            //Se já tiver um contrato ativo, deve estar com status falso;
            foreach (Contrato contratoAntigo in Contratos)
                contratoAntigo.RescindirContrato();

            _contratos.Add(contrato);
        }
    }
}
