using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectGyakorlas
{
    class Teglalap
    {
        private int a;
        private int b;

        public Teglalap(int fuggoleges, int vizszintes)
        {
            a = fuggoleges;
            b = vizszintes;
        }

        public int Kerulet()
        {
            return 2 * (a + b);
        }

        public int Terulet()
        {
            return a * b;
        }
    }

    class Kor
    {
        private int r;

        public Kor(int sugar)
        {
            if (sugar < 1)
            {
                r = 1;
            }
            else
            {
                r = sugar;
            }
        }

        private double Kerulet()
        {
            return 2 * r * Math.PI;
        }

        private double Terulet()
        {
            return Math.PI * (r * r);
        }

        public void AdatokKiirasa()
        {
            Console.WriteLine("Sugár: {0}", r);
            Console.WriteLine("Kerület: {0}", Kerulet());
            Console.WriteLine("Terület: {0}", Terulet());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Írja be a téglalap függőleges oldalát: ");
            int fuggoleges = int.Parse(Console.ReadLine());
            Console.WriteLine("Írja be a téglalap vízszintes oldalát: ");
            int vizszintes = int.Parse(Console.ReadLine());
            Teglalap t = new Teglalap(fuggoleges, vizszintes);

            //t.a = 4;
            //t.b = 5;

            Console.WriteLine("Téglalap kerülete: ");
            Console.WriteLine(t.Kerulet());
            Console.WriteLine("Téglalap területe: ");
            Console.WriteLine(t.Terulet());

            Console.WriteLine("Írja be a kör sugarát: ");
            int sugar = int.Parse(Console.ReadLine());
            Kor k = new Kor(sugar);

            //k.r = 12;

            k.AdatokKiirasa();

            Console.ReadKey();
        }
    }
}
