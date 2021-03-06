namespace SOLID._5.DIP.Certo
{
    public class MySQLConnection : IDBConnection
    {
        public string GetConnectionString()
        {
            return "ConnectionString MYSQL";
        }
    }
}
