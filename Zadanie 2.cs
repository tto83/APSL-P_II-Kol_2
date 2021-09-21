using System;

namespace PII_Kol2_Zad_2
{
    class Program
    {
        class ciag
        {
            public int[] tablica;
            public ciag(int[] a)
            {
                tablica = a;
            }

            public virtual int dzialanie() //ile trójek
            {
                int n = tablica.Length;
                int licznik = 0;
                if (n < 3) { return 0; }
                else
                {
                    for (int i = 0; (i + 2) < n; i++)
                    {
                        if (tablica[i] == tablica[i + 1] && tablica[i] == tablica[i + 2]) { licznik++; }
                        //Console.WriteLine("{0} | {1} | {2} | {3}", tablica[i], tablica[i+1], tablica[i+2], licznik); //tymczasowe wypisanie sprawdzenia
                    }
                    return licznik;
                }
            }

            public void wykonaj()
            {
                dzialanie();
            }
        }

        class Ile_Pierwszych : ciag
        {
            public Ile_Pierwszych(int[] a2) : base(a2)
            {
            }
            public bool czyPierwsza(int a)
            {
                if (a.Equals(2) || a.Equals(3)) { return true; }
                else if (a <= 1 || (a % 2).Equals(0) || (a % 3).Equals(0)) { return false; }

                int i = 5;
                while (Math.Pow(i, 2) <= a)
                {
                    if ((a % i).Equals(0) || (a % (i + 2)).Equals(0)) { return false; }
                    i += 6;
                }
                return true;
            }

            public override int dzialanie()
            {
                int licznik = 0;
                for (int i = 0; i < tablica.Length; i++)
                {
                    if (czyPierwsza(tablica[i])) { licznik++; }
                }
                return licznik;
            }
        }

        static void Main(string[] args)
        {
            //zamiast wprowadzania można użyć poniższego ciągu testowego

            //int[] liczby = { 1, 3, 5, 7, 8, 8, 8, 12, 14, 16, 16, 16, 18, 20, 22, 24 }; //ciąg testowy

            Console.Write("Podaj ilość elementów w ciągu: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] liczby = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Podaj {0} element ciągu: ", i + 1);
                liczby[i] = Convert.ToInt32(Console.ReadLine());
            }

            ciag X = new ciag(liczby);
            Console.WriteLine("Ilość ciągów 3 elementowych: {0}", X.dzialanie());
            Ile_Pierwszych Y = new Ile_Pierwszych(liczby);
            Console.WriteLine("Ilość liczb pierwszych w ciągu: {0}", Y.dzialanie());
        }
    }
}
