using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysColab.Dominio.Compartilhados.ValueObjects
{
    public class Telefone
    {
        //FAZER: Implementar Validações e construtor.
        public string DDD { get; private set; }
        public string Numero { get; private set; }
    }
}
