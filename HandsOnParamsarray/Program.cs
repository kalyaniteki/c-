using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnParamsarray
{
    class Calculator
    {
        public void Add(params int[] x)
        {
            int res = 0;
            foreach (int i in x) res += i;
            Console.WriteLine(res);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.Add(10,34,67,34);
            Console.WriteLine("hello world");
        }
    }
}
