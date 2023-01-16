using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Shared.Domain
{
    public class User: BaseDomainModel
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Pronouns { get; set; }
        public string Gender { get; set; }
        public string GenderPreference { get; set; }

        public string AgePreference { get; set; }
        public int ContactNum { get; set; }

        public string Location { get; set; }

        


    }
}
