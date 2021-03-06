namespace SOLID._5.DIP.Certo
{
    public class SQLServerConnection : IDBConnection
    {
        public string GetConnectionString()
        {
            return "ConnectionString SQLServer";
        }
    }
}
