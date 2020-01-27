using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a value");
            int n;
            n = int.Parse(Console.ReadLine());
            if(n%2==0)
            {
                Console.WriteLine("enter an odd number");
            }
            else
            {
                int[] arr = new int[n];
                Console.WriteLine("enter values");
                for(int i=0;i<n;i++)
                {
                    arr[i]=int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
                int first = arr[0];
                int last = arr[n - 1];
                int middle = arr[n / 2];
                Console.WriteLine(first);
                Console.WriteLine(last);
                Console.WriteLine(middle);
                Console.WriteLine();
                if (first > last)
                {
                    if (first > middle)
                    {
                        Console.WriteLine(first);
                    }
                    else
                        Console.WriteLine(middle);
                }
                else if (last > middle)
                {
                    Console.WriteLine(last);
                }
                else
                    Console.WriteLine(middle);
            }
            Console.ReadKey();
        }
    }
}
