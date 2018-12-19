using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;

using G1ANT.Language;
using Slack.Webhooks;

namespace G1ANT.Addon.Slack
{
    [Command(Name = "slack.lastmessage", Tooltip = "Get last message from conversation")]
    public class LastMessageCommand : Command
    {
        public class Arguments : CommandArguments
        {
            // Enter all arguments you need
            [Argument(Tooltip = "Extracted text will be stored here")]
            public VariableStructure Result { get; set; } = new VariableStructure("");
        }

        public LastMessageCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            Scripter.Variables.SetVariableValue(arguments.Result.Value, new Language.TextStructure(SlackConversationContainer.lastMessage));
        }
    }
}