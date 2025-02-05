﻿using System;
namespace MarsRover
{
    public class Rover
    {
        public string Mode { get; set; }
        public int Position { get; set; }
        public int GeneratorWatts { get; set; }

        public Rover(int position)
        {
            Position = position;
            Mode = "Normal";
            GeneratorWatts = 110;
        }

        /*public Rover(string mode, int generatorWatts)
        {
            Mode = "Normal";
            GeneratorWatts = 110;
        }*/

        public override string ToString()
        {
            return "Position: " + Position + " - Mode: " + Mode + " - GeneratorWatts: " + GeneratorWatts;
        }

        public void ReceiveMessage(Message message)
        {
            foreach (Command command in message.Commands)
            {
                if (command.CommandType == "MODE_CHANGE")
                {
                    this.Mode = command.NewMode;                    
                }
                else if (command.CommandType == "MOVE")
                {
                    if (this.Mode != "LOW_POWER")
                    {
                        this.Position = command.NewPostion;
                    }
                }
            }
        }
    }
}
