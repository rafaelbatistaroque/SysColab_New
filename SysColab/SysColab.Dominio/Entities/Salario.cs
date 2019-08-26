using sysColab.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysColab.Domain.Entities
{
    public class Salario
    {
        public double Remuneracao { get; private set; }
        public DateTime DataAlteracao { get; private set; }
        public AlteracaoSalarial Motivo { get; private set; }
    }
}
