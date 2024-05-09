using SQLite;
using Iscapop.Config;
using Iscapop.Model;

namespace Iscapop.BaseDades
{
    public class BaseDades
    {
        private static SQLiteAsyncConnection connection;

        public static SQLiteAsyncConnection GetConnection()
        {
            if (connection is not null)
            {
                return connection;
            }
            else
            {
                connection = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
                return connection;
            }
        }

        static BaseDades()
        {
            CreaTablasAsync();
        }

        private static void CreaTablasAsync()
        {
            GetConnection().DropTableAsync<Foto>().Wait();
            GetConnection().DropTableAsync<Material>().Wait();
            //GetConnection().DropTableAsync<Centro>().Wait();
            GetConnection().DropTableAsync<Organismo>().Wait();
            GetConnection().DropTableAsync<Solicitud>().Wait();


            GetConnection().CreateTableAsync<Foto>().Wait();
            GetConnection().CreateTableAsync<Material>().Wait();
            //GetConnection().CreateTableAsync<Centro>().Wait();
            GetConnection().CreateTableAsync<Organismo>().Wait();
            GetConnection().CreateTableAsync<Solicitud>().Wait();

        }




    }
}
