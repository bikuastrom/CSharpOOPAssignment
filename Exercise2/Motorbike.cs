using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise2
{
    internal class Motorbike : IDriveable
    {
        public string Name { get; set; }
        public int VehicleNames { get; set; }
        public int RemainingFuel { get; set; }
        public void StartEngine()
        {
            WriteLine("Motorbike engine starts");
        }
        public void StopEngine()
        {

            WriteLine("Motorbike engine stops");
        }
        public void Gas()
        {

            WriteLine("Motorbike speeds up");
        }
        public void Break()
        {

            WriteLine("Motorbike slows down");
        }
        public void TurnLeft()
        {

            WriteLine("Motorbike turns left");
        }
        public void TurnRight()
        {

            WriteLine("Motorbike turns right");
        }
    }
}
