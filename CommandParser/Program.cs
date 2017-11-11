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
            string[] arrayOfCommandsToTest = {
                "l50,r43,u87,d23",//pravilna komanda
                "lx20,r32,d1,u12",
                "22,r3,d11,u32",
                "l10,r22,14,u11",
                "x2z,r32,d1,u12",
                "l24,r35,dx11y,u16",
                "l20,rr32,d1,uu12",
                "lx20,r32,d1,tu12" };
           

            Parser p1= new Parser();

            foreach (string s in arrayOfCommandsToTest)
            {
                Console.WriteLine("Command: "+s);
                p1.StringToParse = s;
                List<Command> commands = p1.parseCommandString();              

                foreach (Command c in commands)
                {
                    Console.WriteLine(c.ToString());
                }
                Console.WriteLine();
            }            
            
            Console.ReadLine();
            
        }
    }
}
