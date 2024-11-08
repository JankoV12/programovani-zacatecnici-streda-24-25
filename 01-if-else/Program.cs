using System.Collections.Concurrent;

namespace mnamina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Větvení kódu je velmi důležitá věc v programování, bez ní bychom se neobešli.
            */

            bool podminka = false;
            bool podminka2 = true;

            if (podminka)
            {         // Pokud je hodnota v podmínce true, provede se část kódu v uzavíracích závorkách.
                Console.WriteLine("první podmínka je true");
            }
            else if (podminka2)
            {         // Pokud předchozí podmínka byla false a tato (podminka2) je true, provede se část kódu v uzavíracích závorkách.
                Console.WriteLine("druhá podmínka je true");
            }
            else
            {         // Pokud ani jedna z předchozích podmínek (podminka, podminka2) nebyla true, provede se část kódu v uzavíracích závorkách.
                Console.WriteLine("ani jedna z podmínek není true");
            }



            // V podmínkách můžeme používat i logické operace, které znáte z matematiky (<, <=, > nebo >=).

            int cislo = 10;

            if (cislo > 5)
            {
                Console.WriteLine(cislo + " je větší než pět");
            }
            else
            {
                Console.WriteLine(cislo + " je menší nebo rovno pěti");
            }


            // Pro zjištění, jestli jsou data v proměnných stejná, používáme dvojité rovná se "==" a ne jako v matematice jen jedno "=".

            string mojeTajneHeslo = "1234";
            string zadaneHeslo = Console.ReadLine();
            if (mojeTajneHeslo == zadaneHeslo)
            {
                Console.WriteLine("přístup povolen");
            }
            else
            {
                Console.WriteLine("přístup zamítnut");
            }

        }
    }
}
