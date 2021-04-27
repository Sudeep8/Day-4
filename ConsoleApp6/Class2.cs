using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class Class2
    {
       
        public static void Main()
        {
            AssemblyClass assemblyClass = new AssemblyClass();
            Console.WriteLine(assemblyClass.Sum(1, 2));
            Console.WriteLine(assemblyClass.Dif(3, 2));
            Console.WriteLine(assemblyClass.Mul(1, 2));
            Console.WriteLine(assemblyClass.Div(8, 4));
            Console.ReadLine();
        }
    }
}
