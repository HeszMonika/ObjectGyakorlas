using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectGyakorlas
{
    class Teglalap
    {
        public int a;
        public int b;

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
        public int r;

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
            Teglalap t = new Teglalap();

            t.a = 4;
            t.b = 5;

            Console.WriteLine(t.Kerulet());
            Console.WriteLine(t.Terulet());

            Kor k = new Kor();

            k.r = 12;

            Console.WriteLine(k.Kerulet());
            Console.WriteLine(k.Terulet());

            Console.ReadKey();
        }
    }
}
