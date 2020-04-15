using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using outsource_onderdeel.Models.ViewModels;

namespace outsource_onderdeel.Dataset.DataContext.Repositories
{
    public class UserRepo : IUserContext
    {
        private IUserContext Context;

        public UserRepo(IUserContext context)
        {
            Context = context;
        }

        public UserViewModel InsertUserLocationByID(long UId, long LId)
        {
            return Context.InsertUserLocationByID(UId, LId);
        }
    }
}
