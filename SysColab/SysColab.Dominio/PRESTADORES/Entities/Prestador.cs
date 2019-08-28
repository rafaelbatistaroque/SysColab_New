using SysColab.Dominio.PUBLICOS.ValueObjects;
using System.Collections.Generic;
using System.Linq;

namespace SysColab.Dominio.PRESTADORES.Entities
{
    public class Prestador
    {
        private IList<Telefone> _numerosContatos;
        private IList<ServicoPrestado> _servicosPrestados;
        public int Id { get; private set; }
        public string Servico { get; private set; }
        public string InfoAdicionaisPrestador { get; private set; }
        public IReadOnlyCollection<Telefone> NumerosContato => _numerosContatos.ToArray();
        public IReadOnlyCollection<ServicoPrestado> ServicosPrestado => _servicosPrestados.ToArray();


    }
}
