using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using outsource_onderdeel.Models;
using outsource_onderdeel.Models.ViewModels;

namespace outsource_onderdeel.Dataset.DataContext.MSSQL
{
    public class UserMSSQLContext : BaseMSSQLContext, IUserContext
    {
        public UserViewModel InsertUserLocationByID(long UId, long LId)
        {
            string SQL = "UPDATE [User] SET Location_ID = @Location_ID WHERE ID = @User_ID";
            string SQLreturn = "SELECT * FROM [User] WHERE ID = @User_ID";
            List<KeyValuePair<object, object>> parameters = new List<KeyValuePair<object, object>>();

            parameters.Add(new KeyValuePair<object, object>("Location_ID", LId));
            parameters.Add(new KeyValuePair<object, object>("User_ID", UId));

            ExecuteQuery(SQL, parameters);
            List<KeyValuePair<object, object>> parameter = new List<KeyValuePair<object, object>>();
            parameter.Add(new KeyValuePair<object, object>("User_ID", UId));
            DataTable Result = ExecuteQuery(SQLreturn, parameter);
            UserViewModel User = DataSetParser.DataSetToUser(Result, 0);

            return User;
        }

        public int GetCurrentUserLocation(long UserId)
        {
            string SQL = "SELECT Location_ID FROM [User] WHERE ID = @User_ID";
            List<KeyValuePair<object, object>> param = new List<KeyValuePair<object, object>>();
            param.Add(new KeyValuePair<object, object>("User_ID", UserId));

            DataTable dt = ExecuteQuery(SQL, param);
            int result = Convert.ToInt32(dt.Rows[0][0]);
            return result;
        }
    }
}
