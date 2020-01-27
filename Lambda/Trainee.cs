using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Trainee
    {
        int id;
        string name;
        int projid;
        public Trainee(int id,string name,int projid)
        {
            this.id = id;
            this.name = name;
            this.projid = projid;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Projid { get => projid; set => projid = value; }
        public override string ToString()
        {
            return this.name ;
        }
    }
}
