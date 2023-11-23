using Rocket.API.Collections;
using Rocket.Core;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using System.Collections.Generic;

namespace OasisCustomCommands
{
    public class OasisPlugin : RocketPlugin<OasisConfiguration>
    {
        public static string version = "1.0.0.1";
        public static OasisPlugin Instance;

        private List<OasisCommand> commands = new List<OasisCommand>();

        protected override void Load()
        {
            OasisPlugin.Instance = this;

            Logger.Log("OasisCustomCommands, Version " + OasisPlugin.version);
            Logger.Log("Checking errors... ");
            if (Configuration != null && Configuration.Instance.TextCommands != null)
            {
                foreach (TextCommand t in Configuration.Instance.TextCommands)
                {
                    OasisCommand command = new OasisCommand(t.Name, t.Help, t.Text);
                    commands.Add(command);
                    R.Commands.Register(command);
                }
            }
            Logger.Log("CustomCommands...OK ");
            Logger.Log("No errors have been found!");
        }

        protected override void Unload()
        {
            foreach (OasisCommand command in commands)
            {
                R.Commands.DeregisterFromAssembly(this.Assembly);
            }
            commands.Clear();
        }

    }
}

