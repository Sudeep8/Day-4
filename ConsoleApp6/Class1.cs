using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Product
    {
        public int Quantity { get; set; }
        string ProductName { get; set; }
        public int Price { get; set; }
        public void Inputvalues()
        {
            Console.WriteLine("Enter Quantity ");
            Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Name");
            ProductName = Console.ReadLine();
            Console.WriteLine("Enter Price ");
            Price = Convert.ToInt32(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Quantity :" + Quantity);
            Console.WriteLine("Product Name :" + ProductName);
            Console.WriteLine("Price for 1 piece :" + Price);
            Console.WriteLine("Total Price :" + (Price*Quantity));
        }
        public static void Main()
        {
            Product pro = new Product();
            pro.Inputvalues();
            pro.DisplayDetails();
            Console.ReadLine();
        }
    }
}

