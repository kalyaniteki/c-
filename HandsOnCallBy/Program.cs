using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCallBy
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
           
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            c.Add(i,j);
           // c.Swap(ref i,ref j);
            //Console.WriteLine(i + " " + j);
           
            int result = c.Add(i, j);
            Console.WriteLine("add"+result);
            c.Substract(i, j, out int sub);
            Console.WriteLine("sub"+sub);
            Console.ReadLine();
        }
    }
}
