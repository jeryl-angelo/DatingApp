using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Shared.Domain
{
    public class Conversation : BaseDomainModel
    {
        public int? SenderId { get; set; }
        public virtual User Sender { get; set; }


        public int?  ReceiverId { get; set; }
        public virtual User Receiver { get; set; }




        public DateTime ConversationStart { get; set; }

        public DateTime ConversationEnd { get; set; }
        public virtual List<Complaint> Complaints { get; set; }
        public virtual List<Message> Messages { get; set; }


    }
}
