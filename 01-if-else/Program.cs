using System.Collections.Concurrent;

namespace mnamina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             větvení kodu je velmi důležitá věc v programování bez ní by jsme se neobešli
            */

            bool podminka = false;
            bool podminka2 = true;

            if (podminka)
            {         // pokud je hodnota v podmince true tak to provede část kodu v uzavíracích závorkách
                Console.WriteLine("prvni podmínka je true");
            }
            else if (podminka2)
            {         // pokud předchozí podmínky byla false a tahle (podminka2) tak to provede část kodu v uzavíracích závorkách
                Console.WriteLine("druhá podmínka je tru");
            }
            else
            {         // pokud ani jedna z předchozích podmínek (podminka, podminka2) nebyla true tak to provede část kodu v uzavíracích závorkách
                Console.WriteLine("ani jedna z podmínek není true");
            }



            // v podmínkách můžeme používat i logické oparace která znáte z matiky (<,<=,> nebo =>)

            int cislo = 10;

            if (cislo > 5)
            {
                Console.WriteLine(cislo + " je větší než pět");
            }
            else
            {
                Console.WriteLine(cislo + " je menší nebo rovno než pět");
            }


            //pro zjištění jestli jsou data v proměních stejná používáme dvojtý rovnáse "==" a ne jako v matice jen jedno "="

            string mojeTajneHeslo = "1234";
            string zadaneHeslo = Console.ReadLine();
            if (mojeTajneHeslo == zadaneHeslo)
            {
                Console.WriteLine("přistup povolen");
            }
            else
            {
                Console.WriteLine("přístup zamítnut");
            }

        }
    }
}
