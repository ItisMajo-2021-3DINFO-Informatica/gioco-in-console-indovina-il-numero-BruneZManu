using System;

namespace GiocoIndovinaIlNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("E'stato generato un numero casuale, tenta di indovinare qual è!");
            Console.WriteLine("Il punteggio parte da 100000 e scende in base ai tentativi!");


            Random N = new Random();
            int num = N.Next(1, 100);
            int tent = 1;
            int i = 0;
            int punteggio = 100000;

            do {
                Console.WriteLine("Scrivi un numero: ");
                i += 1;
                tent = Convert.ToInt32(Console.ReadLine());
                if (tent < num)
                {
                    Console.WriteLine("Il numero è più alto");
                    Console.WriteLine("");
                }
                else if (tent > num)
                {
                    Console.WriteLine("Il numero è più basso");
                    Console.WriteLine("");
                }

            } while (tent != num);

            Console.WriteLine($"Indovinato! Hai fatto {i} tentativi e Il punteggio è di {punteggio - i * 1000} ");
            Console.ReadKey();
        }
                                       
    }
}
