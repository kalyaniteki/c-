using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Trainee> t = new List<Trainee>();
            for (int i = 0; i < count; i++)
            {
                int id = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                int proid = int.Parse(Console.ReadLine());
                
                t.Add(new Trainee(id, name, proid));
                //  t.proid = -1;


            }
     
                List<Trainee> t1 = t.FindAll(x => x.Projid != -1);
                foreach (Trainee t2 in t1)
                {
                    Console.WriteLine(t2.ToString());
                }


            

        }
    }
}
