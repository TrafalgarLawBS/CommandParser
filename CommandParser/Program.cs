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
            Parser.DoTheMagic("(l12,r43,u123,d21)");
            Console.ReadLine();
        }
    }
}
