using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tobbelem
{
    class Tobbelemosztaly
    {
        private int szam;
        private bool isParos;
        public Tobbelemosztaly()
        {
            this.szam = 0;
            this.isParos = false;
        }

        public void Getszam(int p)
        {
            this.szam = p;
        }

        public void SetSzamTipus()
        {
            this.isParos = szam % 2 == 0;
        }

        public bool outSzamTipus()
        {
            return isParos;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string valasz = string.Empty;
            int paros = 0,
                szam = 0,
                paratlan = 0;
            Tobbelemosztaly a = new Tobbelemosztaly();

            while (paros + paratlan < 100)
            {
                Console.WriteLine("Adj meg egy egész számot: ");
                szam=Convert.ToInt32(Console.ReadLine());
                a.Getszam(szam);
                a.SetSzamTipus();
                if (a.outSzamTipus()){
                    valasz = "Paros";
                    paros += szam;
                }
                else
                {
                    valasz = "Paratlan";
                    paratlan += szam;
                }
                Console.WriteLine($"A szám típusa: {valasz}, eddig {paros + paratlan} számok összege.");
                Console.ReadKey();
            }
        }
    }
    /*
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int parat = 0;
            int paros = 0;

            while (true)
            {
                Console.WriteLine("Adj meg egy számot: ");
                int b = Convert.ToInt32(Console.ReadLine());

                a += b;
                if (b % 2 == 0)
                {
                    paros++;
                }
                else
                {
                    parat++;
                }
                if (a > 100)
                {
                    break;
                }
            }
            Console.WriteLine("Páros: " + paros + "Páratlan: " + parat);

        }
    }
    */
}

