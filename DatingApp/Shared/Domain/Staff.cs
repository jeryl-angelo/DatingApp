using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Shared.Domain
{
    public class Staff: BaseDomainModel
    {
        public string StaffName { get; set; }
        public string Email { get; set; }

        public int Age { get; set; }
        public int  ContactNum { get; set; }
        public string StaffLocation { get; set; }

    }
}
