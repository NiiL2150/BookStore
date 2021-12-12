using System;
using System.Data.SqlClient;

namespace BookStore.Repository
{
    public class GlobalRepository
    {
        private string connectionString;
        private SqlConnection connection;
        public SqlConnection Connection
        {
            get
            {
                return connection != null ? connection : connection = new SqlConnection(connectionString); 
            }
        }

        public GlobalRepository(string connectionString)
        {
            this.connectionString = connectionString;

            Database = new DatabaseRepository();
            Books = new BooksRepository(this);
            Genres = new GenresRepository(this);
            Publishers = new PublishersRepository(this);
            Authors = new AuthorsRepository(this);

            Database.Init(Connection);
        }

        public DatabaseRepository Database { get; }
        public BooksRepository Books { get; }
        public GenresRepository Genres { get; }
        public PublishersRepository Publishers { get; }
        public AuthorsRepository Authors { get; }
    }
}
