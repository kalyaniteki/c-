using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HandOnCollections
{
    class genericpro
    {
        static void Main(String[] args)
        {
          /*  List<int> l = new List<int>();
            l.Add(10);
            l.Add('a');
            l.Add(34);
            foreach (var val in l)
            {
                Console.WriteLine(val);
            }
            Console.ReadLine();
            Console.WriteLine();
            Queue<string> gq = new Queue<string>();
            gq.Enqueue("1");
            gq.Enqueue("kalyani");
            gq.Enqueue("c");
            gq.Enqueue("34.4");
            gq.Enqueue("divya");
            gq.Dequeue();
            foreach (var val in gq)
            {
                Console.WriteLine(val);
            }
            Console.ReadLine();
            Console.WriteLine();

            Stack<float> gs = new Stack<float>();

            gs.Push(23);
            gs.Push(23.444f);
            gs.Push(2.3555556f);
            Console.Write(gs.Pop());
            Console.Write(gs.Peek());
            foreach (var val in gs)
            {
                Console.WriteLine(val);
            }
            Console.ReadLine();
            Console.WriteLine();

            HashSet<int> hs = new HashSet<int>();
            hs.Add(1);
            hs.Add(24);
            hs.Add(13);
            hs.Add(9);
            foreach (var val in hs)
            {
                Console.WriteLine(val);
               
            }
            Console.ReadLine();
            Console.WriteLine();

            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1,"kal");
            dt.Add(2,"div");
            dt.Add(3,"suma");
            dt.Add(4,"hamsi");
            foreach (KeyValuePair<int,string> k1 in dt)
            {
                Console.WriteLine(k1.Key);
                Console.WriteLine(k1.Value);


            }*/
            
           
           
            int count;
            Console.WriteLine("enter key values");
            count = int.Parse(Console.ReadLine());
            Dictionary<string,int> dt1 = new Dictionary<string,int>();
            String name;int salary;
            for (int i = 0; i <count; i++)
            {
                Console.WriteLine("enter emp");
                name = Console.ReadLine();
                Console.WriteLine("enter salary");
                salary = int.Parse(Console.ReadLine());
                dt1.Add(name, salary);

            }
            int high = 0;
            string hname = "";
            foreach (KeyValuePair<string,int> k1 in dt1)
            {
               if(k1.Value > high)
                {
                    high = k1.Value;
                    hname = k1.Key;
                }


            }
            Console.WriteLine("highest salary name " + hname);



            Console.ReadLine();
            Console.WriteLine();





        }
    }
}
