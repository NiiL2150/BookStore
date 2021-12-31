﻿using BookStore.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository
{
    public class PublishersRepository : AbstractRepository
    {
        public PublishersRepository(GlobalRepository repository) : base(repository) { }

        public override object Get(int? id)
        {
            return Get(id, "Publishers", false);
        }

        public override object Get(string keyword)
        {
            dataTable = new DataTable();
            string query = @"SELECT * FROM Publishers WHERE [Name] LIKE CONCAT('%', @Keyword, '%')";

            command = new SqlCommand(query, Global.Connection);
            SqlParameter par1 = new SqlParameter("@Keyword", SqlDbType.NVarChar);
            par1.Value = keyword;
            command.Parameters.Add(par1);

            adapter = new SqlDataAdapter(command);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public override object GetAll()
        {
            return GetAll("Publishers");
        }

        public override void Add(object obj)
        {
            Publisher? publisher = obj as Publisher;
            if (publisher == null) { return; }

            Global.Connection.Open();
            string query = @"INSERT INTO Publishers([Name])
VALUES (@Name);";
            SqlCommand command = new SqlCommand(query, Global.Connection);

            SqlParameter par1 = new SqlParameter("@Name", SqlDbType.NVarChar);
            par1.Value = publisher.Name;
            command.Parameters.Add(par1);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally
            {
                Global.Connection.Close();
            }
        }

        public override void Delete(int id)
        {
            Delete(id, "Publishers");
        }
    }
}
