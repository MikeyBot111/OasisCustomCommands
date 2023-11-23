using Rocket.API;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OasisCustomCommands
{
    public sealed class TextCommand
    {
        public string Name;
        public string Help;
        [XmlArrayItem("Line")]
        public List<string> Text;
    }

    public class OasisConfiguration : IRocketPluginConfiguration
    {


        [XmlArrayItem("TextCommand")]
        [XmlArray(ElementName = "TextCommands")]
        public List<TextCommand> TextCommands;

        public void LoadDefaults()
        {
            TextCommands = new List<TextCommand>(){
                new TextCommand(){Name="rules",Help="Shows the server rules",Text = new List<string>(){
                    "#1 No offensive content in the chat, respect other players",
                    "#2 No bug using, exploiting or abuse of powers",
                    "#3 Don't ask admins for items, teleports, loot respawn, ect.",
                    "#4 Please speak english in the public chat"}
                }
            };
        }
    }
}
