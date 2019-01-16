using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KinkelaVitoCitanjeTekstDat
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Učenik\Desktop\dule.txt");

            //čita datoteku liniju po liniju
            while (!sr.EndOfStream)
            {
                Console.WriteLine(sr.ReadLine());
            }

            //zatvara
            sr.Close();


            Console.ReadKey();
        }
    }
}
