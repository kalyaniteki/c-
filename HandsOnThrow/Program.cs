using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnThrow
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    idException e = new idException("divya");
            //    int n = 0;
            //    if (n == 0)
            //    {
            //        throw new idException("cant be Zero");
            //    }
            //}
            //catch(idException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //Employe e1 = new Employe("");
            //e1.show();
            Console.WriteLine("name:");
            string name = Console.ReadLine();
            Console.WriteLine("Age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("NUmber Of Tickets");
            int n = int.Parse(Console.ReadLine());
            Passanger ps = new Passanger(name,age, "");
            ps.TicketBooking(n);
           // ps.show();

        }
    }
}
