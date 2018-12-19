using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;

using G1ANT.Language;
using Slack.Webhooks;

namespace G1ANT.Addon.Slack
{
    [Command(Name = "slack.starthost", Tooltip = "Initialize connection to your Slack workspace.")]
    public class StartHostCommand : Command
    {
        public class Arguments : CommandArguments
        {
            // Enter all arguments you need
            [Argument(Required = true, Tooltip = "Specify at which url and port the bot should run.")]
            public TextStructure HostURL { get; set; } = new TextStructure("");
        }

        public StartHostCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            IncomingHooks.InitializeSlackIncomingHooks(arguments.HostURL.Value);
        }
    }
}