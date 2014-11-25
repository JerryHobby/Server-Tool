using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_Tool_Network
{
    public class Network
    {
        public String Server;
        public Int32 Port;
        public Network(String NewServer = "localhost", Int32 NewPort=128)
        {
            Server = NewServer;
            Port = NewPort;

        }
        public String StatusMessage()
        {
            String Message;

            Message = "You are connected to: " + Server;
            return (Message);
        }
    }

}
