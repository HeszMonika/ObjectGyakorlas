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
            r = sugar;
        }

        public double Kerulet()
        {
            return 2 * r * Math.PI;
        }

        public double Terulet()
        {
            return Math.PI * (r * r);
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

            Console.WriteLine("Kör kerülete: ");
            Console.WriteLine(k.Kerulet());
            Console.WriteLine("Kör területe: ");
            Console.WriteLine(k.Terulet());

            Console.ReadKey();
        }
    }
}
