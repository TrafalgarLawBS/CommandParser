using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandParser
{
    class BadCommand
    {
        public string Command { get; set; }

        public string Message { get; set; }

        public BadCommand(string cmd, string mess) {
            Command = cmd;
            Message = mess;
        }

        public override string ToString()
        {
            return "Command : " + Command.ToString() + " Message: " + Message;
        }
    }
}
