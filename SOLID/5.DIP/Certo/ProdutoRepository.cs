using System;

namespace SOLID._5.DIP.Certo
{
    public class ProdutoRepository
    {
        private readonly IDBConnection _connection;

        public ProdutoRepository(IDBConnection connection)
        {
            _connection = connection;
        }

        public void MostrarConnectionString()
        {
            Console.WriteLine($"ProdutoRepository: {_connection.GetConnectionString()}");
        }
    }
}
