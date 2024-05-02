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
            InsertaDades();

        }
        private async static void InsertaDades()
        {


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


/*
        private static void InsertaDadesAsync()
        {
            
            User user1 = new User { Name = "Pepe", Active = true };
            GetConnection().InsertAsync(user1).Wait();
            Post post1 = new Post { Title = "css", Summary = "Sumario del post css de pepe", Content = "Contenido del post css de pepe", CreationMoment = DateTime.Now };
            Post post2 = new Post { Title = "html", Summary = "Sumario del post html de pepe", Content = "Contenido del post html de pepe", CreationMoment = DateTime.Now };
            GetConnection().InsertAsync(post1).Wait();
            GetConnection().InsertAsync(post2).Wait();
            user1.Posts.Add(post1);
            user1.Posts.Add(post2);
            GetConnection().UpdateWithChildrenAsync(user1).Wait();

            
            User user2 = new User { Name = "Maria", Active = true };
            Post post3 = new Post { Title = "java", Summary = "Sumario del post java de maria", Content = "Contenido del post java de maria", CreationMoment = DateTime.Now };
            Post post4 = new Post { Title = "c#", Summary = "Sumario del post c# de maria", Content = "Contenido del post C# de maria", CreationMoment= DateTime.Now };
            user2.Posts.Add(post3);
            user2.Posts.Add(post4);
            GetConnection().InsertWithChildrenAsync(user2).Wait();

            user1.Likes.Add(post3);
            post3.Likes.Add(user1);

            user2.Likes.Add(post1);
            user2.Likes.Add(post2);
            post1.Likes.Add(user2);
            post2.Likes.Add(user2);

            GetConnection().UpdateWithChildrenAsync(user1).Wait();
            GetConnection().UpdateWithChildrenAsync(user2).Wait();
            GetConnection().UpdateWithChildrenAsync(post1).Wait();
            GetConnection().UpdateWithChildrenAsync(post2).Wait();
            GetConnection().UpdateWithChildrenAsync(post3).Wait();
        }

        private static void CreaTablasAsync()
        {
                GetConnection().CreateTableAsync<User>().Wait();
                GetConnection().CreateTableAsync<Post>().Wait();
                GetConnection().CreateTableAsync<Tag>().Wait();
                GetConnection().CreateTableAsync<PostTag>().Wait();
                GetConnection().CreateTableAsync<Like>().Wait();
        }
        private static void DeleteTablasAsync()
        {
                GetConnection().DropTableAsync<User>().Wait();
                GetConnection().DropTableAsync<Post>().Wait();
                GetConnection().DropTableAsync<Tag>().Wait();
                GetConnection().DropTableAsync<PostTag>().Wait();
                GetConnection().DropTableAsync<Like>().Wait();
        }
    */