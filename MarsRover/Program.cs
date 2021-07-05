using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Rover myRover = new Rover(20);
            //Console.WriteLine(myRover.ToString());
            //
            Command[] commands = { new Command("MODE_CHANGE", "LOW_POWER"), new Command("MOVE", 500) };
            Message newMessage = new Message("Test message with one command", commands);
            Rover newRover = new Rover(98382);
        }
    }
}
