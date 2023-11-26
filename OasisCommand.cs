using Rocket.API;
using Rocket.Unturned.Chat;
using System.Collections.Generic;


namespace OasisCustomCommands
{
    public class OasisCommand : IRocketCommand
    {
        #region CommandDefault

        public List<string> Permissions => new List<string>();
        public AllowedCaller AllowedCaller => AllowedCaller.Both;
        public string Name => name;
        public string Syntax => "";
        public string Help => help;
        public List<string> Aliases => new List<string>();

        #endregion

        #region Declarations

        private List<string> text;
        private string name;
        private string help;

        public OasisCommand(string commandName, string commandHelp, List<string> text)
        {
            name = commandName;
            help = commandHelp;
            this.text = text;
        }

        #endregion

        #region Execute

        public void Execute(IRocketPlayer caller, string[] command)
        {
            foreach (string l in text)
            {
                UnturnedChat.Say(caller, l);
            }
        }

        #endregion

    }
}