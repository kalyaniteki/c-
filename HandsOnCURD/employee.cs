using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCURD
{
    class employee
    {
        public int empid;
        public string name;
       public string desig;
        public  employee(int empid,string name,string desig)
        {

            this.empid = empid;
            this.name = name;
            this.desig = desig;
            
        }
        public override string ToString()
        {
            return this.empid + this.name + this.desig;
        }
    }
}
