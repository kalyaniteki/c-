using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnIterativeStmts
{
    class Program
    {
        public static void Greet( string name)
        {
            int flag = 1;
            while(flag<=10)
            {
                Console.WriteLine("hello " + name);
                flag++;
            }
        }
        public static void DisplayWholeNum(int i)
        {
            int flag = 0;
            do
            {
                Console.Write(flag + "\t");
                flag++;
            } while (flag <= i);
        }
        public static int ReturnFactorial(int k)
        {
            int fact = 1;
            for(int i=1;i<=k;i++)
            {
                fact = fact * i;
            }
            return fact;
            /*for(;i<=k;i++)
            {
                fact = fact * i;
            }
            for(;i<=k;)
            {
                fact = fact * i;
                i++;

            }
            for(; ;)
            {
               if(i<=k)
               {
                   fact = fact * i;
                    i++;

                }
                else'
                      break;
            }
             return fact;

            */
        }
        public static void DisplayEven(int no)
        {
            for(int j=1;j<=no;j++)
            {
                if (j % 2 == 1)
                    continue;
                Console.WriteLine(j + "\t");
            }
        }
        public static string CheckVowel(char ch)
        {
            string result = null;
            
            switch(ch)
            {
                case 'a':
                    result = "vowel";
                    break;
                case 'e':
                    result = "vowel";
                    break;
                case 'i':
                    result = "vowel";
                    break;
                case 'o':
                    result = "vowel";
                    break;
                case 'u':
                    result = "vowel";
                    break;
                default:
                    result = "invalid input";
                    break;

            }
            return result;

        }
        public static void Menu(int ch,int i)
        {
              
            switch(ch)
            {
                case '1':
               
                    if (i % 2 == 0)
                        Console.Write( "Even");
                    else
                        Console.Write("ODD");
                    break;
                case '2':
                    int j;
                    for(j=1;j<=i;j++)
                    {
                        Console.Write(j + "\t");
                    }
                    break;

                case '3':
                    int a;
                    for (int k=0;k<=10;k++)
                    {
                        a = i * k;
                        Console.WriteLine(a);
                        
                    }
                    break;
                case '4':
                    break;
                default:
                    Console.WriteLine( "invalid input");
                    break;


            }
        }
        static void Main(string[] args)
        {
            /* Console.WriteLine("enter name");
             string s=Console.ReadLine();
             Greet(s);
             DisplayWholeNum(40);
             Console.WriteLine("\n");
             Console.WriteLine("fact "+ReturnFactorial(5));*/
            // DisplayEven(15);
            // Console.WriteLine(CheckVowel('i'));
            // Console.WriteLine(CheckVowel('4'));
            // Console.WriteLine(CheckVowel('b'));
            Console.WriteLine("enter num");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Even or Odd");
            Console.WriteLine("2.natural no's");
            Console.WriteLine("3.multiplication table");
            Console.WriteLine("4.exit");
            Console.WriteLine("enter your choice");
            int ch = int.Parse(Console.ReadLine());
            
            Menu(ch,i);
            
            Console.ReadKey();
        }
    }
}
