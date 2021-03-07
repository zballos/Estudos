using System.Collections.Generic;

namespace DesignPattern.BehavioralPatterns.Strategy
{
    public class OrdemAlfabetica : IPalavrasStrategy
    {
        public object Manipular(object data)
        {
            var palavras = data as List<string>;
            palavras.Sort();

            return palavras;
        }
    }
}
