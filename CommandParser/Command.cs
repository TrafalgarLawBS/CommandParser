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
        private int distance;
        private String direction;

        public int Distance {
            get { return distance; }
            set { distance = value; }
        }

        public String Direction {
            get { return direction; }
            set { direction = value; }
        }

        public Command(String dir , int dis) {
            Direction = dir;
            Distance = dis;
        }

        public override String ToString() {
            return "Direction: " + Direction + " , Distance: " + Distance.ToString();
        }
    }
}
