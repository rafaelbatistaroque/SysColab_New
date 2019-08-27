using SysColab.Dominio.Enums;
using System;

namespace SysColab.Dominio.ValueObjects
{
    public class CTPS
    {
        public int Numero { get; }
        public int Serie { get; }
        public string Uf { get; }
        public CTPS(string numero, string serie, string uf)
        {
            Numero = ValidarNumeroCTPS(numero);
            Serie = ValidarSerieCTPS(serie);
            Uf = ValidarSiglaEstadoBrasileiro(uf).ToString();
        }
        public int ValidarNumeroCTPS(string num)
        {
            if (!int.TryParse(num, out int ctpsNr))
                throw new ApplicationException("O campo CTPS Nr só aceita números");
            else return ctpsNr;
        }
        int ValidarSerieCTPS(string serie)
        {
            if (!int.TryParse(serie, out int ctpsSerie))
                throw new ApplicationException("O campo CTPS Série só aceita números");
            else return ctpsSerie;
        }
        EEstadosBrasileirosSigla ValidarSiglaEstadoBrasileiro(string uf)
        {
            if (string.IsNullOrWhiteSpace(uf) || char.IsDigit(uf, 0) || !Enum.TryParse(uf, true, out EEstadosBrasileirosSigla ctpsUf))
                throw new ApplicationException("O campo CTPS UF só aceita siglas de Estados Brasileiros");
            else return ctpsUf;
        }
    }
}
