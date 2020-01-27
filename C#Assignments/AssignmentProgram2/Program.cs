using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentProgram2
{
    class Program
    {

        public static void Greet(string s)
        {

            Console.WriteLine("“Hi!" + s);
            Console.WriteLine("Welcome to the world of C#");
            Console.ReadKey();
        }
        public static void Third()
        {
            Console.WriteLine("enter two numbers");
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            for (int k = i; k <= j; k++)
            {
                Console.WriteLine(k);
            }
        }
        public static void Fourth()
        {
            Console.WriteLine("enter num");
            int i = int.Parse(Console.ReadLine());
            if (i % 2 == 0)
                Console.WriteLine("EVEN");
            else

                Console.WriteLine("ODD");
        }
        public static void Five()
        {
            int count = 0, count1 = 0;
            Console.WriteLine("enter numbers of elements");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("enter elements");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (arr[i] % 2 == 0)
                {
                    count++;
                }
                else
                    count1++;
            }
            Console.WriteLine("total Even" + count);
            Console.WriteLine("total odd" + count1);
        }
        public static void Sixth()
        {
            int i = 1;
            for (i = 0; i <= 25; i++)
            {
                Console.WriteLine(i * i);
            }
        }
        public static void Seven()
        {
            int fact = 1;
            Console.WriteLine("enter num");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine(fact);
        }
        public static void Eight()
        {
            int i, n, t1 = 0, t2 = 1, temp;


            for (i = 1; i <= 40; ++i)
            {
                Console.WriteLine(t1);
                temp = t1 + t2;
                t1 = t2;
                t2 = temp;

            }

        }
        public static void Nine()
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 20; i++)
            {
                int j = n * i;
                Console.WriteLine(j);
            }
        }
        public static void Ten()
        {
            int i;
            for (i = 200; i <= 300; i++)
            {
                if (i % 7 == 0)

                    Console.WriteLine(i);

            }
        }
        public static void Eleven()
        {
            Console.WriteLine("enter three numbers");
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if (i > j)
            {
                if (i > k)
                    Console.WriteLine(i);
                else

                    Console.WriteLine(k);
            }
            else if (j > k)
                Console.WriteLine(j);
            else
                Console.WriteLine(k);
        }
        public static void Twelve()
        {
            Console.WriteLine("enter temp");
            int i = int.Parse(Console.ReadLine());
            int j = (i * 9 / 5) + 32;
            Console.WriteLine(j);
        }
        public static void Thirteen()
        {
            int count1 = 0;

            Console.WriteLine("enter string");
            string s = Console.ReadLine();

            foreach (int j in s)
            {

                count1++;
            }
            Console.WriteLine(count1);

        }
        public static void Fourteen()
        {
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            int j = s.Length - 1;
            string rev = " ";
            while (j >= 0)
            {
                rev = rev + s[j];
                j--;
            }
            Console.WriteLine(rev);

        }
        public static void Fifteen()
        {
            Console.WriteLine("enter two strings");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            int i = s1.Length;
            int j = s2.Length;
            if (i == j)
            {
                for (int a = 0; a <= i; a++)
                {
                    for (int b = 0; b <= j; b++)
                    {
                        while (s1[a] == s2[b])
                        {
                            if (a == '\0' && b == '\0')
                            {
                                Console.WriteLine("same");
                                break;
                            }
                            else
                                Console.WriteLine("not same");
                        }


                    }
                }
            }
            else
                Console.WriteLine("Not same");


        }
        public static void Sixteen()
        {
            string rev = " ";
            Console.WriteLine("enter string");
            string s = Console.ReadLine();

            int h = s.Length;
            int j = h - 1;

            while (j >= 0)
            {
                rev = rev + s[j].ToString();
                j--;
            }

            if (s==rev)
            {

                Console.WriteLine("palindrome");
            }

            else
            {
                Console.WriteLine("not palindrome");
            }
            Console.ReadKey();

        }
    


        static void Main(string[] args)
        {
            /* Console.WriteLine("Welcome to the world of C#");
             Console.WriteLine("enter your name");
             string n= Console.ReadLine();
             Greet(n);
             Third();
             Fourth();
             Five();
             Sixth();
             Seven();
            Eight();
            Nine();
            Ten();
            Eleven();
            Twelve();
            Thirteen();
            Fourteen();
            Fifteen();*/
            Sixteen();
            Console.ReadKey();
        }
    }
}
