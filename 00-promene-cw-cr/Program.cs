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
             
             1. když vytváříme podmínku musíme nejdřív napíšem datoví typ:
                int - celé číslo
                char - jednou písmeno
                string - text (řetězec charu)
                bool - logická hodnota (true/false)
                ...

             2. název proměný. Nazev by měl říkat co je v tom uložené

             3. rovná se

             4. to co chci do toho uložit může to být:
                1. jiné proměná se stejným datovým typem
                2. konkrétní hodnota podle datového typu 
                    - u stringu musíme přidat dvojté uvozovky (")
                    - u charu musíme přidat jednoduché uvozovky (')
             
             5. na konci každé funkce středník (;)

            */

            string veta = "hello world";
            int cislo = 24;
            char pismeno = 'a';
            bool podminka = false;

            // funkce Console.WriteLine(text); vypíše do terminalu to co je v závorkách
            // mohu vypsat jak proměnou tak pevnou hodnotu

            string text = "ahoj světe";
            int cislokKVypsani = 29;

            Console.WriteLine(text); //použijem proměnou co jsme vytvořili před tím
            Console.WriteLine("ahoj světe");
            Console.WriteLine(cislokKVypsani); // mužem vypsat i číslo
            Console.WriteLine(podminka); //vypíše false

            //funkce Console.ReadLine(); nám umožňuje načítat od uživateke
            //když program dorazí k cr bude čekat dokud uživatel nezadá vstup
            //funkce pak vrátí hodnotu v typu string

            string vstup = Console.ReadLine(); //načtu a uložim do vstup
            Console.WriteLine(vstup); // vypíšu co jsem si uložil

        }
    }
}
