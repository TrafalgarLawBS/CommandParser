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

        private Command Left { get; set; }
        private Command Right { get; set; }
        private Command Up { get; set; }
        private Command Down { get; set; }

        private String StringToParse { get; set; }

        public static void DoTheMagic(String command) {

            var charsToRemove = new string[] { "(", ")", " ", "."};

            foreach (var c in charsToRemove)
            {
                command = command.Replace(c, string.Empty);
            }

            String[] listOfCommands = command.Split(',');

            foreach (var substring in listOfCommands)
                Console.WriteLine(substring);
        }

    }
}
