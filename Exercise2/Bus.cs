using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise2
{
    internal class Bus : IDriveable
    {
        public string Name { get; set; }
        public int VehicleNames { get; set; }
        public int RemainingFuel { get; set; }
        public void StartEngine()
        {
            WriteLine("Bus engine starts");
        }
        public void StopEngine()
        {

            WriteLine("Bus engine stops");
        }
        public void Gas()
        {

            WriteLine("Bus speeds up");
        }
        public void Break()
        {

            WriteLine("Bus slows down");
        }
        public void TurnLeft()
        {

            WriteLine("Bus turns left");
        }
        public void TurnRight()
        {

            WriteLine("Bus turns right");
        }
    }
}
