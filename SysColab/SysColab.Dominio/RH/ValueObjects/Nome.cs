namespace SysColab.Dominio.RH.ValueObjects
{
    public class Nome
    {
        public string PrimeiroNome { get; }
        public string SobreNome { get; }

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
