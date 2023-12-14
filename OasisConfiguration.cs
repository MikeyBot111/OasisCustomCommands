using Rocket.API;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OasisCustomCommands
{
    public sealed class TextCommand
    {
        public string Name;
        public string Help;
        public bool SendToBrowser;
        public string BrowserUrl;
        [XmlArrayItem("Line")]
        public List<string> Text;
    }





    public class OasisConfiguration : IRocketPluginConfiguration
    {

        #region Declarations

        [XmlArrayItem("TextCommand")]
        [XmlArray(ElementName = "TextCommands")]
        public List<TextCommand> TextCommands;

        #endregion

        #region DefaultLoad

        public void LoadDefaults()
        {
            TextCommands = new List<TextCommand>(){
                new TextCommand(){Name="rules",Help="Shows the server rules",SendToBrowser=false,BrowserUrl="",Text = new List<string>(){
                    "#1 No offensive content in the chat, respect other players",
                    "#2 No bug using, exploiting or abuse of powers",
                    "#3 Don't ask admins for items, teleports, loot respawn, ect.",
                    "#4 Please speak english in the public chat"}
                }
            };
        }

        #endregion
    }
}
