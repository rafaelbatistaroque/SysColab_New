using SysColab.Dominio.Compartilhados.ValueObjects;
using SysColab.Dominio.PRESTADORES.Enums;
using System;

namespace SysColab.Dominio.PRESTADORES.Entities
{
    public class ServicoPrestado
    {

        public int IdPrestador { get; }
        public int IdFatura { get; }
        public Data DataChegada { get;}
        public Data DataVencimento { get;}
        public string MesReferencia { get;}
        public double ValorFatura { get; }
        public EStatusFaturaPrestadorServico Status { get; private set; }
        public string InfoAdicionaisFatura { get; }
        public bool FaturaAtrasa => VerificarSeFaturaEstaAtrasada();

        public ServicoPrestado(int idPrestador, Data dataChegada, Data dataVencimento, string mesReferencia,
            string valorFatura, string status, string infoAdicionais)
        {
            IdPrestador = idPrestador;
            DataChegada = dataChegada;
            DataVencimento = dataVencimento;
            MesReferencia = mesReferencia;
            ValorFatura = ValidarValorDaFatura(valorFatura);
            Status = ValidarStatusDeFatura(status);
            InfoAdicionaisFatura = infoAdicionais;
        }
        public ServicoPrestado(int idFatura, int idPrestador, Data dataChegada, Data dataVencimento, string mesReferencia,
            string valorFatura, string status, string infoAdicionais) : this(idPrestador, dataChegada, dataVencimento, mesReferencia, valorFatura, status, infoAdicionais)
        {
            IdFatura = idFatura;
        }
        double ValidarValorDaFatura(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor) || char.IsLetter(valor, 0) || !double.TryParse(valor, out double valorValidado))
                throw new ApplicationException("O valor da fatura é inválido.");
            return valorValidado;
        }
        EStatusFaturaPrestadorServico ValidarStatusDeFatura(string status)
        {
            if (!Enum.TryParse(status, true, out EStatusFaturaPrestadorServico statusValidado))
                throw new ApplicationException("Não foi possível inserir o status da fatura.");
            return statusValidado;
         }
        bool VerificarSeFaturaEstaAtrasada()
        {
            if (DataVencimento.DataFormatoBD < DateTime.Now && Status.Equals(EStatusFaturaPrestadorServico.Aberta))
                return true;
            return false;
        }
        public void AlterarStatusDeFatura(EStatusFaturaPrestadorServico status)
        {
            Status = status;
        }

    }
}
