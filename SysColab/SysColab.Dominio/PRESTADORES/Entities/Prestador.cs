using SysColab.Dominio.Compartilhados.ValueObjects;
using System.Collections.Generic;
using System.Linq;

namespace SysColab.Dominio.PRESTADORES.Entities
{
    public class Prestador
    {
        private IList<Telefone> _numerosContatos;
        private IList<ServicoPrestado> _servicosPrestados;

        public int Id { get;  set; }
        public string Servico { get; set; }
        public string InfoAdicionaisPrestador { get; set; }

        public IReadOnlyCollection<Telefone> NumerosContato => _numerosContatos.ToArray();
        public IReadOnlyCollection<ServicoPrestado> ServicosPrestado => _servicosPrestados.ToArray();


    }
}
