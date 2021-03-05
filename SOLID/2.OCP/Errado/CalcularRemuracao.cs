namespace SOLID._2.OCP.Errado
{
    public class CalcularRemuracao
    {
        public decimal Calcular(string contrato)
        {
            if (contrato.Equals("Estagio"))
                return new Estagio().Remuneracao();
            else if (contrato.Equals("ContratoClt"))
                return new ContratoClt().Remuneracao();
            else return 0;
        }
    }
}
