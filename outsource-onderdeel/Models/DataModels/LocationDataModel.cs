using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace outsource_onderdeel.Models.DataModels
{
    public class LocationDataModel
    {
        public int ID { get; }
        public string Building { get; }
        public string Floor { get; }
        public string Room { get; }

        public LocationDataModel()
        {

        }
    }
}
