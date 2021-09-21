using System;
//using System.IO;

namespace SandBox
{
    class liczby
    {
        public int a, b;

        public liczby(int x, int y)
        {
            a = x;
            b = y;
        }

        public int NWD(int a, int b)
        {
            int r = 0;
            while (b > 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
    }

    class ulamek : liczby
    {
        int licznik, mianownik, nwd;
        public ulamek(int a, int b) : base(a, b)
        {
        }

        public void skracanie()
        {
            licznik = a;
            mianownik = b;
            nwd = NWD(licznik, mianownik);
            //Console.WriteLine("l {0}, m {1}, nwd {2}", a, b, nwd);
            Console.WriteLine("Skrócony licznik: {0}", licznik / NWD(licznik, mianownik));
            Console.WriteLine("Skrócony mianownik: {0}", mianownik / NWD(licznik, mianownik));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Podaj licznik: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj mianownik: ");
            int m = Convert.ToInt32(Console.ReadLine());

            liczby X = new liczby(l, m);


            ulamek Y = new ulamek(l, m);
            Y.skracanie();

            Console.Write("Naciśnij dowolny klawisz...."); Console.ReadKey();
        }
    }
}