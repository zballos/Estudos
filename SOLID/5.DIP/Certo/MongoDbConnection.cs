namespace SOLID._5.DIP.Certo
{
    public class MongoDbConnection : IDBConnection
    {
        public string GetConnectionString()
        {
            return "ConnectionString Mongo";
        }
    }
}
