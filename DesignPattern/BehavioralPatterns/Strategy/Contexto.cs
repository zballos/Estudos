using System;
using System.Collections.Generic;

namespace DesignPattern.BehavioralPatterns.Strategy
{
    public class Contexto
    {
        private IPalavrasStrategy _strategy;

        public Contexto(){ }

        public Contexto(IPalavrasStrategy strategy)
        {
            _strategy = strategy;
        }

        public void SetPalavrasStrategy(IPalavrasStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecutarLogicaDeNegocio()
        {
            Console.WriteLine("Contexto: Ordenação de palavras.");

            var resultado = _strategy.Manipular(new List<string> { "Manga", "Maçã", "Kiwi", "Banana", "Acerola", "Caju" });

            string palavrasOrdenadas = string.Join(", ", resultado as List<string>);

            Console.WriteLine($"Resultado: {palavrasOrdenadas}");
        }
    }
}
