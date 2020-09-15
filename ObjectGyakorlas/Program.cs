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

    class Program
    {
        static void Main(string[] args)
        {
            Teglalap teglalap = new Teglalap();

            teglalap.a = 4;
            teglalap.b = 5;

            Console.WriteLine(teglalap.Kerulet());
            Console.WriteLine(teglalap.Terulet());

            Console.ReadKey();
        }
    }
}
