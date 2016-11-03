using System;

namespace Vsite.CSharp
{
    // vrijednosni tip zbog 'struct'
    struct VrijednTip
    {
        public int X;
    }

    // referentni tip
    class RefTip { 
        public int X; 
    }


    public class Pridruživanje
    {
        public static void PridruživanjeStruktura(int prvaVrijednost, int drugaVrijednost)
        {
            VrijednTip vt1 = new VrijednTip();
            vt1.X = prvaVrijednost;

            VrijednTip vt2 = vt1;

            Console.WriteLine(vt1.X);
            Console.WriteLine(vt2.X);

            vt1.X = drugaVrijednost;


            Console.WriteLine(vt1.X);
            Console.WriteLine(vt2.X);
        }

        public static void PridruživanjeKlasa(int prvaVrijednost, int drugaVrijednost)
        {
            RefTip rt1 = new RefTip();
            rt1.X = prvaVrijednost;

            RefTip rt2 = rt1;

            Console.WriteLine(rt1.X);
            Console.WriteLine(rt2.X);

            rt1.X = drugaVrijednost;

            Console.WriteLine(rt1.X);
            Console.WriteLine(rt2.X);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Pridruživanje vrijednosnih tipova");
            PridruživanjeStruktura(1, 5);
            Console.WriteLine();
            Console.WriteLine("Pridruživanje vrijednosnih klasa");
            PridruživanjeKlasa(1, 5);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
