using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnBank
{
    class Program
    {
        static void Main(string[] args)
        {
            

       
           int a = int.Parse(Console.ReadLine());
           string n = Console.ReadLine();
            string atype = Console.ReadLine();
            char Ttype = char.Parse(Console.ReadLine());
            int am = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Accounts ac = new Accounts(a,n,atype,Ttype,am,b);

            if (Ttype=='d')
            {
                ac.Credit(am);
            }
            else if(Ttype=='w')
            {
                ac.Debit(am);

            }
            ac.show();
            Console.ReadKey();
        }
    }
}
