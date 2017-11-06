using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParser
{
    //Contains the parsing logic
    public class Parser
    {
        //parser logic
      
        private String StringToParse { get; set; }

        public Parser() { }

        public Parser(String command) {
            this.StringToParse = command;
        }

        public List<Command> parseCommandString() {

            List<Command> listOfCommands = new List<Command>();

            bool badCommand;

            var charsToRemove = new string[] { "(", ")", " ", "." };

            foreach (var c in charsToRemove)
            {
                StringToParse = StringToParse.Replace(c, string.Empty);
            }

            String[] separatedCommands = StringToParse.Split(',');

            foreach (var substring in separatedCommands) {
                String dir = substring[0].ToString();
                int dis = Int32.Parse(substring.Substring(1));


                if (dir.Equals("l"))
                    dir = "left";
                else if (dir.Equals("r"))
                    dir = "right";
                else if (dir.Equals("u"))
                    dir = "up";
                else if (dir.Equals("d"))
                    dir = "down";
                else {
                    badCommand = true;
                }

                Command com = new Command(dir, dis);
                listOfCommands.Add(com);

            }

            return listOfCommands;

        }  
    }
}
