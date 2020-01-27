using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnAbstractAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student s;

            //int n = int.Parse(Console.ReadLine());
            //if (n == 1)
            //{
            //    float f = int.Parse(Console.ReadLine());
            //    s = new Undergrade();
            //    Console.WriteLine(s.Ispassed(f));
            //}
            //else
            //{
            //    float f1 = int.Parse(Console.ReadLine());
            //    s = new Graduate();
            //    Console.WriteLine(s.Ispassed(f1));
            //}
            Istudent s;
            s = new Dayscholar();
            s.StudentId = int.Parse(Console.ReadLine());
            s.Name =(Console.ReadLine());
            s.showdetails();
            Resident r = new Resident();
            s = r;
            s.StudentId = int.Parse(Console.ReadLine());
            s.Name = (Console.ReadLine());
            s.showdetails();


        }
    }
}
