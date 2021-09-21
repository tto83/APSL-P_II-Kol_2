using System;

namespace Zadanie_4
{
    abstract class liczby
    {
        public int liczba1
        {
            get; set;
        }
        public int liczba2
        {
            get; set;
        }

        public abstract void wynik();
    }

    class badanie_1 : liczby //czy liczby są zaprzyjaźnione
    {
        public override void wynik()
        {
            int sum1 = 0;
            for (int i = 1; i < liczba1; i++)
            {
                if (liczba1 % i == 0)
                {
                    sum1 = sum1 + i;
                }
            }

            int sum2 = 0;
            for (int i = 1; i < liczba2; i++)
            {
                if (liczba2 % i == 0)
                {
                    sum2 = sum2 + i;
                }
            }

            if (liczba1 == sum2 && liczba2 == sum1)
            {
                Console.WriteLine("Liczby są zaprzyjaźnione");
            }
            else
            {
                Console.WriteLine("Liczby nie są zaprzyjaźńione");
            }
        }
    }

    class badanie_2 : liczby
    {
        public override void wynik()
        {
            Console.WriteLine("Liczba {0} {1} jest automorficzna", liczba1, czy_automorf(liczba1));
            Console.WriteLine("Liczba {0} {1} jest automorficzna", liczba2, czy_automorf(liczba2)); // zabrakło mi czasu żeby ładnie napisać "nie"
        }

        public bool czy_automorf(int a)
        {
            int kwadrat = a * a;

            while (a > 0)
            {
                if (liczba1 % 10 != kwadrat % 10)
                {
                    return false;
                }
                a /= 10;
                kwadrat /= 10;
            }
            return true;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Podaj pierwszą liczbę: ");
            int l1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            int l2 = Convert.ToInt32(Console.ReadLine());

            badanie_1 B1 = new badanie_1();
            B1.liczba1 = l1;
            B1.liczba2 = l2;

            B1.wynik();

            badanie_2 B2 = new badanie_2();
            B2.liczba1 = l1;
            B2.liczba2 = l2;
            B2.wynik();
        }
    }
}
