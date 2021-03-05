namespace SOLID._2.OCP.Certo
{
    public class CalcularRemuneracaoContratual
    {
        public decimal Calcular(IRemuneracao remuneracao)
        {
            return remuneracao.Remuneracao();
        }
    }
}
