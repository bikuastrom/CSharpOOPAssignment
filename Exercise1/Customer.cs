using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise1
{
    public class Customer : Person
    {
        public int Spending { get; set; }
        public List<Sale> PurchasesList { get; set; }

        public Customer(string firstN, string lastN, int age, int inputSpending) : base(firstN, lastN, age)
        {
            FullName = firstN + " " + lastN;
            Spending = inputSpending;
            PurchasesList = new List<Sale>();
        }
        public override string ToString()
        {
            return $"\nCustomer: {FullName}";
        }
        int GetNumberOfPurchases()
        {
            int numberOfPurchases = PurchasesList.Count();
            return numberOfPurchases;
        }
        double GetPurchaseTotal()
        {
            double purchaseTotal = 0;
            foreach (Sale sale in PurchasesList)
            {
                purchaseTotal = purchaseTotal + sale.Price;
            }
            return purchaseTotal;
        }
        double GetAveragePurchase()
        {
            double averagePurchase = 0;
            foreach (Sale sale in PurchasesList)
            {
                averagePurchase = averagePurchase + sale.Price;
            }
            averagePurchase = averagePurchase / PurchasesList.Count();
            return averagePurchase;
        }
        public void PrintPurchaseStatistics()
        {
            WriteLine($"\nFollowing is statistic for {FullName}\nNumber of purchases: {GetNumberOfPurchases()}\nPurchase total: ${GetPurchaseTotal()}\nPurchase average: ${GetAveragePurchase()}\n");
            WriteLine($"List of sales\n");
            foreach (Sale sale in PurchasesList)
            {
                WriteLine($"Product: {sale.ProductName}\t${sale.Price}\tSalesperson: {sale.SellerName}");
            }
        }
    }
}
