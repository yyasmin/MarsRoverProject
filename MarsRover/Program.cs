using System;
using MarsRover.Common.Models;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Rover case1Rover = new Rover("1 2 N");
            string case1output= case1Rover.Move("LMLMLMLMM");
            Console.WriteLine(case1output);

            Rover case2Rover = new Rover("3 3 E");
            string case2output = case2Rover.Move("MMRMMRMRRM");
            Console.WriteLine(case2output);

        }
    }
}
