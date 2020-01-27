using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCasting
{
    class ObjectDemo
    {
        static void Main()
        {
            int i = 10;
            double d = 10.43;
            float f = 2.0f;
            char c = 'a';
            object o = i;
            object o1 = d;
            object o2 = f;
            object o3 = c;
            //unboxing
            object ob = 12;
            int k = (int)ob;
            object ob1 = 12.3;
            double d1 = (double)ob1;
            object ob2 = 'a';
            char c1 = (char)ob2;
            object ob3 = "abc";
            string s = ob3.ToString();
           
            Console.WriteLine(s);
            Console.ReadKey();



        }

    }
}
