using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1.Player details Of the delivery");
            Console.WriteLine("2.Run details Of the delivery:");
            int ch = int.Parse(Console.ReadLine());
            Delivery d = new Delivery();
            switch (ch)
            {
                case 1:
                    
                    d.DisplayDeliveryDetails(Console.ReadLine(),Console.ReadLine());
                    break;
                case 2:
                    int n = int.Parse(Console.ReadLine());
                    d.DisplayDeliveryDetails(n);
                    break;

            }
           //int n = int.Parse(Console.ReadLine());
           // switch (n)
           // {
           //     case 6:
           //         Console.WriteLine("sixx fixx");
           //         break;
           //     case 4:
           //         Console.WriteLine("Four Sour");
           //         break;
           // }
           // Console.WriteLine(n);
        }
    }
}
