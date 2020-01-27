using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCollege
{
    class Program
    {
        static void Main(string[] args)
        {
            int no = int.Parse(Console.ReadLine());
            string namee = Console.ReadLine();
            int clss = int.Parse(Console.ReadLine());
            int seme = int.Parse(Console.ReadLine());
            string branchh = Console.ReadLine();
            int [] marks=new int[5];
            for(int i=0; i<5;i++)
            {
                Console.WriteLine("enter marks");
                marks[i] = int.Parse(Console.ReadLine());
            }
            student s = new student(no,namee,clss,seme,branchh,marks);
            s.show();
            Console.ReadLine();

        }
    }
}
