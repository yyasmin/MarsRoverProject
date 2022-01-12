using MarsRover.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Common.Models
{
    public class Rover : IRover
    {
        public int x; // The current x coordinate of rover
        public int y; // The current y coordinate of rover
        public string direction; // The current direction of rover
        public Rover(string input)
        {
           x=Int32.Parse(input.Split(" ")[0]);
           y = Int32.Parse(input.Split(" ")[1]);
           direction = input.Split(" ")[2];
        }
        public void TurnLeft()
        {
            switch (direction)
            {
                case "N":
                     direction = "W";
                     break;
                case "W":
                    direction = "S";
                    break;
                case "S":
                    direction = "E";
                    break;
                case "E":
                    direction = "N";
                    break;
                default:
                    throw new ArgumentException();
            }
        }
        public void TurnRight()
        {
            switch (direction)
            {
                case "N":
                    direction = "E";
                    break;
                case "E":
                    direction = "S";
                    break;
                case "S":
                    direction = "W";
                    break;
                case "W":
                    direction = "N";
                    break;
                default:
                    throw new ArgumentException();
            }

        }
        public void Forwad()
        {
            switch (direction)
            {
                case "N":
                    y += 1;
                    break;
                case "E":
                    x += 1;
                    break;
                case "W":
                    x -= 1;
                    break;
                case "S":
                    y -= 1;
                    break;

                default:
                    throw new ArgumentException();
            }
        }
        public string Move(string instruction)
        {
            char[] instructionArray = instruction.ToCharArray();
            foreach (var item in instructionArray)
            {
                if (item == 'L')
                    TurnLeft();
                if (item == 'R')
                    TurnRight();
                if (item == 'M')
                    Forwad();

            }

            return x.ToString() + " " + y.ToString() + " " + direction;


        }
    }
}
