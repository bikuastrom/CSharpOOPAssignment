using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        private static int InstanceCount { get; set; }

        static void IncreaseInstanceCount()
        {
            InstanceCount++;
        }
        public void Speak()
        {
            WriteLine($"\nHello my name is {FullName}\n");
        }

        public override string ToString()
        {
            return "\n" + FullName + " " + Age + "\n";
        }

        public Person(string firstN, string lastN, int age)
        {
            FullName = firstN + " " + lastN;
            FirstName = firstN;
            LastName = lastN;
            Age = age;

            IncreaseInstanceCount();
        }
    }
}
