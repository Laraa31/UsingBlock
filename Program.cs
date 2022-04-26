using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usingBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Unesite ime:");
            string ime=Console.ReadLine();

            Console.Write("Unesite prezime: ");
            string prezime=Console.ReadLine();

            Console.WriteLine("\n ---------- Upisivanje podataka u datoteku...");
            using (StreamWriter sw = new StreamWriter(@"c:\prviDir\MojaDatoteka.txt"))
            {
                sw.WriteLine("Ime: {0}",ime);
                sw.WriteLine("Prezime: {0}", prezime);
            }

            Console.WriteLine("\n ---------- Upisivano!");

            Console.WriteLine("\n ---------- Čitanje podataka iz datoteke... \n");
            using (StreamReader sr = new StreamReader(@"c:\prviDir\MojaDatoteka.txt"))
            {
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());                }
            }


            Console.ReadKey();
        }
    }
}
