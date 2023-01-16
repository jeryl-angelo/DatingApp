using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Shared.Domain
{
    public class Match: BaseDomainModel
    {
        public int MatchId { get; set; }
        public DateTime DateMatched { get; set; }
        public int MatcheeID { get; set; }
        public int MatcherID { get; set; }
        public virtual User User { get; set; }


    }
}
