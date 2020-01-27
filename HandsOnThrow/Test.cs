using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnThrow
{
    class Passanger:Exception
    {
        string name;
        int age;
       // string s;
        int numOfTic;
        public Passanger(string name,int age,string s) : base(s)
        {
            this.name = name;
            this.age = age;
        }
        public Passanger( string s) : base(s)
        {
            
        }
        public   void TicketBooking(int numOfTic)
        {
            try
            {
                if (numOfTic >= 2)
                {
                    throw new Passanger("CanT Book More THan 2");
                }
               
                else
                {
                    Console.WriteLine("TIcket Booked Succesfull");
                    this.numOfTic = numOfTic;
                    Console.WriteLine(this.name + this.age + this.numOfTic);
                }


            }
            catch(Passanger e)
            {
                Console.WriteLine(e);
            }
        }
     
    }
}
