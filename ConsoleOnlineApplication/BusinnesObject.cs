using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOnlineApplication
{
    class BusinnesObject
    {
        List<buyer> bo = new List<buyer>();
        List<seller> se = new List<seller>();

        public void reg(string id, string username, string email, int number, DateTime d, string pass)
        {

            bo.Add(new buyer(id, username, email, number, d, pass));
            Console.WriteLine("Registered Successfully");

        }
        public void regseller(string id, string username, string email, int number, DateTime d, string pass)
        {

            se.Add(new seller(id, username, email, number, d, pass));
            Console.WriteLine("Registered Successfully");

        }
        public bool login(string urr, string pass)
        {

            buyer bb = bo.Find(e => e.Username == urr && e.Password == pass);
            if (bb != null)
            {

                return true;
            }
            else
            {
                return false;
            }

        }
        public bool loginseller(string urr, string pass)
        {

            seller ss = se.Find(e => e.Username == urr && e.Password == pass);
            if (ss != null)
            {

                return true;
            }
            else
            {
                return false;
            }

        }
        public void displaybuyer()
        {
            foreach (buyer b in bo)
            {
                Console.WriteLine(b.ToString());
            }
        }
        public void displaysellerdetails()
        {
            foreach (seller s in se)
            {
                Console.WriteLine(s.ToString());
            }
        }

    }
}

