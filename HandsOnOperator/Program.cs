using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 10;
            byte b1 = (byte)(b + 10);
            Console.WriteLine(b1);
            int i=10;
            int j=20;
            Console.WriteLine(i > j);
            Console.WriteLine(i < j);
            bool bb =( i < j) && ( j++>8);
            Console.WriteLine(j);
            Console.ReadKey();


        }
    }
}
