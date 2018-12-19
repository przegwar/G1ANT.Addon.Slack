using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;

using G1ANT.Language;
using Slack.Webhooks;

namespace G1ANT.Addon.Slack
{
    [Command(Name = "slack.initialize", Tooltip = "Initialize connection to your Slack workspace.")]
    public class InitializeCommand : Command
    {
        public class Arguments : CommandArguments
        {
            // Enter all arguments you need
            [Argument(Required = true, Tooltip = "Provide your workspace webhook url.")]
            public TextStructure Webhook { get; set; } = new TextStructure("");
        }

        public InitializeCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            OutgoingHooks.InitializeSlack(arguments.Webhook.Value);
        }
    }
}