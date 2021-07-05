using System;
namespace MarsRover
{
    public class Message
    {
        public string Name { get; set; }
        public Command[] Commands { get; set; }

        public Message(string name, Command[] commands)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(name, "Message name required.");
            }
            Name = name;
            Commands = commands; 
        }

        public Message(string name)
        {
            Name = name;
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(name, "Message name required.");
            }
        }
        
        
    }
}
