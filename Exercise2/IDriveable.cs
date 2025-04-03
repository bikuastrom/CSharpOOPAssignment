using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise2
{
    internal interface IDriveable
    {
        string Name { get; set; }
        int VehicleNames {  get; set; }
        int RemainingFuel { get; set; }
        void StartEngine();
        void StopEngine();
        void Gas();
        void Break();
        void TurnLeft();
        void TurnRight();
    }
}
