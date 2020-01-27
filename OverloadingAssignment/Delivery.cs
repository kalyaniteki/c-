using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingAssignment
{
    class Delivery
    {
     public   void DisplayDeliveryDetails(string bowler,string batsman)
        {
            Console.WriteLine(bowler + "\t" + batsman);
        }
    public    void  DisplayDeliveryDetails(long runs)
        {
            if (runs == 6)
            {
                Console.WriteLine("***Ooo Its A SIxx***");
            }
            else if (runs == 4)
            {
                Console.WriteLine("***Ooo Its A Fooouuur***");
            }
            else
            {
                Console.WriteLine("Number Of Runs:" + runs);
            }
        }
        
    }
}
