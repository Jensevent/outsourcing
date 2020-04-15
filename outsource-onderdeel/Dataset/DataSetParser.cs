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
        public static LocationViewModel DataSetToLocation(DataTable set, int rowIndex)
        {
            return new LocationViewModel()
            {
                ID = Convert.ToInt32(set.Rows[rowIndex][0]),
                Building = set.Rows[rowIndex][1].ToString(),
                Floor = set.Rows[rowIndex][2].ToString(),
                Room = set.Rows[rowIndex][3].ToString(),
            };
        }

        public static UserViewModel DataSetToUser(DataTable set, int rowIndex)
        {
            return new UserViewModel()
            {
                ID = Convert.ToInt32(set.Rows[rowIndex][0]),
                Location_ID = Convert.ToInt32(set.Rows[rowIndex][1]),
                FirstName = set.Rows[rowIndex][2].ToString(),
                LastName = set.Rows[rowIndex][3].ToString(),
                Email = set.Rows[rowIndex][4].ToString(),
                Profile = set.Rows[rowIndex][5].ToString(),
                UserFunction = set.Rows[rowIndex][6].ToString(),
                Findable = Convert.ToBoolean(set.Rows[rowIndex][7]),
                Password = set.Rows[rowIndex][8].ToString(),
                Salt = set.Rows[rowIndex][9].ToString(),
            };
        }
    }
}
