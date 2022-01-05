using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public static class SqlHelper
    {
        public static SqlParameter SqlParameter(string parameterName, SqlDbType dbType, object value)
        {
            SqlParameter par = new SqlParameter(parameterName, dbType);
            par.Value = value;
            return par;
        }

        public static SqlCommand SqlCommand(string cmdText, SqlConnection connection, params SqlParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(cmdText, connection);
            foreach (var item in parameters)
            {
                command.Parameters.Add(item);
            }
            return command;
        }
    }
}
