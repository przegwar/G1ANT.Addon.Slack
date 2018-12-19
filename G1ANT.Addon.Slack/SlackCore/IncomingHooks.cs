using Nancy;
using Nancy.Hosting.Self;
using ServiceStack.Text;
using Slack.Webhooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1ANT.Addon.Slack
{
    static class IncomingHooks
    {
        static NancyHost host;
        public static void InitializeSlackIncomingHooks(string hostUrl)
        {
            JsConfig.EmitLowercaseUnderscoreNames = true;
            JsConfig.IncludeNullValues = false;
            JsConfig.PropertyConvention = PropertyConvention.Lenient;
            /*var hostConfigs = new HostConfiguration
            {
                UrlReservations = new UrlReservations() { CreateAutomatically = true }
            };*/
            var config = new HostConfiguration()
            {
                RewriteLocalhost = false,
                UrlReservations = new UrlReservations()
                {
                    CreateAutomatically = true
                }
            };

            host = new NancyHost(config, new Uri("http://localhost:8080"));
            //{
                host.Start();
                
                //Console.ReadKey();
                
            //}
        }

        public static void StopHost()
        {
            host.Stop();
        }

    }
}
