using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnTwoDimensionalArray
{
    class Jagged
    {
        static void Main(string[] args)
        {
            string[][] names = new string[3][];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter size in t"+(i+1));
                int size = int.Parse(Console.ReadLine());
                names[i] = new string[size];
            }
                for (int r = 0; r < 3; r++)
                {
                    for (int c = 0; c < names[r].Length; c++)
                    {
                        names[r][c] = Console.ReadLine();
                    }
                }
                for (int r = 0; r < 3; r++)
                {
                    for (int c = 0; c < names[r].Length; c++)
                    {
                        Console.Write(" " + names[r][c]);

                    }
                    Console.WriteLine();
                }
                foreach(string s in names[1])
            
                Console.WriteLine(s);

              
            Console.ReadLine();
            
        }
    }
}

