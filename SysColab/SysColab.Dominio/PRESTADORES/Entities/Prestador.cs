using SysColab.Dominio.Compartilhados.ValueObjects;
using System;

namespace SysColab.Dominio.PRESTADORES.Entities
{
    public class Prestador
    {
        public string IdPrestador { get; set; }
        public string Servico { get; }
        public string InfoAdicionaisPrestador { get; }

        public Prestador(string servico, string infoAdicionaisPrestador)
        {
            IdPrestador = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            Servico = ValidarServico(servico);
            InfoAdicionaisPrestador = infoAdicionaisPrestador;
        }
        public Prestador(string idPrestador, string servico, string infoAdicionaisPrestador) : this(servico, infoAdicionaisPrestador)
        {
            IdPrestador = idPrestador;
        }
        string ValidarServico(string sv)
        {
            if (string.IsNullOrWhiteSpace(sv) || char.IsDigit(sv, 0))
                throw new ApplicationException("O campo de serviço não é válido.");
            return sv;
        }
    }
}
