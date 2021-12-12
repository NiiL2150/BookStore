using System;
using System.Data.SqlClient;

namespace BookStore.Repository
{
    public class DatabaseRepository
    {
        public void Init(SqlConnection connection)
        {
            try
            {
                connection.Open();
                string query = @"CREATE TABLE Authors(
Id int Identity (1,1) PRIMARY KEY,
[Name] nvarchar(64) NOT NULL
);

CREATE TABLE Publishers(
Id int Identity (1,1) PRIMARY KEY,
[Name] nvarchar(64) NOT NULL
);

CREATE TABLE Genres(
Id int Identity (1,1) PRIMARY KEY,
[Name] nvarchar(64) NOT NULL
);

CREATE TABLE Books(
Id int Identity (1,1) PRIMARY KEY,
Title nvarchar(128) NOT NULL,
Pages int NOT NULL,
[Year] DateTime NOT NULL,
Stock int NOT NULL DEFAULT 0 CHECK (Stock >= 0),
Cost Money NOT NULL DEFAULT 0 CHECK (Cost >= 0),
Price Money NOT NULL DEFAULT 0 CHECK (Price >= 0),
PriceMultiplier float NOT NULL DEFAULT 1 CHECK (PriceMultiplier BETWEEN 0 AND 1),
PreviousBookId int NULL,
AuthorId int NOT NULL FOREIGN KEY REFERENCES Authors(ID),
PublisherId int NOT NULL FOREIGN KEY REFERENCES Publishers(ID),
GenreId int NOT NULL FOREIGN KEY REFERENCES Genres(ID)
);";

                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number != 2714) //If database already exists, does nothing
                {
                    throw ex;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
