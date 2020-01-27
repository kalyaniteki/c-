using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HandOnCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // nongeneric 
            var i = 8;
            i = 6;
            i = 4;
            dynamic x;
            x = 9;
            x = 4.5;
            x = "abd";
            
            ArrayList al = new ArrayList();
            al.Add(5);
            al.Add("c");
            al.Add("kalyani");
            al.Add(900);
            al.Add(4.3);
            al.Remove(900);
            foreach(var val in al)
            {
                Console.WriteLine(val);
            }
            Queue qlist = new Queue();
            qlist.Enqueue(1);
            qlist.Enqueue("j");
            qlist.Enqueue(9.7);
            qlist.Enqueue("kalyani");
            qlist.Dequeue();
            foreach (var val in qlist)
            {
                Console.WriteLine(val);
            }
            Stack s = new Stack();
            s.Push(23);
            s.Push(4.333);
            s.Push("kalyani");
            Console.Write(s.Pop());
            Console.Write(s.Peek());
            foreach (var val in s)
            {
                Console.WriteLine(val);
            }
            Hashtable ht = new Hashtable();
            ht.Add(1, "CTS");
            ht.Add(2, 1000);
            ht.Add('a', "name");
            ht.Add(4, 4.56);
            foreach (var val in ht.Keys)
            {
                Console.Write(val);
                Console.WriteLine(ht[val]);
            }
            


            Console.ReadKey();
        }
    }
}
