using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = new int[4];
            i[0] = 10;
            i[1] = 12;
            i[2] = 45;
            i[3] = 86;
            int a;
            for( a=0;a<4;a++)
            {
                Console.WriteLine(i[a]);
       
            }
            int[] b = new int[5] { 10, 21, 33, 40, 50 };
            int sum = 0;
            foreach(int k in b)
            {
                if(k%2==0)
                {
                    Console.WriteLine(k);
                }
            }
            Console.ReadKey();
        }
    }
}
