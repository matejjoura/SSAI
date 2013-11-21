using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* Tvorba dvourozměrného pole, vč ukládání dat či výpisu
* Autor: Filip Šedivý <filip.sedivy@email.cz>
* Licence: GNU GPL 2 -> http://www.gnu.org/licenses/gpl-2.0.html
* Verze: 1.0
*
* --------- Potřebné znalosti ---------
* Deklarace proměné s typem
* Datové typy
* Vypsání hodnot uložené v proměnné
* Uložení hodnot do proměnné
* Cykly - For
* Přiřazování hodnot k proměnným
* Inkrementace a Dekrementace
* Operátory
* Tvorba pole 
*
* --------- Nepotřebné znalosti (jsou zde využity) ---------
*
*/

namespace Dvourozměrné_pole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Deklarace proměnných
            int sloupce, radky;

            // Nadpis (HeadLine)
            Console.WriteLine("====== Nastavení hodnot pole =====");

            // Načtení dat pro dynamické pole (uživatel zadá data z klavesnice)
            Console.Write("Zadejte počet indexů pro vnější pole (řádky): ");
            radky = Convert.ToInt32(Console.ReadLine());

            Console.Write("Zadejte počet indexů pro vnitřní pole (sloupce): ");
            sloupce = Convert.ToInt32(Console.ReadLine());

            /*
             * Nyní je nutné nadeklarovat dvourozměrné pole. Dvourozměrné
             * nebo-li multidimenzionální pole vytvoříme podobně jako jednorozměrné,
             * akorát vložíme do prvních hranatých závorek čárku a do druhé závorky 
             * nadeklarujeme dvě hodnoty
             * 
             * Naše pole bude datového typu int - tzn. můžeme psát veškerá
             * celočíselné hodnoty
             */

            int[,] Pole = new int[radky, sloupce];

            // Nadpis (HeadLine)
            Console.WriteLine("\n====== Vložení hodnot do pole =====");

            /* 
             * Pomocí dvou cyklu vnořených do sebe načteme hodnoty.
             * 
             * Velikost cyklů vytváříme ve stejném pořadí jako deklarace pole.
             * V případě záměny se může stát že Pole přeteče a compilator vyhodí
             * IndexOutOfRangeException. Proti tomu se dá bránit pomocí bloku try
             */
            for (int i = 0; i < radky; i++)
                /*
                 * Nezapomeňte že zde nesmíte navolit stejnou proměnnou jako v
                 * předchozím cyklu. V případě zvolení proměnné i bude automaticky
                 * měnit velikost proměnné a může se stát že Pole přeteče a
                 * compilator vyhodí IndexOutOfRangeException.
                 */
                for (int z = 0; z < sloupce; z++)
                {
                    Console.Write("Řádek: {0}, Sloupec: {1}. Vaše hodnota: ", i + 1, z + 1);

                    /*
                     * Uložení hodnoty do pole
                     * Jelikož je navolen datový typ Int, je nutné hodnoty
                     * přetypovat pomocí třídy Convert. Convert nepožívejte v případě
                     * že datový typ je String.
                     */
                    Pole[i, z] = Convert.ToInt32(Console.ReadLine());
                }

            // Nadpis (HeadLine)
            Console.WriteLine("\n====== Výpis hodnot pole =====");

            // Nyní provedeme pomocí stejné cyklu výpis. Zde již můžeme použít stejné proměnné
            for (var i = 0; i < radky; i++)
                for (var z = 0; z < sloupce; z++)
                    Console.WriteLine("Řádek: {0}, Sloupec: {1}. Uložená hodnota: {2}", i + 1, z + 1, Pole[i, z]);

            // Nadpis (HeadLine)
            Console.WriteLine("\n====== Výpis hodnot z 0 indexu =====");

            /*
             * Vypíšeme pouze hodnoty z indexu 0 (pro nás řádek 1)
             * 
             * Jelikož víme že budeme vypisovat hodnoty pouze z 0 indexu, není nutné
             * zakládat dva cykly nýbrž stačí jeden.
             */
            for (var i = 0; i < sloupce; i++)
                Console.WriteLine("Řádek: 1, Sloupec: {0}. Uložená hodnota: {1}", i + 1, Pole[0, i]);

            // Nadpis (HeadLine)
            Console.WriteLine("\n====== Sečtení všech čísel =====");

            /*
             * Pro součet všech čísel využijeme opět dva cykly. Před tím potřebujeme již ale 
             * deklarovanou hodnotu int s 0. Nepoužíváme Pole[0, 0] jelikož přičítáme 
             * položku k nule.
             */
            int soucet = 0;
            for (var i = 0; i < radky; i++)
                for (var z = 0; z < sloupce; z++)
                    soucet += Pole[i, z];
            Console.WriteLine("Součet všech hodnot je: {0}", soucet);


            // Nadpis (HeadLine)
            Console.WriteLine("\n====== Zjištení nejmenšího čísla v celém poli =====");

            /*
             * Pokud budeme zjišťovat nejmenší číslo, musíme k nově deklarované proměnné
             * přiřadit číslo z nultého indexu = Pole[0, 0].
             */
            int nejmensiCislo = Pole[0, 0];
            for (var i = 0; i < radky; i++)
                for (var z = 0; z < sloupce; z++)
                    if (nejmensiCislo > Pole[i, z])
                        nejmensiCislo = Pole[i, z];
            Console.Write("Nejmenší číslo z celého pole je: {0}", nejmensiCislo);
                    

            // Zábrana proti ukončení
            Console.ReadLine();

            // Hodně štěstí při učení, či při písemce :)
        }
    }
}
