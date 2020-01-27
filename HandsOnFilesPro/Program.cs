using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HandsOnFilesPro
{
    class Program
    {
        static void Main(string[] args)
        {
            // DirectoryInfo di = new DirectoryInfo(@"d:\kalyani\C#\HandsOn");
            // if(di.Exists==false)
            // di.Create();
            // di.CreateSubdirectory("mydir2");
            // DirectoryInfo[] d = di.GetDirectories();
            // foreach(DirectoryInfo x in d)
            // {
            //     Console.WriteLine(x.Name + " " + x.FullName + " " + x.CreationTime);
            // }
            // FileInfo[] fi = di.GetFiles();
            // Console.WriteLine("**************************************************");
            // foreach (FileInfo x in fi)
            // {
            //     Console.WriteLine(x.Name + " " + x.FullName + " " + x.CreationTime);
            // }
            // FileStream fs = new FileStream(@"d:\kalyani\mydir\a.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs);

            // sw.WriteLine("welcome");
            // for (int i=0;i<2;i++)
            // {
            //     string s = Console.ReadLine();
            //     sw.WriteLine(s);
            // }
            // sw.Close();
            // fs.Close();
            //FileStream fs1= new FileStream(@"d:\kalyani\mydir\a.txt", FileMode.OpenOrCreate, FileAccess.Read);
            //StreamReader sr = new StreamReader(fs1);
            //string s;
            //while((s=sr.ReadLine())!=null)
            //{
            //    Console.WriteLine(s);
            //}
            //sr.Close();
            //fs1.Close();
            FileStream fs = new FileStream(@"d:\kalyani\mydir\b.txt", FileMode.OpenOrCreate, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            int i = 20;
            string s = "kalyani";
            char c = 'h';
            bw.Write(i);
            bw.Write(s);
            bw.Write(c);
            bw.Close();
            fs.Close();
            FileStream fs1= new FileStream(@"d:\kalyani\mydir\b.txt", FileMode.OpenOrCreate, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs1);
            int x = br.ReadInt32();
            string z = br.ReadString();
            char y = br.ReadChar(); 
            
            Console.WriteLine(x + " " + y + " " + z);
            br.Close();
            fs1.Close();

        }
    }
}
