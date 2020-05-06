using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace outsource_onderdeel.Models
{
    public class User
    {
        public int Id { get; private set; }
        public int LocationId { get; private set; }
        public string FirstName {get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public string Profile { get; private set; }
        public string UserFunction { get; private set; }
        public bool Findable { get; private set; }

        public User(int givenId, int givenLocationId, string givenfn, string givenln, string givenEmail, string givenProfile, string givenuf, bool givenFindable)
        {
            this.Id = givenId;
            this.LocationId = givenLocationId;
            this.FirstName = givenfn;
            this.LastName = givenln;
            this.Email = givenEmail;
            this.Profile = givenProfile;
            this.UserFunction = givenuf;
            this.Findable = givenFindable;
        }
        public void SetLocation(int givenId)
        {
            this.LocationId = givenId;
        }

        public void ShowLocation()
        {

        }
    }
}
