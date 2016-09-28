using System;

namespace Zahl_schätzen
{
    class Program
    {
        static void Main(string[] args)
        {

            int Zahl, Eingabe, Zaehler=0;
            Random Zufall = new Random();
            Zahl = Zufall.Next(100) + 1;
            Console.WriteLine("Ich denke mir eine Zahl zwischen 1 und 100");

            do
            {
                Console.WriteLine("Rate Mal:");
                Eingabe = Convert.ToInt32(Console.ReadLine());
                if (Eingabe < Zahl)
                {
                    Console.WriteLine("zu klein");

                    Zaehler = Zaehler + 1;
                }

                if (Eingabe > Zahl)
                {
                    Console.WriteLine("zu groß");

                    Zaehler = Zaehler + 1;
                }


               
              //  Console.WriteLine("Deine Versuchsanzahl:" + Convert.ToString(Zaehler) );



            }
            while (Eingabe != Zahl);

            if (Eingabe == Zahl)
            Console.WriteLine("Richtig!");
            Console.WriteLine("Deine Versuchsanzahl:" + Convert.ToString(Zaehler));

            




            Console.ReadKey();
            



            }
    }
}

















