namespace SysColab.Dominio.ValueObjects
{
    public class PIS
    {
        public string NumeroPIS { get; }

        //FAZER: Implementar validação do PIS
        public PIS(string numeroPIS)
        {
            NumeroPIS = numeroPIS;
        }


        public override string ToString()
        {
            return NumeroPIS.ToString();
        }
    }
}
