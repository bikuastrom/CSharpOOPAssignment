using static System.Console;

namespace Exercise3
{
    internal class Program
    {
        static void TestDrive(IDriveable v1)
        {
            v1.StartEngine();
            v1.Gas();
            v1.TurnLeft();
            v1.TurnRight();
            v1.TurnRight();
            v1.Break();
            v1.StopEngine();
        }
        static void Main(string[] args)
        {
            Car c1 = new Car(60);
            Bus b1 = new Bus(60);
            Motorbike m1 = new Motorbike(60);

            TestDrive(c1);
            WriteLine();
            TestDrive(b1);
            WriteLine();
            TestDrive(m1);
        }
    }
}
