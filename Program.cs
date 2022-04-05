using System;

namespace networking
{
    class Program
    {
        public static void DataReceived(object sender, Network.DataReceivedEventArgs e)
        {
            Console.WriteLine($"{e.RemoteIP.Address} : {e.Message}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Network network = new();
            network.OnDataReceived += new Network.DataReceivedHandler(DataReceived);
            network.Start("127.0.0.1", 8001);
            //override exists
            //network.Start("127.0.0.1", 8001, 8002); //it allows to listen on a different port
            network.Send("SUffffKA");
            network.Stop();
            return;
        }
    }
}
