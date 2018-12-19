using Nancy;
using Nancy.ModelBinding;
using ServiceStack;
using Slack.Webhooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1ANT.Addon.Slack
{
    public class WebhookModule : NancyModule
    {
        class TypeModel
        {
            public string Type { get; set; }
        }
        public WebhookModule()
        {
            Get["/home"] = _ =>
            {
                return "home";
            };
            Post["/message"] = x =>
            {
                var type = this.Bind<TypeModel>().Type;

                switch (type)
                {
                    case "url_verification":
                        {
                            var model = this.Bind<ChallengeMessageRequest>();
                            return new ChallengeMessage() { Challenge = model.Challenge };
                        }
                    case "event_callback":
                        {
                            var model = this.Bind<HookMessage>();
                            //var message = string.Empty;
                            /*if (model.Event.Text.ToLower().StartsWith("testbot: hello"))
                            {
                                message = string.Format("@{0} Hello", "ROBOT");
                            }*/
                            SlackConversationContainer.lastMessage = model.Event.Text.ToLower();
                            return null;
                        }
                    default:
                        throw new NotImplementedException($"This type of event {type} is not implemented.");


                }    
            };

        }


        

        public class TitleCaseFieldNameConverter : IFieldNameConverter
        {
            public string Convert(string fieldName)
            {
                return fieldName.ToTitleCase();
            }
        }

        public class Bootstrapper : DefaultNancyBootstrapper
        {
            protected override void ApplicationStartup(Nancy.TinyIoc.TinyIoCContainer container, Nancy.Bootstrapper.IPipelines pipelines)
            {
                container.Register<IFieldNameConverter, TitleCaseFieldNameConverter>();
                base.ApplicationStartup(container, pipelines);
            }
        }
    }





}
