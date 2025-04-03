using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise1
{
    public class Employee : Person
    {
        public int Salary { get; set; }
        public List<Sale> SalesList { get; set; }

        public Employee(string firstN, string lastN, int age, int inputSalary) : base(firstN, lastN, age)
        {
            FullName = firstN + " " + lastN;
            Salary = inputSalary;
            SalesList = new List<Sale>();
        }

        public override string ToString()
        {
            return $"\nSalesperson: {FullName}\n";
        }
        int GetNumberOfSales()
        {
            int numberOfSales = SalesList.Count();
            return numberOfSales;
        }
        double GetSalesTotal()
        {
            double salesTotal = 0;
            foreach (Sale sale in SalesList)
            {
                salesTotal = salesTotal + sale.Price;
            }
            return salesTotal;
        }
        double GetAverageSale()
        {
            double averageSale = 0;
            foreach (Sale sale in SalesList)
            {
                averageSale = averageSale + sale.Price;
            }
            averageSale = averageSale / SalesList.Count();
            return averageSale;
        }
        public void PrintSalesStatistics()
        {
            WriteLine($"\nFollowing is statistic for {FullName}\nNumber of sales: {GetNumberOfSales()}\nSales total: ${GetSalesTotal()}\nSales average: ${GetAverageSale()}");
        }

        public void PrintSalesList()
        {
            WriteLine($"\nList of sales for {FullName}\n");
            foreach (Sale sale in SalesList)
            {
                WriteLine($"Product: {sale.ProductName}\t${sale.Price}\tBuyer: {sale.BuyerName}");
            }
        }
    }
}
