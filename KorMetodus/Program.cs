using System;

namespace KorMetodus
{
    class Program
    {
        static void Kiir(string szoveg, double ertek)
        {
            Console.Write(szoveg + " ");
            // két tizedes értékre írja ki az eredményt
            // Console.WriteLine("{0:N2}", ertek);
            Console.WriteLine(ertek);
        }

        static double Terulet(int sugar)
        {
            return Math.PI * Math.Pow(sugar, 2);
        }

        static double Kerulet(int sugar)
        {
            return 2 * sugar * Math.PI;
        }

        static void Main()
        {
            int r = 0;
            double ter;
            double ker;
            Console.Write("Kerjuk add meg a kor sugarat: ");

            r = Convert.ToInt32(Console.ReadLine());

            ter = Terulet(r);
            ker = Kerulet(r);

            Kiir("A terulet:", ter);
            Kiir("A kerulet:", ker);

            Console.ReadKey();
        }
    }
}
