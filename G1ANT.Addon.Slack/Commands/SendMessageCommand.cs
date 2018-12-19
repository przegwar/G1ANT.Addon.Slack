using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;

using G1ANT.Language;
using Slack.Webhooks;

namespace G1ANT.Addon.Slack
{
    [Command(Name = "slack.sendmessage", Tooltip = "Send message to slack.")]
    public class SendMessageCommand : Command
    {
        public class Arguments : CommandArguments
        {
            // Enter all arguments you need
            [Argument(Required = true, Tooltip = "Text of message.")]
            public TextStructure Text { get; set; } = new TextStructure("");

            [Argument(Required = true, Tooltip = "To which channel should the message be sent.")]
            public TextStructure Channel { get; set; } = new TextStructure("");

            [Argument(Tooltip = "Define custom user name.")]
            public TextStructure UserName { get; set; } = new TextStructure("ROBOT");
    }

        public SendMessageCommand(AbstractScripter scripter) :
            base(scripter)
        {
        }

        // Implement this method
        public void Execute(Arguments arguments)
        {
            var slackMessage = new SlackMessage
            {
                Channel = arguments.Channel.Value,
                Text = arguments.Text.Value,
                Username = arguments.UserName.Value
            };
            OutgoingHooks.SendMessage(slackMessage);

        }
    }
}