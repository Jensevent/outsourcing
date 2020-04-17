using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using outsource_onderdeel.Models.ViewModels;

namespace outsource_onderdeel.Dataset.DataContext.MSSQL
{
    public class LocationMSSQLContext : BaseMSSQLContext, ILocationContext
    {
        public LocationViewModel GetByID(long LocationId)
        {
            string SQL = "SELECT * FROM [Location] WHERE ID = @Location_ID";
            List<KeyValuePair<object, object>> param = new List<KeyValuePair<object, object>>();
            param.Add(new KeyValuePair<object, object>("Location_ID", LocationId));

            DataTable dt = ExecuteQuery(SQL, param);
            LocationViewModel result = DataSetParser.DataSetToLocation(dt, 0);
            return result;
        }
    }
}
