namespace DesignPattern.CreationalPatterns.FactoryMethod
{
    public class LogisticaTerrestre : LogisticaFactory
    {
        public override IVeiculo FactoryMethod()
        {
            return new Caminhao();
        }
    }
}
