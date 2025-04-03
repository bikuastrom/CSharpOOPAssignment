using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Exercise1
{
    public class Sale
    {
        public string ProductName {  get; set; }
        public double Price { get; set; }
        public Customer Buyer { get; set; }
        public string BuyerName { get; set; }
        public Employee Seller { get; set; }
        public string SellerName { get; set; }
        public DateTime TransactionDate {  get; set; }

        public Sale(string product, double price, Customer buyer, Employee seller)
        {
            ProductName = product;
            Price = price;
            Buyer = buyer;
            BuyerName = buyer.FullName;
            Seller = seller;
            SellerName = seller.FullName;
            TransactionDate = DateTime.Now;
            AddSale();
        }
        public void AddSale()
        {
            Buyer.PurchasesList.Add(this);
            Seller.SalesList.Add(this);
        }
        public override string ToString()
        {
            return $"\nProduct: {ProductName}\t${Price}\nBuyer: {BuyerName}\nSalesperson: {SellerName}\n";
        }
    }
}
