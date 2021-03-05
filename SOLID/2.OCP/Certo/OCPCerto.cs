using System;

namespace SOLID._2.OCP.Certo
{
    public static class OCPCerto
    {
        public static void Executar()
        {
            var estagio = new Estagio();
            var contratoClt = new ContratoClt();
            var contratoPj = new ContratoPj();

            var calculadora = new CalcularRemuneracaoContratual();

            Console.WriteLine($"Remuneração Estágio: {calculadora.Calcular(estagio)}");
            Console.WriteLine($"Remuneração Contrato CLT: {calculadora.Calcular(contratoClt)}");
            Console.WriteLine($"Remuneração Contrato PJ: {calculadora.Calcular(contratoPj)}");
        }
    }
}
