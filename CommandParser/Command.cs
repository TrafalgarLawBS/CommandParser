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
        private int Distance { get; set; }  // deklaracija + get i set metoda
        private String Direction { get; set; }

        public Command(String direction , int distance) {
            this.Direction = direction;
            this.Distance = distance;
        }

        public void toString() {
            Console.WriteLine(String.Format("Direction: {0}, Distance:{1}",Direction,Distance));
        }
    }
}
