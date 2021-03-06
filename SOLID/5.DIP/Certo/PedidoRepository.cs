using System;

namespace SOLID._5.DIP.Certo
{
    public class PedidoRepository
    {
        private readonly IDBConnection _connection;

        public PedidoRepository(IDBConnection connection)
        {
            _connection = connection;
        }

        public void MostrarConnectionString()
        {
            Console.WriteLine($"PedidoRepository: {_connection.GetConnectionString()}");
        }
    }
}
