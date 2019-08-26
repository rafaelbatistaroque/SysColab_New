using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sysColab.Domain.Entities
{
    public class Contrato
    {
        public DateTime DataDeAdmissao { get; private set; }
        public string Cargo { get; private set; }
        public Empresa Empresa { get; private set; }
        public DateTime DataDeSaida { get; private set; }
        public bool Ativo { get; private set; }

        public void RescindirContrato()
        {
            Ativo = false;
            DataDeSaida = DateTime.Now;
        }
        public void CriarContrato()
        {
            Ativo = true;
            DataDeSaida = DateTime.Now;
        }
    }

}
