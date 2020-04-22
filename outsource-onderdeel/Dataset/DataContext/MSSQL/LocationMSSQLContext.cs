using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using outsource_onderdeel.Models.ViewModels;

namespace outsource_onderdeel.Dataset.DataContext.MSSQL
{
    public class LocationMSSQLContext : Databasehandler, ILocationContext
    {
        public LocationViewModel GetByID(long LId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM [Location] WHERE ID = @Location_ID", GetCon());
            command.Parameters.AddWithValue("Location_ID", LId);

            OpenConnectionToDB();

            SqlDataAdapter adapt = new SqlDataAdapter(command);
            table.Clear();
            adapt.Fill(table);
                   
            CloseConnectionToDB();

            LocationViewModel result = DataSetParser.DataSetToLocation(table);

            return result;
        }
    }
}
