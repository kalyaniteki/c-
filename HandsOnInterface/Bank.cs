using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterface
{
   
  public  interface  Iloan
    {
        
        void getInterest();
        
    }
    interface gloan
    {
        void getGoldLoan();
    }
 public abstract  class Bank
    {
        private string bName;
        protected string location;

        protected string BName { get => bName; set => bName = value; }

        public Bank(string bname,string location)
        {
            this.BName = bname;
            this.location = location;

        }

    }
    public class SBI : Bank,
    {
        string bHead;
        public SBI(string bName,string location,string bmanager):base(bName,location)
        {
            this.bHead = bmanager;
        }
        public void DisplayDetails()
        {
            Console.WriteLine(this.BName +"\t"+ this.location+"\t" + this.bHead);
        }
        public void getInterest()
        {
            Console.WriteLine("SBI Has An Interest Of 21%");
        }
        public void getGoldLoan()
        {
            Console.WriteLine("SBI had an Gold Loan Of 50%");
        }
    }
    public class ICICI : Bank,SBI
    {
        string bHead;
        public ICICI(string bName, string location, string bmanager) : base(bName, location)
        {
            this.bHead = bmanager;
        }
        public void DisplayDetails()
        {
            Console.WriteLine(this.BName+"\t" + this.location+"\t" + this.bHead);
        }
        public void getInterest()
        {
            Console.WriteLine("ICICI Has An Interest Of 31%");
        }
        public void getGoldLoan()
        {
            Console.WriteLine("SBI had an Gold Loan Of 50%");
        }
    }
}
