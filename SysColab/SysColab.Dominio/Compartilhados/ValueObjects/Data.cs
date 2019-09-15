using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysColab.Dominio.Compartilhados.ValueObjects
{
    public class Data
    {
        //FAZER UU: realizar testes de validação
        public DateTime DataFormatoBD { get; set; }

        public Data(string data)
        {
            DataFormatoBD = ValidarData(data);
        }
        DateTime ValidarData(string dt)
        {
            if (string.IsNullOrWhiteSpace(dt) || char.IsLetter(dt, 0) || !DateTime.TryParse(string.Format(dt, "yyyy-MM-dd"), out DateTime dataConvertida))
                throw new ApplicationException("A data está em formato incorreto.");
            else return dataConvertida;
        }
        public override string ToString()
        {
            return DataFormatoBD.ToShortDateString();
        }
    }
}
