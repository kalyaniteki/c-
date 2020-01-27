using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnSingleObjectAssignment
{
   abstract class Student
    {
     protected   int studId;
       protected string studName;
        protected  double examFee;
        public Student(int studId, string studName, double examFee)
        {
            this.studId = studId;
            this.studName = studName;
            this.examFee = examFee;
        }
     public abstract  void displayDetails();
        public abstract double PayFee(double d);

    }
    class DayScholar:Student
    {
        double transportfee;
        public DayScholar(int studId,string studName,double examFee,double transportfee):base(studId,studName,examFee)
        {
            this.transportfee = transportfee;
        }
        public override void displayDetails()
        {
            Console.WriteLine(this.studId + this.studName + this.examFee + this.transportfee);
        }
        public override double PayFee(double transportfee)
        {
            double n = this.transportfee + this.examFee;
            return n;
        }
    }
    class Hostelir : Student
    {
        double hostelfee;
        public Hostelir(int studId, string studName, double examFee, double hostelfee) : base(studId, studName, examFee)
        {
            this.hostelfee =hostelfee;
        }
        public override void displayDetails()
        {
            Console.WriteLine(this.studId + this.studName + this.examFee + this.hostelfee);
        }
        public override double PayFee(double hostelfee)
        {
            return this.hostelfee+ this.examFee;
        }
    }
}













