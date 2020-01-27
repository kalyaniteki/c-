using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HndsOnVariablesWithDataTypes
{
    class Program
    {
        string name;//instance variable(access by class obj)
        static double salary;//static variable
        static void Main(string[] args)
        {
            int i=5;//local variable
            int[] a = new int[4] { 12, 45, 67, 89 };
            Console.WriteLine(i);
            Console.WriteLine(Program.salary);
            Program obj = new Program();
            Console.WriteLine(obj.name);
            int k = 10;
            string name = "lucky";
            Console.WriteLine("name:{0} age:{1}", name, k);
            Console.ReadKey();
        }
    }
}
