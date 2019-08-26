using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysColab.Domain.ValueObjects
{
    public class Email
    {
        public string NomeEmail { get; private set; }
        public Email(string email)
        {
            //FAZER: Criar regras de validação para email.
            NomeEmail = email;
        }
    }
}
