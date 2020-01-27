using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ICICI ic = new ICICI("icici 001", "hybd", "Kalyani");
            SBI sb = new SBI("sbi 002", "afghanisthan", "CHUBS");

            ic.DisplayDetails();
            ic.getInterest();
            ic.getGoldLoan();
            sb.DisplayDetails();
            sb.getInterest();
            sb.getGoldLoan();
        }
    }
}
