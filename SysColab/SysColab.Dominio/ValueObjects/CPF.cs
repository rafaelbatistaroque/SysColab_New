using System;

namespace sysColab.Domain.ValueObjects
{
    public class CPF
    {
        public string NumeroCPF { get; }
        public CPF(string numeroCPF)
        {
            if (string.IsNullOrEmpty(numeroCPF))
                throw new ApplicationException("O campo CPF não pode estar vazio");
            else if (numeroCPF.Length < 11 || numeroCPF.Length > 11)
                throw new ApplicationException("O CPF deve ter apenas 11 dígitos");
            else NumeroCPF = numeroCPF;
        }
        public override string ToString()
        {
            return NumeroCPF;
        }
    }
}
