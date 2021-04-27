using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Class7
    {
        public static void Main()
        {
            int x = 1;
            int y;
            try
            {
                y = x / 0;
                Console.WriteLine(y);
            }
            catch
            {
                Console.WriteLine("Some error have occured");
            }
            Console.ReadLine();
        }
    }
}
