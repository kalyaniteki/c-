using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCricket
{
    class Program
    {
        static void Main(string[] args)
        {
               string name;
         string teamname;
        int noofmatches;
            Console.WriteLine("Menu");
            Console.WriteLine("1.Cricket Player Details:");
            Console.WriteLine("2.Hockey Player Details:");
            Console.WriteLine("enter Choice");
            int ch = int.Parse(Console.ReadLine());
            // Cricketplayer cp = new Cricketplayer(20,30);
            if (ch == 1)
            {
                Cricketplayer cp = new Cricketplayer(Console.ReadLine(),Console.ReadLine(),int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()),int.Parse(Console.ReadLine()));
                cp.displayplayerstatistics();
            }
            else if(ch == 2)
            {
                HockeyPlayer hp = new HockeyPlayer("kalyani", "royal", 4, "lead", 5);
                hp.displayplayerstatistics();
            }
            else
            {
                Console.WriteLine("invalid Choice");
            }
                    
            
         

        }
    }
}
