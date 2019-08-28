using SysColab.Dominio.PRESTADORES.Enums;
using System;

namespace SysColab.Dominio.PRESTADORES.Entities
{
    public class ServicoPrestado
    {
        public int IdPrestador { get; private set; }
        public int IdFatura { get; private set; }
        public DateTime DataChegada { get; private set; }
        public DateTime DataVencimento { get; private set; }
        public string MesReferencia { get; private set; }
        public Double ValorFatura { get; private set; }
        public EStatusFaturaPrestadorServico Status { get; private set; }
        public string InfoAdicionaisFatura { get; private set; }


    }
}
