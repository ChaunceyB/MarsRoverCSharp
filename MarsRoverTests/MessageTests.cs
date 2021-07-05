using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;

namespace MarsRoverTests
{
    [TestClass]
    public class MessageTests
    {
        Command[] commands = { new Command("foo", 0), new Command("bar", 20) };

        [TestMethod]
        public void ArgumentNullExceptionThrownIfNameNotPassedToConstructor()
        {
            try
            {
                Message message = new Message("", commands);
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Message name required.", ex.Message);
            }
        }

        [TestMethod]
        public void ConstructorSetsName()
        {
            Command[] commands = { new Command("MODE_CHANGE", "LOW_POWER"), new Command("MOVE", 500) };
            Message newMessage = new Message("testMessage", commands);
            Assert.AreEqual(newMessage.Name, "testMessage");
        }

        [TestMethod]
        public void ConstructorSetsCommandField()
        {
            Command[] commands = { new Command("MODE_CHANGE", "LOW_POWER"), new Command("MOVE", 500) };
            Message newMessage = new Message("testMessage", commands);
            Assert.AreEqual(newMessage.Commands, commands);
        }
    

    }
}
