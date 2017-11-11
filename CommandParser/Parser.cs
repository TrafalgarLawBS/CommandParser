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
      
        public string StringToParse { get; set; }

        public List<string> ListOfInvalidCommands { get; set; }

        public Parser() { }

        public Parser(string command) {
            StringToParse = command;
        }

        public List<Command> parseCommandString() {

            List<Command> listOfCommands = new List<Command>();
            bool badcmd=false;

            var charsToRemove = new string[] { "(", ")", " ", "." };

            foreach (var c in charsToRemove)
            {
                StringToParse = StringToParse.Replace(c, string.Empty);                
            }           

            string[] separatedCommands = StringToParse.Split(',');

            //
            for (int i = 0; i < separatedCommands.Length; i++) {

                StringBuilder sb = new StringBuilder();
                string dir = null;
                badcmd = false;

                for (int j = 0; j < separatedCommands[i].Length; j++) {
                    if (Char.IsLetter(separatedCommands[i][j]) && j == 0)
                    {
                        if (separatedCommands[i][j]=='l')
                            dir = "left";
                        else if (separatedCommands[i][j]=='r')
                            dir = "right";
                        else if (separatedCommands[i][j]=='u')
                            dir = "up";
                        else if (separatedCommands[i][j]=='d')
                            dir = "down";
                        else {
                            BadCommand bc = new BadCommand(separatedCommands[i], "Invalid command for direction");
                            //ListOfInvalidCommands.Add(separatedCommands[i]);
                            Console.WriteLine(bc.ToString());
                            badcmd = true;
                            break;
                        }
                    }
                    else if (Char.IsNumber(separatedCommands[i][j]) && j > 0)
                    {
                        sb.Append(separatedCommands[i][j]);
                    }
                    else {
                        BadCommand bc = new BadCommand(separatedCommands[i], "Invalid distance");
                        //ListOfInvalidCommands.Add(separatedCommands[i]);
                        Console.WriteLine(bc.ToString());
                        badcmd = true;
                        break;
                    }
                }
                if (!badcmd)
                {
                    int dis = Int32.Parse(sb.ToString());
                    Command com = new Command(dir, dis);
                    listOfCommands.Add(com);
                }

            }


            ////
            //foreach (var substring in separatedCommands) {
            //    string dir = substring[0].ToString();
            //    int dis = Int32.Parse(substring.Substring(1));


            //    if (dir.Equals("l"))
            //        dir = "left";
            //    else if (dir.Equals("r"))
            //        dir = "right";
            //    else if (dir.Equals("u"))
            //        dir = "up";
            //    else if (dir.Equals("d"))
            //        dir = "down";
            //    else {
            //        badCommand = true;
            //    }

            //    Command com = new Command(dir, dis);
            //    listOfCommands.Add(com);

            //}

            return listOfCommands;

        }  
    }
}
