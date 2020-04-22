using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using outsource_onderdeel.Models;
using outsource_onderdeel.Models.ViewModels;

namespace outsource_onderdeel.Dataset.DataContext.MSSQL
{
    public class UserMSSQLContext : Databasehandler, IUserContext
    {
        public UserViewModel InsertUserLocationByID(long UId, long LId)
        {
            SqlCommand UpdateLocation = new SqlCommand("UPDATE [User] SET Location_ID = @Location_ID WHERE ID = @User_ID", GetCon());
            UpdateLocation.Parameters.AddWithValue("Location_ID", LId);
            UpdateLocation.Parameters.AddWithValue("User_ID", UId);

            SqlCommand GetUserData = new SqlCommand("SELECT * FROM [User] WHERE ID = @User_ID", GetCon());
            GetUserData.Parameters.AddWithValue("User_ID", UId);

            OpenConnectionToDB();

            UpdateLocation.ExecuteNonQuery();

            SqlDataAdapter adapt = new SqlDataAdapter(GetUserData);
            table.Clear();
            adapt.Fill(table);

            CloseConnectionToDB();

            UserViewModel User = DataSetParser.DataSetToUser(table);

            return User;
        }


        public int GetCurrentUserLocation(long UserId)
        {
            SqlCommand cmd = new SqlCommand("SELECT Location_ID FROM [User] WHERE ID = @User_ID", GetCon());
            cmd.Parameters.AddWithValue("User_ID", UserId);

            OpenConnectionToDB();

            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            table.Clear();
            adapt.Fill(table);

            CloseConnectionToDB();

            int location = Convert.ToInt32(table.Rows[0][0]);
            return location;
        }
    }
}
