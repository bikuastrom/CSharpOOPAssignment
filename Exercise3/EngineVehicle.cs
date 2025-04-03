using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise3
{
    public abstract class EngineVehicle
    {
        public int _fuel;
        public virtual int Fuel
        {
            get { return _fuel; }
            set { _fuel = value; }
        }
        public int _speed;
        public virtual int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public EngineVehicle()
        {
            Fuel = 0;
            Speed = 0;
        }
    }
}
