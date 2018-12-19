using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;

using G1ANT.Language;
using Slack.Webhooks;

namespace G1ANT.Addon.Slack
{
    [Command(Name = "slack.stophost", Tooltip = "Initialize connection to your Slack workspace.")]
    public class InitializeBotCommand : Command
    {

        public InitializeBotCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(ArgumentsBase arguments)
        {
            IncomingHooks.StopHost();
        }
    }
}