using System.Collections.Concurrent;

namespace mnamina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Cykly jsou také důležité. Máme dva základní druhy:
                    FOR - když víme, kolikrát se to bude opakovat
                    WHILE - když chceme, aby se to opakovalo, dokud nebude splněna nějaká podmínka
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
                    1. Vytvořím proměnnou cislo a uložíme do ní hodnotu 0
                    2. Zkontroluje, zda je podmínka splněna. Pokud je:
                        - true = provede to, co je ve složených závorkách (kroky 3 a 4)
                        - false = přeskočí to za složené závorky a pokračuje dál (krok 5)

                    Podmínka je v našem případě `cislo <= 5` a každým projetím cyklu přičtu 1.
                    Tento cyklus se projede 6krát (indexujeme od nuly), tedy pro hodnoty `cislo` od 0 do 5.
                    Program vypíše:
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
                Console.WriteLine("opakuju " + i + "."); // 3. Opraveno: měl by se použít i, ne cislo
            }
            Console.WriteLine("konec");

            /*
                FOR má tři části:
                    1. Tato část kódu se spustí hned na začátku (vytvoříme proměnnou `i` a uložíme do ní hodnotu 0)
                    2. Tato část je podobná podmínce ve WHILE. Zkontroluje, zda je podmínka splněna, a pokud ano, provede kód ve složených závorkách (v našem případě se to bude opakovat, dokud `i` nebude větší než 5)
                    3. Tato část kódu se provede vždy, když program projde jedním cyklem (v našem případě se vždy přičte 1 k proměnné `i`)

                Výstup bude stejný jako u WHILE:
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
