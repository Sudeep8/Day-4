using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class stock
    {
        public int stocks;
        public int inventory_AS;
        public int addstock;
    }
    public class Product : stock
    {
        public string p_name;
        public double price;
        public int quantity;
        public double total;
        public static void Main()
        {
            Product soap = new Product();
            soap.total = soap.price * soap.quantity;
            Console.WriteLine("enter the product name");
            soap.p_name = Console.ReadLine();
            Console.WriteLine("enter the quantity");
            soap.quantity = Convert.ToInt32(Console.ReadLine());
            soap.total = (soap.price) * (soap.quantity);
            Console.WriteLine("enter the price");
            soap.price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the stocks available");
            soap.stocks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the amount of newly added stocks");
            soap.addstock = Convert.ToInt32(Console.ReadLine());
            soap.stocks = soap.stocks + soap.addstock;
            soap.inventory_AS = soap.stocks - soap.quantity;
            soap.total = soap.quantity * soap.price;



            Console.WriteLine("s.no            : " + "1");
            Console.WriteLine("product         : " + soap.p_name + "   ");
            Console.WriteLine("price           : " + soap.price + "  ");
            Console.WriteLine("quantity        : " + soap.quantity + " ");
            Console.WriteLine("total price     : " + soap.total + "   ");
            Console.WriteLine("remaining stocks: " + soap.inventory_AS);

        }

    }
}
