using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string UsersEndpoint = $"{Prefix}/users";
        public static readonly string MatchesEndpoint = $"{Prefix}/matches";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
        public static readonly string ComplaintsEndpoint = $"{Prefix}/complaints";
        public static readonly string ConversationsEndpoint = $"{Prefix}/conversations";
        public static readonly string MessagesEndpoint = $"{Prefix}/messages";

    }
}
