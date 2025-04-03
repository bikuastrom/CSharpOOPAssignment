using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise3
{
    internal class Motorbike : EngineVehicle, IDriveable
    {
        public string Name { get; set; }
        public int VehicleSpeed { get; set; }
        public int RemainingFuel { get; set; }
        public override int Fuel { get { return _fuel; } set { _fuel = 40; } }
        public override int Speed { get { return _speed; } set { _speed = 160; } }
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
            if (VehicleSpeed >= Speed)
                WriteLine("Max speed reached, cant go faster");

            else if (RemainingFuel < 5)
                WriteLine("Fuel is too low, cant go faster");

            else
            {
                WriteLine("Motorbike speeds up");

                VehicleSpeed += 50;
                if (VehicleSpeed >= Speed)
                    VehicleSpeed = Speed;
                WriteLine($"Current speed: {VehicleSpeed}km/h");

                RemainingFuel -= 5;
                if(RemainingFuel < 0)
                    RemainingFuel = 0;
                WriteLine($"Remaining Fuel: {RemainingFuel}l");
            }
        }
        public void Break()
        {
            if (VehicleSpeed <= 0)           
                WriteLine("Speed is 0, can't go slower");
            

            else
            {
                WriteLine("Motorbike slows down");

                VehicleSpeed -= 50;
                if(VehicleSpeed < 0)
                    VehicleSpeed = 0;
                WriteLine($"Current speed: {VehicleSpeed}km/h");
            }
        }
        public void TurnLeft()
        {
            WriteLine("Motorbike turns left");
        }
        public void TurnRight()
        {
            WriteLine("Motorbike turns right");
        }

        public Motorbike(int fuel)
        {
            if (fuel <= Fuel)
                RemainingFuel = fuel;

            else
                RemainingFuel = Fuel;
        }
    }
}
