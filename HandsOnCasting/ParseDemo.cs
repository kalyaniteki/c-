using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCasting
{
    class ParseDemo
    {
        static void Main()
        {
            sbyte i = sbyte.Parse("123");
            float j = float.Parse("123.4");
            decimal k = decimal.Parse("123456.456");
            bool b=bool.Parse("true");
            Console.WriteLine("{0},{1},{2},{3}", i, j, k,b);
            string s = "100";
            int a= int.Parse(s);
            double d = double.Parse(s);
            long l = long.Parse(s);



        }

    }
}
