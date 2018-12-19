using Slack.Webhooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1ANT.Addon.Slack
{
    static class OutgoingHooks
    {
        static SlackClient slackClient;

        public static void InitializeSlack(string token)
        {
            slackClient = new SlackClient(token);
        }

        public static void SendMessage(SlackMessage slackMessage)
        {
            if (slackClient != null)
            {
                slackClient.Post(slackMessage);
            }
            else
            {
                throw new ArgumentNullException("Slack has not been initialize. Please use slack.initialize first.");
            }
        }

    }
}
