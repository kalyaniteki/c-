using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnBank
{
    class Accounts
    {
        static string bname;
        int Acno;
        string name;
        string Actype;
        char Transtype;
        int amount;
        int bal;
        static Accounts()
        {
            bname = "SBI";
        }
        public Accounts(int Acno,String name,string Actype,char Transtype,int amount,int bal)
        {
            this.Acno = Acno;
            this.name = name;
            this.Actype = Actype;
            this.Transtype = Transtype;
            this.amount = amount;
            this.bal = bal;
        }
        public int Credit(int a)
        {
            bal = bal + a;
            return bal;
        }
        public int Debit(int b)
        {
            bal = bal - b;
            return bal;
        }
        public void show()
        {
            Console.WriteLine("bname "+"\t"+bname+"accnum  "+this.Acno+"\tName  "+this.name+"\tAccType  "+this.Actype+"\tTranstype  "+this.Transtype+"\tAmount  "+this.amount+"\tBalance  "+this.bal);
        }


    }
}
