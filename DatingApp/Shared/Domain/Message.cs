using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatingApp.Shared.Domain
{
    public class Message : BaseDomainModel
    {
        public DateTime DateTime { get; set; }

        public string MessageText { get; set; }

        public int ConversationId { get; set; }
        public virtual Conversation Conversation { get; set; }


    }
}
