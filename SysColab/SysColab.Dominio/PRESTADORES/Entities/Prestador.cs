using SysColab.Dominio.Compartilhados.ValueObjects;
using System.Collections.Generic;
using System.Linq;

namespace SysColab.Dominio.PRESTADORES.Entities
{
    public class Prestador
    {
        private IList<ServicoPrestado> _servicosPrestados;

        public int IdPrestador { get;  set; }
        public string Servico { get; set; }
        public string InfoAdicionaisPrestador { get; set; }

        public IReadOnlyCollection<ServicoPrestado> ServicosPrestado => _servicosPrestados.ToArray();



    }
}
