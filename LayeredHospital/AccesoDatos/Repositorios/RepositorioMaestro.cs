using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AccesoDatos.Repositorios
{
    public abstract class RepositorioMaestro: Repositorio
    {
        protected List<SqlParameter> parameters;

        protected int ExecuteNonQuery(string transactSql) {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var commmand = new SqlCommand())
                {
                    commmand.Connection = connection;
                    commmand.CommandText = transactSql;
                    commmand.CommandType = CommandType.Text;
                    foreach (SqlParameter item in parameters)
                    {
                        commmand.Parameters.Add(item);
                    }
                    int result = commmand.ExecuteNonQuery();
                    parameters.Clear();
                    return result;
                }
            }
        }
        protected DataTable ExecuteReader(string transactSql) {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var commmand = new SqlCommand())
                {
                    commmand.Connection = connection;
                    commmand.CommandText = transactSql;
                    commmand.CommandType = CommandType.Text;
                    SqlDataReader reader = commmand.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }
                }
            }
        }
    }
}
