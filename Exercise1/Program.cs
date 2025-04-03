using static System.Console;

namespace Exercise1
{
    internal class Program
    {
        static void PrintPerson(Person p1)
        {
            WriteLine(p1);
        }

        static void Main(string[] args)
        {
            Person personObject = new Person("Izzy" , "Hands", 16);
            Employee employeeObject = new Employee("Lucius", "Spriggs", 19, 5000);
            Customer customerObject = new Customer("Stede", "Bonnet", 25, 30000);
            Sale saleObject = new Sale("book",60,customerObject, employeeObject);
            Sale sale2 = new Sale("ship",3000,customerObject, employeeObject);

            WriteLine(personObject);
            PrintPerson(employeeObject);
            PrintPerson(customerObject);
            WriteLine(saleObject);
            WriteLine(sale2);
            employeeObject.PrintSalesStatistics();
            employeeObject.PrintSalesList();
            customerObject.PrintPurchaseStatistics();

            ReadKey();
        }
    }
}
