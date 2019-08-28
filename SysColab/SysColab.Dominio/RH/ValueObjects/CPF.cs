using System;

namespace SysColab.Dominio.RH.ValueObjects
{
    public class CPF
    {
        public string NumeroCPF { get; }
        public CPF(string numeroCPF)
        {
            //FAZER: Implementar outras validações de cpf.
            NumeroCPF = ValidarCPF(numeroCPF);
        }
        string ValidarCPF(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                throw new ApplicationException("O campo CPF não pode estar vazio");
            else if (cpf.Length != 11)
                throw new ApplicationException("O CPF deve ter apenas 11 dígitos");
            else return cpf;
        }
        public override string ToString()
        {
            return NumeroCPF;
        }
    }
}
