using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Common.Interfaces
{
    public interface IRover
    {
        public void TurnLeft();
        public void TurnRight();
        public void Forwad();
        public string Move(string instruction);


    }
}
