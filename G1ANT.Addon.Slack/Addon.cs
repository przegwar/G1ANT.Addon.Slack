using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using G1ANT.Language;


namespace G1ANT.Addon.Slack
{
    /*public static class Program
    {
        static void Main(string[] args)
        {
            IncomingHooks.InitializeSlackIncomingHooks("http://localhost:8080");
        }
    }*/

    [Addon(Name = "slack", Tooltip = "This addon is integrating slack API with ROBOT.")]
    [Copyright(Author = "G1ANT LTD", Copyright = "G1ANT LTD", Email = "support@g1ant.com", Website = "www.g1ant.com")]
    [License(Type = "LGPL", ResourceName = "License.txt")]
    [CommandGroup(Name = "slack", Tooltip = "Use this command to send or receive slack messages.")]
    public class Addon : Language.Addon
    {

        public override void Check()
        {
            base.Check();
            // Check integrity of your Addon
            // Throw exception if this Addon needs something that doesn't exists
        }

        public override void LoadDlls()
        {
            base.LoadDlls();
            // All dlls embeded in resources will be loaded automatically,
            // but you can load here some additional dlls:

            // Assembly.Load("...")
        }

        public override void Initialize()
        {
            base.Initialize();
            // Insert some code here to initialize Addon's objects
        }

        public override void Dispose()
        {
            base.Dispose();
            // Insert some code here which will dispose all unecessary objects when this Addon will be unloaded
        }
    }
}