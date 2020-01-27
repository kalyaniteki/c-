using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            float l2 = 9.2f;
            int i2 = (int)l2;
            Console.WriteLine(i2);
            long l1 = 999000;
            int i1 = (int)l1;
            Console.WriteLine(i1);
            float b1 = 9f;
            int b2 = 2;
            float b3=b1+b2;
            Console.WriteLine(b3);
            Console.ReadKey();
        }
    }
}
