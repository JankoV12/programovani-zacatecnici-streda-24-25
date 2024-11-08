using System.Collections.Concurrent;

namespace mnamina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               1     2   3       4      5
             string text = "hello world";
             
             1. Když vytváříme podmínku, musíme nejdříve napsat datový typ:
                int - celé číslo
                char - jedno písmeno
                string - text (řetězec charů)
                bool - logická hodnota (true/false)
                ...

             2. Název proměnné. Název by měl říkat, co je v ní uložené.

             3. Rovná se.

             4. To, co chci do toho uložit, může být:
                1. Jiná proměnná se stejným datovým typem.
                2. Konkrétní hodnota podle datového typu: 
                    - u stringu musíme přidat dvojité uvozovky (")
                    - u charu musíme přidat jednoduché uvozovky (')
             
             5. Na konci každé funkce je středník (;).

            */

            string veta = "hello world";
            int cislo = 24;
            char pismeno = 'a';
            bool podminka = false;

            // Funkce Console.WriteLine(text); vypíše do terminálu to, co je v závorkách.
            // Mohu vypsat jak proměnnou, tak pevnou hodnotu.

            string text = "ahoj světe";
            int cislokKVypsani = 29;

            Console.WriteLine(text); // Použijeme proměnnou, kterou jsme vytvořili předtím.
            Console.WriteLine("ahoj světe");
            Console.WriteLine(cislokKVypsani); // Můžeme vypsat i číslo.
            Console.WriteLine(podminka); // Vypíše false.

            // Funkce Console.ReadLine(); nám umožňuje načítat od uživatele.
            // Když program dorazí k CR, bude čekat, dokud uživatel nezadá vstup.
            // Funkce pak vrátí hodnotu v typu string.

            string vstup = Console.ReadLine(); // Načtu a uložím do vstup.
            Console.WriteLine(vstup); // Vypíšu, co jsem si uložil.

        }
    }
}
