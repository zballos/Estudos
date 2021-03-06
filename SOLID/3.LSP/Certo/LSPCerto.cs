using System;

namespace SOLID._3.LSP.Certo
{
    public static class LSPCerto
    {
		public static void Executar()
        {
            Console.WriteLine("===> 3.LSP");

            var veiculo = new Veiculo("Porche");
            var carro = new Carro("Land rover");
            var moto = new Moto("CG Titan");

            ImprimirNome(veiculo);
            ImprimirNome(carro);
            ImprimirNome(moto);

            Console.WriteLine();
        }

        private static void ImprimirNome(Veiculo veiculo)
        {
            Console.WriteLine($"Veículo: {veiculo.Nome}");
        }
    }
}
