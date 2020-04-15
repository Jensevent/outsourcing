using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace outsource_onderdeel.Models.DataModels
{
    public class UserDataModel
    {
        public int ID { get; }
        public int Location_ID { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Email { get; }
        public string Profile { get; }
        public string UserFunction { get; }
        public bool Findable { get; }
        public string Password { get; }
        public string Salt { get; }

        public UserDataModel()
        {

        }
    }
}
