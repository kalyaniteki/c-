using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDeligate
{
    class democlass
    {
       // public delegate double calAreapointer(double x);
        static void Main(string[] args)
        {
            //calAreapointer c = new calAreapointer(calArea);
            // calAreapointer c = new calAreapointer(delegate (double r)
            //{ return 3.12 * r * r; });    
            //calAreapointer c = (r => 3 * r * r);


            //double area = c(56);

            //Console.WriteLine(area);
            Func<double, double> f1 = (r => 3.13 * r * r);
            double a2=f1(14);
            Console.WriteLine(a2);
            Action<string> act = (x => Console.WriteLine(x));
            act("welcome");
            Predicate<int> pt = (y => y > 3);
            Console.WriteLine(pt(1));


            int[] arr = new int[] { 1, 2, 3, 4 };
            int y1 = arr.Count(y2 => y2 > 2);
            Console.WriteLine(y1);
            List<string> name = new List<string>();
            name.Add("divya");
            name.Add("hamsi");
            name.Add("kalyani");
            List<string> sn = name.FindAll(d => d.Contains(d));
            foreach(string n in sn)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();

        }
            //public static double calArea(double x)
            //{
            //    return 34.12 * x * x;
            //}

        
    }
}
