using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParser
{
    public class Program
    {
        static void Main(string[] args)
        {

            String s = "l50,r43,u87,d23";
            Parser p1 = new Parser(s);

            List<Command> commands = p1.parseCommandString();

            foreach (Command c in commands) {
                Console.WriteLine(c.ToString());
            }
            Console.WriteLine();
            Console.ReadLine();
            
        }
    }
}
