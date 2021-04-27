using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class MyException:ApplicationException
    { 
        public void MyDivideException()
        {
            Console.WriteLine("Exception Occured,divisor should not be zero");
        }
    }
    class Class8
    {
        public static void Main()
        {
            int x = 5, y = 0, z;
            try
            {
                
                if(y==0)
                {
                    throw new MyException();
                }
            }
            catch(MyException ex)
            { 
                ex.MyDivideException();
            }
            Console.ReadLine();
        }
    }
}
