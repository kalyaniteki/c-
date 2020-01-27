using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCasting
{
    class ConvertDemo
    {
        static void Main()
        {
            string s = Convert.ToString(true);
            Console.WriteLine(s);
            s = Convert.ToString("12.3");
            Console.WriteLine(s);
            s = Convert.ToString("12");
            Console.WriteLine(s);
            s = Convert.ToString("A");
            Console.WriteLine(s);
            Console.ReadKey();

        }
    }
}
