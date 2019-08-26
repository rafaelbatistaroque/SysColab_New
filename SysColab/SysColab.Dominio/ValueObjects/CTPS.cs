using sysColab.Domain.Enums;
using System;

namespace sysColab.Domain.ValueObjects
{
    public class CTPS
    {
        public int Numero { get; private set; }
        public int Serie { get; private set; }
        public string Uf { get; private set; }
        public CTPS(string numero, string serie, string uf)
        {
            EEstadosBrasileirosSigla ctpsUf;
            if (!int.TryParse(numero, out int ctpfNr))
                throw new ApplicationException("O campo CTPS Nr só aceita números");
            else if (!int.TryParse(serie, out int ctpfSerie))
                throw new ApplicationException("O campo CTPS Série só aceita números");
            else if (string.IsNullOrWhiteSpace(uf) || char.IsDigit(uf, 0) || !VerificarSeEhEstadoBrasileiro(uf))
                throw new ApplicationException("O campo CTPS UF só aceita siglas de Estados Brasileiros");
            else
            {
                Numero = ctpfNr;
                Serie = ctpfSerie;
                Uf = ctpsUf.ToString();
            }
            bool VerificarSeEhEstadoBrasileiro(string estado)
            {
                bool convertidoParaEnum = Enum.TryParse(estado, true, out ctpsUf);
                return convertidoParaEnum;
            }
        }
    }
}
