using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace outsource_onderdeel.Dataset
{
    public class BaseMSSQLContext
    {
        public string connstring = "Server = mssql.fhict.local; Database=dbi440671_outsource;User Id = dbi440671_outsource; Password=#d2H49Mkj/yZF";

        public BaseMSSQLContext()
        {

        }

        public DataTable ExecuteQuery(string query, List<KeyValuePair<object, object>> parameters)
        {
            DataTable set = new DataTable();
            try
            {
                SqlConnection conn = new SqlConnection(connstring);
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = conn.CreateCommand();

                foreach (KeyValuePair<object, object> keyvaluepair in parameters)
                {
                    SqlParameter parameter = new SqlParameter();
                    parameter.ParameterName = "@" + keyvaluepair.Key;
                    parameter.Value = keyvaluepair.Value;
                    command.Parameters.Add(parameter);
                }
                command.CommandText = query;
                adapter.SelectCommand = command;

                conn.Open();
                adapter.Fill(set);
                conn.Close();
                return set;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
