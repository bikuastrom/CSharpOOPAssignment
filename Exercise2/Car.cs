using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise2
{
    internal class Car : IDriveable
    {
        public string Name { get; set; }
        public int VehicleNames { get; set; }
        public int RemainingFuel { get; set; }
        public void StartEngine()
        {
            WriteLine("Car engine starts");
        }
        public void StopEngine()
        {

            WriteLine("Car engine stops");
        }
        public void Gas()
        {

            WriteLine("Car speeds up");
        }
        public void Break()
        {

            WriteLine("Car slows down");
        }
        public void TurnLeft()
        {

            WriteLine("Car turns left");
        }
        public void TurnRight()
        {

            WriteLine("Car turns right");
        }
    }
}
