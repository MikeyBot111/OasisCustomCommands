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
        private bool sendToBrowser;
        private string browserUrl;

        public OasisCommand(string commandName, string commandHelp, bool SendToBrowser, string BrowserUrl, List<string> text)
        {
            name = commandName;
            help = commandHelp;
            this.text = text;
            sendToBrowser = SendToBrowser;
            browserUrl = BrowserUrl;
        }

        #endregion

        #region Execute

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;
            if (sendToBrowser)
            {
                player.Player.sendBrowserRequest(text[0], browserUrl);
                return;
            }
            foreach (string l in text)
            {
                UnturnedChat.Say(caller, l);
            }
        }

        #endregion

    }
}
