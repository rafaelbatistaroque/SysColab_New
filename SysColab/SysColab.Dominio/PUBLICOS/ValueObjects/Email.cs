namespace SysColab.Dominio.PUBLICOS.ValueObjects
{
    public class Email
    {
        public string NomeEmail { get; }
        public Email(string email)
        {
            //FAZER: Criar regras de validação para email.
            NomeEmail = email;
        }
    }
}
