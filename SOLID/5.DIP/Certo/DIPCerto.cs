using System;

namespace SOLID._5.DIP.Certo
{
    public static class DIPCerto
    {
        public static void Executar()
        {
            Console.WriteLine("===> 5.DIP");

            var mySql = new MySQLConnection();
            var sqlServer = new SQLServerConnection();

            var produtoRepository = new ProdutoRepository(mySql);
            var pedidoRepository = new PedidoRepository(sqlServer);

            produtoRepository.MostrarConnectionString();
            pedidoRepository.MostrarConnectionString();

            Console.WriteLine();
        }
    }
}
