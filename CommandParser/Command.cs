using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParser
{
    //Contains the drone commands    
    public class Command
    {
        public int Distance { get; set; }

        public string Direction { get; set; }

        public Command(string dir , int dis) {
            Direction = dir;
            Distance = dis;
        }

        public override string ToString() {
            return "Direction: " + Direction + " , Distance: " + Distance.ToString();
        }
    }
}
