namespace DesignPattern.CreationalPatterns.FactoryMethod
{
    public class LogisticaMaritima : LogisticaFactory
    {
        public override IVeiculo FactoryMethod()
        {
            return new Navio();
        }
    }
}
