using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1ANT.Addon.Slack
{
    public class HookMessage
    {
        public EventModel Event = new EventModel();
        public string Token { get; set; }
        public string TeamId { get; set; }
        public string APIappID { get; set; }
        public string Type { get; set; }
        public string EventId { get; set; }
        public string EventTime { get; set; }
        public List<string> AuthedUsers { get; set; }
    }
    public class EventModel
    {
        public string ClientMsgId { get; set; }
        public string Type { get; set; }
        public string Text { get; set; }
        public string User { get; set; }
        public string Ts { get; set; }
        public string Channel { get; set; }
        public string EventTs { get; set; }
        public string ChannelType { get; set; }
    }
}
