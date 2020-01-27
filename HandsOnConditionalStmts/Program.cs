using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnConditionalStmts
{
    class Program
    {
        public static string EvenOdd(int i)
        {
            if (i % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }

        //nested if
        public static int Max(int i, int j, int k)
        {
            if (i > j)
            {
                if (i > k)
                    return i;
                else
                    return k;
            }
            else
            {
                if (j > k)
                    return j;
                else
                    return k;
            }
        }
        public static string Result (double m1, double m2, double m3,double m4,double m5)
        {
            double avg = (m1 + m2 + m3 + m4 + m5) / 5;
            if (avg > 70)

                return "distinction";
            else if (avg > 50 && avg < 60)

                return "first class";
            else
                return "fail";
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter no");
            int i = int.Parse(Console.ReadLine());
            string result= EvenOdd(i);
            Console.WriteLine(result);
            Console.WriteLine("enter values");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Max(a,b,c));
            Console.WriteLine(Result(86.4, 45, 70, 65.8, 87));
            Console.ReadKey();
        }
    }
}
