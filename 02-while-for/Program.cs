using System.Collections.Concurrent;

namespace mnamina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                cykli jsou taky důležitě. Máme dva druhy:
                    FOR - když víme kolikrát se to bude opakovat
                    WHILE - když chceme aby se to opakovalo dokud nebude splněné nějaká podmínka
            */


            int cislo = 0; // 1.

            while (cislo <= 5) // 2.
            {
                Console.WriteLine("opakuju " + cislo + "."); // 3.
                cislo = cislo + 1; // 4.
            }
            Console.WriteLine("konec"); // 5.

            /*
                WHILE krok po kroku:
                    1. vytvořím proměnou cislo do ktere uložim nulu
                    2. zkontroluje zda je podminka, pokud je
                        - true = udělá to  co je ve složených závorkách (krok 3 a 4)
                        - false = skočí to za složené závorky a bude pokračovat dát (krok 5)

                    podmínka je v našem případě cislo <= 5 a každým projetím ciklu přičtu jedna
                    takže se ciklus projede 6 (indexujem od nuli)
                    program vypíše:
                        opakuju 0.
                        opakuju 1.
                        opakuju 2.
                        opakuju 3.
                        opakuju 4.
                        opakuju 5.
                        konec
            */


            //       1        2     3
            for (int i = 0; i <= 5; i++) {
                Console.WriteLine("opakuju " + cislo + ".");
            }
            Console.WriteLine("konec");

            /*
                FOR má tří části:
                    1. tahle čast kodu se spustí hned na začátku (v našem vytvoříme proměnou i a uložíme do ní 0)
                    2. Tohle je dost podobný jak v WHILE. Skontroluju podmínu a pokud je true udělám to co je v složených závorkách (v našem se to bude opakov dokud i nebude 6 nebo vyšší)
                    3. Tahle část kodu se udělá vždy když program doxjede na konec složených závorkách (v našem případě přičte jedna)
            
                výpis bude stejný jako u WHILE:
                        opakuju 0.
                        opakuju 1.
                        opakuju 2.
                        opakuju 3.
                        opakuju 4.
                        opakuju 5.
                        konec
             
             */
        }
    }
}
