using System;
using System.Collections.Generic;
using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTests
{
    [TestClass]
    public class RoverTests
    {
        [TestMethod]
        public void ConstructorSetsDefaultPositon()
        {
            Rover rover1  = new Rover(2500);
            Assert.AreEqual(rover1.Position, 2500);
        }

        [TestMethod]
        public void ConstructorSetsDefaultMethod()
        {
            Rover rover1 = new Rover(/*"Normal",*/ 500);
            Assert.AreEqual("Normal", rover1.Mode);
        }

        [TestMethod]
        public void ConstructorSetsDefaultGeneratorWatts()
        {
            Rover rover1 = new Rover(/*"Normal",*/ 500);
            Assert.AreEqual(110, rover1.GeneratorWatts);
        }

        [TestMethod]
        public void RespondsCorrectlyToModeChangeCommand()
        {
            Command[] commands = { new Command("MODE_CHANGE", "LOW_POWER") };
            Message newMessage = new Message("Rover1", commands);
            Rover rover1 = new Rover(/*"Normal",*/ 500);
            rover1.ReceiveMessage(newMessage);
            Assert.AreEqual("LOW_POWER", rover1.Mode);
        }

        [TestMethod]
        public void DoesNotMoveInLowPower()
        {
            Command[] commands = { new Command("MODE_CHANGE", "LOW_POWER"), new Command("MOVE", 25000) };
            Message newMessage = new Message("Rover1", commands);
            Rover rover1 = new Rover(/*"LOW_POWER",*/ 500);
            rover1.ReceiveMessage(newMessage);
            Assert.AreEqual(500, rover1.Position);
        }

        [TestMethod]
        public void PositionChangesFromMoveCommand()
        {
           Command[] commands = { new Command("MOVE", 25000) };
           Message newMessage = new Message("Rover1", commands);
           Rover rover1 = new Rover(500);
           rover1.ReceiveMessage(newMessage);
            int expectedRoverPosition = 25000;
            int actualRoverPosition = rover1.Position;
            //Assert.AreEqual(expectedRoverPosition, actualRoverPosition);
            Assert.AreEqual(expectedRoverPosition, actualRoverPosition);

            
               

          
        }
    }
}
