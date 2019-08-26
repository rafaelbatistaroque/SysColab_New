using System;

namespace sysColab.Domain.ValueObjects
{
    public class Nome
    {
        public string PrimeiroNome { get; private set; }
        public string SobreNome { get; private set; }

        public Nome(string primeiroNome, string sobreNome)
        {
            //FAZER: Criar regras de validação de código para nome e sobrenome
            PrimeiroNome = primeiroNome;
            SobreNome = sobreNome;
        }
        public override string ToString()
        {
            return $"{PrimeiroNome} {SobreNome}";
        }
    }
}
