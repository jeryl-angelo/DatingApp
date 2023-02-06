using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Shared.Domain
{
    public class Match: BaseDomainModel
    {
        public DateTime DateMatched { get; set; }


        public int? MatcheeId { get; set; }
        public virtual User Matchee { get; set; }


        public int? MatcherId { get; set; }
        public virtual User Matcher { get; set; }

       
    }
}
