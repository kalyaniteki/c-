using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnString
{
    class Employee
    {
        string name;
        string empid;
        int salary;
        public Employee()
        {

        }
        public Employee(string name,string empid,int salary)
        {
            this.name = name;
            this.empid = empid;
            this.salary = salary;
        }
        public override string ToString()
        {
            return this.name + "\n" + this.empid + "\n" + this.salary;
        }
        public override bool Equals(object obj)
        {
            Employee temp = (Employee)obj;
            if (this.name == temp.name && this.empid == temp.empid && this.salary == temp.salary)
                return true;
            else
                return false;
        }
    }
}
