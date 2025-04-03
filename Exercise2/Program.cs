using static System.Console;

namespace Exercise2
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
            Car c1 = new Car();
            Bus b1 = new Bus();
            Motorbike m1 = new Motorbike();

            TestDrive(c1);
            WriteLine();
            TestDrive(b1);
            WriteLine();
            TestDrive(m1);

            ReadKey();
        }
    }
}
