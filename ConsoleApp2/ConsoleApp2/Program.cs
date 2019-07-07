using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class Program
    {
       
        static int GetGCD (int a, int b)
        {
            int k,c;
            k = a / b;
            while (a - k * b != 0)
            {
                c = a - k * b;
                a = b;
                b = c;
                k = a / b;
            }

            return b;
        }




    }
}
