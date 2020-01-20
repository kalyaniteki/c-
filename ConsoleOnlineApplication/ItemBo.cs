using System;
using System.Collections.Generic;

namespace ConsoleOnlineApplication
{
    class itembo
    {
        static List<item> llist = new List<item>();
        static List<subcatergory> slist = new List<subcatergory>();
        static List<catergory> ca = new List<catergory>();
        public void additem(int cid, string cname, string cdetails, int subid, string subname, string sdetails, int id, int price, string itemname, subcatergory sb)
        {
            subcatergory s = new subcatergory(cid, cname, cdetails, subid, subname, sdetails);
            slist.Add(s);
            ca.Add(s);
            // catergory c = new catergory(cid, cname, cdetails);
            item it = new item(id, cid, subid, price, itemname, s);
            llist.Add(it);
        }
        public void dispaly()
        {
            foreach (catergory c in ca)
            {
                Console.WriteLine(c.Cid + " " + c.Cname + " " + c.Cdetails);
                // int ch = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("enter catergory id:");
            int ch = int.Parse(Console.ReadLine());

            foreach (subcatergory sb in slist)
            {
                if (ch == sb.Cid)
                {
                    Console.WriteLine(sb.Subid + " " + sb.Subname + " " + sb.Sdetails);

                }
            }

            Console.WriteLine("enter subcatergory id:");
            int ch1 = int.Parse(Console.ReadLine());
            foreach (item il in llist)
            {

                if (ch1 == il.sid)
                {
                    Console.WriteLine(il.id + " " + il.price + " " + il.itemname);
                }
            }

        }

        public void displayseller()
        {
            //foreach (catergory c in ca)
            //{

            //    Console.WriteLine(c.Cid + " " + c.Cname + " " + c.Cdetails);

            //}
            //foreach (subcatergory sb in slist)
            //{

            //    Console.WriteLine(sb.Subid + " " + sb.Subname + " " + sb.Sdetails);
            //}

            foreach (item il in llist)
            {
                Console.WriteLine(il.id + " " + il.itemname + " " + il.price);
            }


        }
        public void search()
        {
            Console.WriteLine("1.search by id");
            Console.WriteLine("2.search by price");
            Console.WriteLine("enter your choice:");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("enter itemid");
                int p = int.Parse(Console.ReadLine());
                item i = llist.Find(e => e.id == p);
                Console.WriteLine(i.ToString());
            }
            if(n==2)
            {
                Console.WriteLine("enter min and max price:");
                int min = int.Parse(Console.ReadLine());
                int max = int.Parse(Console.ReadLine());
               item  ie = llist.Find(e =>e.price > min && e.price < max);
                //foreach(item i in ie)
                //{
                    Console.WriteLine(ie.ToString());
               // }

            }


        }


    }

}
