using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnArrays
{
    class demo3
    {
        public static void Main()
        {
            string[] names = new string[4] { "kalyani", "divya", "srija", "suma" };
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            int flag = 0;
           
            foreach (string n in names)
            {
                if(s==n)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine(" not exists");
            else
                Console.WriteLine("exists");
        }
            
        
    }
}
