namespace DesignPattern.FactoryMethod
{
    public abstract class LogisticaFactory
    {
        public abstract IVeiculo FactoryMethod();

        public string Entrega()
        {
            var veiculo = FactoryMethod();

            var resultado = ": funciona com mesmo factory " + veiculo.Operacao();

            return resultado;
        }
    }
}
