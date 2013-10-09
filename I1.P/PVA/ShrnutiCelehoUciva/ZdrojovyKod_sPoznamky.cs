using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Shrnurí učiva za školní rok 2012 / 2013
 * Autor: Filip Šedivý <filip.sedivy@email.cz>
 * Licence: GNU GPL 2 -> http://www.gnu.org/licenses/gpl-2.0.html
 * Verze: 1.0
 * 
 * --------- Potřebné znalosti ---------
 * Deklarace proměné s typem
 * Datové typy
 * Vypsání hodnot uložené v proměnné
 * Uložení hodnot do proměnné
 * Cykly - Do, While, For
 * Přiřazování hodnot k proměnným
 * Inkrementace a Dekrementace
 * Operátory
 * Switch
 * Metody
 * Poznámky
 * 
 * --------- Nepotřebné znalosti (jsou zde využity) ---------
 * Pozastavení scriptu  -> System.Threading.Thread.Sleep()
 * Obarvení textu       -> Console.ForegroundColor
 *                      -> Console.ResetColor()
 * Čištení konzole      -> Console.Clear();
 * Ukončení aplikace    -> Environment.Exit(0);
 * 
 */

namespace Shrnutí_učiva
{
    class Program
    {
        // Metoda „hlavnickaAplikace()“ bez návratové a vstupní hodnoty
        static void hlavickaAplikace(){

            // Nastavení barvy textu
            Console.ForegroundColor = ConsoleColor.Red;

                // Výpis textu
                Console.WriteLine("*******************************************");
                    Console.WriteLine("* Shrnutí učiva za školní rok 2012 / 2013 *");

                    // Nastavení barvy textu
                    Console.ForegroundColor = ConsoleColor.Magenta;

                // Výpis textu
                Console.WriteLine("*******************************************");

            // Reset barvy
            Console.ResetColor();
        }

        // Metoda „Autor()“ bez vstupní a návratové hodnoty
        static void Autor() {

            // Zavoláme si metodu “havickaApliace()“
            hlavickaAplikace();
            Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("* Autor: Filip Šedivý                     *");
                    Console.WriteLine("* Email: filip.sedivy@email.cz            *");
                    Console.WriteLine("* Verze: 1.0                              *");
                Console.WriteLine("*******************************************");
            Console.ResetColor();
        }

        // Metoda „ZobrazitMenu()“ bez vstupní a návratové hodnoty
        static void ZobrazitMenu() {
            Console.WriteLine("+---------- MENU ---------+");
            Console.WriteLine("+ 1 | Kalkulačka          +");
            Console.WriteLine("+ 2 | Informace o čísle   +");
            Console.WriteLine("+ 3 | Pole                +");
            obarvitText("+-------------------------+", ConsoleColor.DarkCyan, true);
            Console.WriteLine("+ 9 | Vyčisti konzoli     +");
            Console.WriteLine("+ 0 | Ukončit program     +");
            Console.WriteLine("+-------------------------+");

            // Zeptáme se na na volbu
            Console.Write("\nVaše volba: ");
        }

        // Metoda „obarvitText“ která umí obarvit text bez návratové hodnoty a se vstupními hodnoty
        static void obarvitText(string Text, ConsoleColor Barva, Boolean NovyRadek = false) {
            
            // Nastavíme barvu textu dle parametru “Barva„
            Console.ForegroundColor = Barva;
            
            // Podmínka - Zeptáme se na logickou hodnotu „NovyRadek“
            if (NovyRadek)

                // „NovyRadek“ obsahuje hodnotu true tudíš je konec textu zalomen na nový řádek
                Console.WriteLine(Text);
            else

                // „NovyRadek“ obsahuje hodnotu false tudíš text pokračuje na samém řádku
                Console.Write(Text);

            // Reset barvy
            Console.ResetColor();
        }

        // Metoda „novaRadka()“ bez vstupní a návratové hodnoty
        static void novaRadka() {
            Console.WriteLine();
        }

        // Metoda „soucet()“ se vstupní a návratovou hodnotou
        static double soucet(double a, double b) {

            // Navrátím součet čísel a + b které jsou z parametrů načteni
            return a + b;
        }

