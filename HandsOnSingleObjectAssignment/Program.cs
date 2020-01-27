using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnSingleObjectAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Student ds;
            ds = new DayScholar(45,"divya",4500,500);
            ds = new Hostelir(48, "summu", 5678, 7879);
            int ch = int.Parse(Console.ReadLine());
            if (ch == 1)
            {
                ds.displayDetails();
                double n=  ds.PayFee(500);
                Console.WriteLine(n);
            }
            else if (ch == 2)
            {
                ds.displayDetails();
                double n = ds.PayFee(500);
                Console.WriteLine(n);
            }
            


        }
    }
}
