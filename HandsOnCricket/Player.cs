using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnCricket
{
    abstract class Player
    {
        protected string name;
        protected string teamname;
        protected int noofmatches;
        public Player(string n,string t,int no)
        {
            this.name = n;
            this.teamname = t;
            this.noofmatches = no;
        }
        public abstract void displayplayerstatistics();
    }
    class Cricketplayer:Player
    {
        int totalrunsscored;
        int noofwicketsTaken;
       
        public Cricketplayer(string name,string team,int no,int trs,int nwt):base(name,team,no)
        {
            this.totalrunsscored = trs;
            this.noofwicketsTaken = nwt;
        }
        public override void displayplayerstatistics()
        {
            Console.WriteLine(this.name + " " + this.teamname + " " + this.noofmatches + " " + this.totalrunsscored + " " + this.noofwicketsTaken);
        }
    }
    class HockeyPlayer : Player
    {
        string position;
        int noOfGoals;
        public HockeyPlayer(string name,string team,int no,string position,int noOfGoals):base(name,team,no)
        {
            this.position = position;
            this.noOfGoals = noOfGoals;
        }
        public override void displayplayerstatistics()
        {
            Console.WriteLine(this.name + " " + this.teamname + " " + this.noofmatches + " " + this.position + " " + this.noOfGoals);
        }
    }
}
