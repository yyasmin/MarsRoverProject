using NUnit.Framework;
using MarsRover.Common.Models;
namespace MarsRoverNUnitTestProject
{
    public class RoverTest
    {
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TurnLeft()
        {

            Rover Rover = new Rover("3 5 S");
            Rover.TurnLeft();
            Assert.IsTrue(Rover.direction == "E");
        }
        [Test]
        public void TurnRight()
        {

            Rover Rover = new Rover("2 1 W");
            Rover.TurnRight();
            Assert.IsTrue(Rover.direction == "N");
        }
        [Test]
        public void Forwad()
        {
            Rover Rover = new Rover("1 2 N");
            Rover.Forwad();
            Assert.AreEqual(3,Rover.y);
        }
        [Test]
        public void Move()
        {
            Rover Rover = new Rover("1 2 N");
            Rover.Move("LMLMLMLMM");
            Assert.AreEqual("1 3 N", Rover.x + " " +Rover.y+ " " +Rover.direction);
        }
    }
}