using Rocket.Core;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using System.Collections.Generic;

namespace OasisCustomCommands
{
    public class OasisPlugin : RocketPlugin<OasisConfiguration>
    {
        #region Default

        public static string version = "1.0.0.4";
        public static OasisPlugin Instance;

        #endregion

        #region PluginSpecific

        private List<OasisCommand> commands = new List<OasisCommand>();

        #endregion

        #region LoadUnload
        protected override void Load()
        {
            #region Check
            OasisPlugin.Instance = this;

            Logger.Log("OasisCustomCommands, Version " + OasisPlugin.version);
            Logger.Log("Checking errors... ");
            Logger.Log(LoadCommands() == true ? "CustomCommands...OK " : "CustomCommands...Error ");
            Logger.Log("No errors have been found!");
            #endregion
        }

        protected override void Unload()
        {
            foreach (OasisCommand command in commands)
            {
                R.Commands.DeregisterFromAssembly(this.Assembly);
            }
            commands.Clear();
        }
        #endregion

        private bool LoadCommands()
        {
            try
            {
                if (Configuration != null && Configuration.Instance.TextCommands != null)
                {
                    foreach (TextCommand t in Configuration.Instance.TextCommands)
                    {
                        OasisCommand command = new OasisCommand(t.Name, t.Help, t.Text);
                        commands.Add(command);
                        R.Commands.Register(command);
                    }
                }
                return true;
            }
            catch { return false; }
        }

    }
}

