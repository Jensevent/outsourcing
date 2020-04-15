using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using outsource_onderdeel.Models.ViewModels;

namespace outsource_onderdeel.Dataset.DataContext.Repositories
{
    public class LocationRepo : ILocationContext
    {
        ILocationContext Context;

        public LocationRepo(ILocationContext context)
        {
            Context = context;
        }

        //public LocationViewModel GetByID(long ID)
        //{
        //    return Context.GetByID(ID);
        //}
    }
}
