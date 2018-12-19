using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1ANT.Addon.Slack
{
    public class ChallengeMessageRequest
    {
        public string Challenge { get; set; }
        public string Token { get; set; }
        public string Type { get; set; }
    }
}
