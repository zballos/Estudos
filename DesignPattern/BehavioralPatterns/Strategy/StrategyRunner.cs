using System;

namespace DesignPattern.BehavioralPatterns.Strategy
{
    public class StrategyRunner
    {
        public void Run()
        {
            Console.WriteLine("===> Strategy Pattern");
            var contexto = new Contexto();

            Console.WriteLine("Cliente: palavras em ordem alfabética");
            contexto.SetPalavrasStrategy(new OrdemAlfabetica());
            contexto.ExecutarLogicaDeNegocio();

            Console.WriteLine();

            Console.WriteLine("Cliente: palavras em ordem alfabética reversa");
            contexto.SetPalavrasStrategy(new OrdemAlfabeticaReversa());
            contexto.ExecutarLogicaDeNegocio();

            Console.WriteLine();
        }
    }
}