        static void Main(string[] args)
        {
            /* Nejznámější datové typy
             *------------------------
             * Int32    -> Celá čísla (int)
             * Int64    -> Celá čísla - větší rozsah (long)
             * String   -> Řetězec znaků
             * Boolean  -> Logická hodnota
             * Char     -> Znak za ASCII tabulky
             * Double   -> Celé číslo
             * Decimal  -> Peněžní hodnota
             */
            
            // Deklarace proměnných -> místo v paměti
            Int32 velikostPole, i, infoOCisle;
            Double prvniCislo, druheCislo;
            Char vyberMenu;
            Boolean menuSpravnost= false;

            // Načtení metody „Autor()“ - bez návratové hodnoty a vstupních parametrů
            Autor();

            // Časovač nastaven na 3s - Využena Dekrementace „i--“
            for (i = 3; i > 0; i--) {
                // Příprava textu pro vypsání proměnné „i“
                Console.Write("Aplikace bude spuštěna za ");

                // Podmínka - pokud „i“ je větší jak 2 ...
                if (i > 2) {
                    // ... tak následující text bude zelený
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                // ... je větší jak 1 ...
                else if (i > 1)
                {
                    // ... tak následující text bude žlutý
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                // ... není ani větší jak 2 ani větší jak 1 ...
                else {
                    // ... tak následující text bude červený
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                // Vypíšeme proměnnou „i“ s nastavenou barvou textu
                Console.Write(i);

                // Resetujeme barevné schéma
                Console.ResetColor();
                
                // Za berevnou proměnnou „i“ vložíme nebarevné jednotky času
                Console.WriteLine(" s");

                // Pozastavení aplikace na 1s
                System.Threading.Thread.Sleep(1000);

                // Vyčistíme konzoli
                Console.Clear();

                // Načteme opět metodu „Autor()“
                Autor();
            }

            // Vyčištení konzole
            Console.Clear();

            // Cyklus Do - While kde While se řadí za konec bloku příkazu Do
            do{
                // Načtení metody „ZobrazitMenu()“ - bez návratové hodnoty a vstupních parametrů
                ZobrazitMenu();

                // Načtení položky výběru z menu do proměnné „“ s typem char
                vyberMenu = Char.Parse(Console.ReadLine());

                /* 
                 * Pomocí přepínače switch budeme kontrolovat vložené data z proměnné „vyberMenu“
                 * Blok přepínaču se vyznačuje pomocí case '': a končí pomocí break;
                 */
                switch (vyberMenu) { 
                    case '1':
                        // Načtení prvního čísla
                        Console.Write("Zadejte první číslo: ");
                        prvniCislo = Double.Parse(Console.ReadLine());

                        // Načtení druhého čísla
                        Console.Write("Zadejte druhé číslo: ");
                        druheCislo = Double.Parse(Console.ReadLine());

                        // Vložení nové řádky
                        novaRadka();
                        
                        // Součet čísel pomocí metody „soucet(a, b)“
                        Console.WriteLine("{0} + {1} = {2}", prvniCislo, druheCislo, soucet(prvniCislo, druheCislo));

                        // Odečtení čísel
                        Console.WriteLine("{0} - {1} = {2}", prvniCislo, druheCislo, prvniCislo - druheCislo);

                        // Násobení čísel
                        Console.WriteLine("{0} * {1} = {2}", prvniCislo, druheCislo, prvniCislo * druheCislo);

                        // Dělení čísel
                        Console.WriteLine("{0} / {1} = {2}", prvniCislo, druheCislo, prvniCislo / druheCislo);

                        // Číslo umocněno na 2
                        Console.WriteLine("{0} ^ 2 = {1}", prvniCislo, Math.Pow(prvniCislo, 2));

                        // Číslo odmocněno na 2
                        Console.WriteLine("2 odmocnina z {0} = {1}", prvniCislo, Math.Sqrt(prvniCislo));

                        // Ukončení bloku
                        break;

                    case '2':
                        // Načtení čísla
                        Console.Write("Zadejte číslo: ");
                        infoOCisle = Int32.Parse(Console.ReadLine());

                        // Vložení nové řádky
                        novaRadka();

                        // Pokud „infoOCisle“ se rovná 0
                        if (infoOCisle == 0) {

                            // Tak vypiš následující text
                            Console.Write("Číslo {0} je ", infoOCisle);
                            obarvitText("0", ConsoleColor.Green, true);
                        }

                        // Pokud „infoOCisle“ je větší jak 0
                        else if (infoOCisle > 0)
                        {
                            // Tak vypiš následující text
                            Console.Write("Číslo {0} je ", infoOCisle);
                            obarvitText("kladné", ConsoleColor.Green, true);
                        }

                         // Pokud „infoOCisle“ se nerovná žádné podmínce
                        else
                        {
                            // Tak vypiš následující text
                            Console.Write("Číslo {0} je ", infoOCisle);
                            obarvitText("záporné", ConsoleColor.Green, true);
                        }

                        // Pokud „infoOCisle“ po dělení neobsahuje žádný zbytek
                        if (infoOCisle % 2 == 0)
                        {
                            // Tak vypiš následující text
                            Console.Write("Číslo {0} je ", infoOCisle);
                            obarvitText("sudé", ConsoleColor.Cyan, true);
                        }

                        // Pokud „infoOCisle“ nesplňuje podmínku
                        else
                        {
                            // Tak vypiš následující text
                            Console.Write("Číslo {0} je ", infoOCisle);
                            obarvitText("liché", ConsoleColor.Cyan, true);
                        }

                        // Vložení nového řádku
                        novaRadka();

                        // Ukončení bloku
                        break;

                    case '3':
                        // Cyklus Do kde ověříme zda-li velikost indexu je větší jak 0
                        do
                        {
                            // Načtení velikosti pole
                            Console.Write("Zadejte velikost pole: ");
                            velikostPole = Int32.Parse(Console.ReadLine());
                            
                            // Podmníka -> Pokud „velikostPole“ je 0 vykonej následující úsek kódu
                            if (velikostPole == 0)

                                // Vypiš červený chybný text s novým řádkem
                                obarvitText("Pole nemůže mít 0 indexů\n", ConsoleColor.Red, true);

                            // Pokud „velikostPole“ je 0 opakuj cyklus
                        } while (velikostPole == 0);

                        // Vytvoření pole
                        Int32[] Pole = new Int32[velikostPole];

                        // Načtení hodnot do pole
                        for (i = 0; i < velikostPole; i++)
                        {
                            // Vstupní část kde „i + 1“ 
                            Console.Write("{0}. hodnota -> ", i + 1);

                            // Do pole „Pole“ s indexem „i“ přiřadíme číslo (Int32)
                            Pole[i] = Int32.Parse(Console.ReadLine());
                        }

                        obarvitText("\nVypsání hodnot pole", ConsoleColor.Cyan, true);

                        // Vypsání hodnot z pole
                        for (i = 0; i < velikostPole; i++)
                        {

                            // Vypíšeme hodnotu pole kde k „i“ přičteme +1 
                            Console.WriteLine("{0}. hodnota -> {1}", i + 1, Pole[i]);

                            // Na 200ms uděláme pauzu, aby hodnoty nebyly vypisovány rychle
                            System.Threading.Thread.Sleep(200);
                        }

                        // Nová řádka
                        novaRadka();
                        // Ukončení bloku
                        break;

                    case '9':
                        Console.Clear();

                        // Ukončení bloku
                        break;

                    case '0':
                        // Bezpečné ukončení aplikace
                        Environment.Exit(0);

                        // Ukončení bloku
                        break;

                    // Výchozí hodnota pokud není žadný blok (case) správný
                    default:
                        // Proměnné „menuSpravnost“ nastavíme chybnou volbu
                        menuSpravnost = false;

                        // Zobrazíme červený text a pomocí třetího parametru nastavíme nový řádek
                        obarvitText("Zadaná hodnota je chybná\n", ConsoleColor.Red, true);

                        // Ukončení bloku
                        break;

                }

                // Pokud proměnná „menuSpravnost“ se nerovná true -> opakuj cyklus Do
            }while(menuSpravnost != true);
        }
    }
}
