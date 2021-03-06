﻿namespace DesignPattern.FactoryMethod
{
    public class LogisticaTerrestre : LogisticaFactory
    {
        public override IVeiculo FactoryMethod()
        {
            return new Caminhao();
        }
    }
}
