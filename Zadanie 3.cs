using System;

namespace PII_Kol2_Zad_3
{
    class tekst
    {
        public string[] tablica;

        public string[] czytaj()
        {
            int n = 0;
            string temp;
            while (n < 1)
            {
                Console.Write("Podaj liczbę ciagów do analizy: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            string[] tablica_1 = new string[n];
            Console.WriteLine("\nWprowadź ciągi znaków (maks dł. to 10)");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Wprowadź {0} tekst: ", (i + 1));
                temp = Console.ReadLine();
                if (temp.Length > 10)
                {
                    Console.WriteLine("Skrócono do 10 znaków!");
                    temp = temp.Substring(0, 10);
                }
                temp = temp.ToLower();
                tablica_1[i] = temp;
            }
            return tablica_1;
        }

        public virtual void dzialanie()
        {
            string temp1 = "";
            char temp;
            for (int i = 0; i < tablica.Length; i++)
            {
                char[] tablica_temp = tablica[i].ToCharArray();
                //temp = 'a';
                for (int j = 0; j < tablica_temp.Length; j++)
                {
                    for (int k = 0; k < tablica_temp.Length - 1; k++)
                        if (tablica_temp[k] > tablica_temp[k + 1])
                        {
                            temp = tablica_temp[k + 1];
                            tablica_temp[k + 1] = tablica_temp[k];
                            tablica_temp[k] = temp;
                        }
                }

                for (int l = 0; l < tablica_temp.Length; l++)
                {
                    temp1 = temp1 + tablica_temp[l];
                }
                tablica[i] = temp1;
            }

            Console.WriteLine("Posortowane ciągi:");
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine("Ciag {0}: {1}", i + 1, tablica[i]);
            }


        }

        public void wykonaj()
        {
            dzialanie();
        }
    }

    class tekst2 : tekst
    {
        public tekst2() : base()
        { }

        public override void dzialanie()
        {
            string temp;
            for (int i = 0; i < tablica.Length; i++)
            {
                temp = tablica[i];
                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j] == 'z')
                    {
                        Console.WriteLine("Ciąg zawiera z: {0}", temp);
                        break;
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            tekst X = new tekst();
            X.tablica = X.czytaj();
            X.wykonaj();

            tekst2 Y = new tekst2();
            Y.tablica = X.tablica;
            Y.wykonaj();

        }
    }
}
