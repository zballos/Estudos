using System.Collections.Generic;

namespace DesignPattern.BehavioralPatterns.Strategy
{
    public class OrdemAlfabeticaReversa : IPalavrasStrategy
    {
        public object Manipular(object data)
        {
            var palavras = data as List<string>;
            palavras.Sort();
            palavras.Reverse();

            return palavras;
        }
    }
}
