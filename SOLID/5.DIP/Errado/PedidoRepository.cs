namespace SOLID._5.DIP.Errado
{
    public class PedidoRepository
    {
        private readonly MySQLConnection _connection;

        public PedidoRepository(MySQLConnection mySQLConnection)
        {
            _connection = mySQLConnection;
        }
    }

    public class MySQLConnection { }
}
