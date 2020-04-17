using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using outsource_onderdeel.Models.ViewModels;

namespace outsource_onderdeel.Dataset.DataContext
{
    public interface IUserContext
    {
        public UserViewModel InsertUserLocationByID(long UId, long LId);
        public int GetCurrentUserLocation(long UserId);
    }
}
