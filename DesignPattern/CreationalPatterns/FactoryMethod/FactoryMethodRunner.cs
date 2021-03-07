using System;

namespace DesignPattern.CreationalPatterns.FactoryMethod
{
    public class FactoryMethodRunner
    {
        public void Run()
        {
            Console.WriteLine("===> FactoryMethod");
            MostrarMensagem(new LogisticaTerrestre());

            Console.WriteLine();

            MostrarMensagem(new LogisticaMaritima());

            Console.WriteLine();
        }

        private void MostrarMensagem(LogisticaFactory logisticaFactory)
        {
            Console.WriteLine("Cliente: não conhece a classe concreta, mas está tudo bem.\n" + logisticaFactory.Entrega());
        }
    }
}
