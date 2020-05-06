using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using outsource_onderdeel.Models.ViewModels;

namespace outsource_onderdeel.Dataset
{
    public static class DataSetParser
    {
        public static LocationViewModel DataSetToLocation(DataTable set)
        {
            return new LocationViewModel()
            {
                ID = Convert.ToInt32(set.Rows[0][0]),
                Building = set.Rows[0][1].ToString(),
                Floor = set.Rows[0][2].ToString(),
                Room = set.Rows[0][3].ToString(),
            };
        }


        public static UserViewModel DataSetToUser(DataTable set)
        {
            return new UserViewModel()
            {
                ID = Convert.ToInt32(set.Rows[0][0]),
                Location_ID = Convert.ToInt32(set.Rows[0][1]),
                FirstName = set.Rows[0][2].ToString(),
                LastName = set.Rows[0][3].ToString(),
                Email = set.Rows[0][4].ToString(),
                Profile = set.Rows[0][5].ToString(),
                UserFunction = set.Rows[0][6].ToString(),
                Findable = Convert.ToBoolean(set.Rows[0][7]),
                Password = set.Rows[0][8].ToString(),
                Salt = set.Rows[0][9].ToString(),
            };
        }
    }
}
