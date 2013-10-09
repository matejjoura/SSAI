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
 */

namespace Shrnutí_učiva
{
    class Program
    {
        static void hlavickaAplikace(){
            Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*******************************************");
                    Console.WriteLine("* Shrnutí učiva za školní rok 2012 / 2013 *");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("*******************************************");
            Console.ResetColor();
        }

        static void Autor() {
            hlavickaAplikace();
            Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("* Autor: Filip Šedivý                     *");
                    Console.WriteLine("* Email: filip.sedivy@email.cz            *");
                    Console.WriteLine("* Verze: 1.0                              *");
                Console.WriteLine("*******************************************");
            Console.ResetColor();
        }

        static void ZobrazitMenu() {
            Console.WriteLine("+---------- MENU ---------+");
            Console.WriteLine("+ 1 | Kalkulačka          +");
            Console.WriteLine("+ 2 | Informace o čísle   +");
            Console.WriteLine("+ 3 | Pole                +");
            obarvitText("+-------------------------+", ConsoleColor.DarkCyan, true);
            Console.WriteLine("+ 9 | Vyčisti konzoli     +");
            Console.WriteLine("+ 0 | Ukončit program     +");
            Console.WriteLine("+-------------------------+");

            Console.Write("\nVaše volba: ");
        }

        static void obarvitText(string Text, ConsoleColor Barva, Boolean NovyRadek = false) {
            Console.ForegroundColor = Barva;
            if (NovyRadek)
                Console.WriteLine(Text);
            else
                Console.Write(Text);
            Console.ResetColor();
        }

        static void novaRadka() {
            Console.WriteLine();
        }

        static double soucet(double a, double b) {
            return a + b;
        }

        static void Main(string[] args)
        {
            Int32 velikostPole, i, infoOCisle;
            Double prvniCislo, druheCislo;
            Char vyberMenu;
            Boolean menuSpravnost= false;
			
            Autor();
            for (i = 3; i > 0; i--) {
                Console.Write("Aplikace bude spuštěna za ");
                if (i > 2) {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (i > 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.Write(i);
                Console.ResetColor();
                Console.WriteLine(" s");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                Autor();
            }
            Console.Clear();
            do{
                ZobrazitMenu();
                vyberMenu = Char.Parse(Console.ReadLine());
                switch (vyberMenu) { 
                    case '1':
                        Console.Write("Zadejte první číslo: ");
                        prvniCislo = Double.Parse(Console.ReadLine());
                        Console.Write("Zadejte druhé číslo: ");
                        druheCislo = Double.Parse(Console.ReadLine());
                        novaRadka();
                        Console.WriteLine("{0} + {1} = {2}", prvniCislo, druheCislo, soucet(prvniCislo, druheCislo));
                        Console.WriteLine("{0} - {1} = {2}", prvniCislo, druheCislo, prvniCislo - druheCislo);
                        Console.WriteLine("{0} * {1} = {2}", prvniCislo, druheCislo, prvniCislo * druheCislo);
                        Console.WriteLine("{0} / {1} = {2}", prvniCislo, druheCislo, prvniCislo / druheCislo);
                        Console.WriteLine("{0} ^ 2 = {1}", prvniCislo, Math.Pow(prvniCislo, 2));
                        Console.WriteLine("2 odmocnina z {0} = {1}", prvniCislo, Math.Sqrt(prvniCislo));
                        break;

                    case '2':
                        Console.Write("Zadejte číslo: ");
                        infoOCisle = Int32.Parse(Console.ReadLine());
                        novaRadka();
                        if (infoOCisle == 0) {
                            Console.Write("Číslo {0} je ", infoOCisle);
                            obarvitText("0", ConsoleColor.Green, true);
                        }
                        else if (infoOCisle > 0)
                        {
                            Console.Write("Číslo {0} je ", infoOCisle);
                            obarvitText("kladné", ConsoleColor.Green, true);
                        }
                        else
                        {
                            Console.Write("Číslo {0} je ", infoOCisle);
                            obarvitText("záporné", ConsoleColor.Green, true);
                        }
						
                        if (infoOCisle % 2 == 0)
                        {
                            Console.Write("Číslo {0} je ", infoOCisle);
                            obarvitText("sudé", ConsoleColor.Cyan, true);
                        }
                        else
                        {
                            Console.Write("Číslo {0} je ", infoOCisle);
                            obarvitText("liché", ConsoleColor.Cyan, true);
                        }
                        novaRadka();
                        break;

                    case '3':
                        do
                        {
                            Console.Write("Zadejte velikost pole: ");
                            velikostPole = Int32.Parse(Console.ReadLine());
                            if (velikostPole == 0)
                                obarvitText("Pole nemůže mít 0 indexů\n", ConsoleColor.Red, true);
                        } while (velikostPole == 0);
                        Int32[] Pole = new Int32[velikostPole];
                        for (i = 0; i < velikostPole; i++)
                        {
                            Console.Write("{0}. hodnota -> ", i + 1);
                            Pole[i] = Int32.Parse(Console.ReadLine());
                        }
                        obarvitText("\nVypsání hodnot pole", ConsoleColor.Cyan, true);
                        for (i = 0; i < velikostPole; i++)
                        {
                            Console.WriteLine("{0}. hodnota -> {1}", i + 1, Pole[i]);
                            System.Threading.Thread.Sleep(200);
                        }
                        novaRadka();
                        break;

                    case '9':
                        Console.Clear();
                        break;

                    case '0':
                        Environment.Exit(0);
                        break;
						
                    default:
                        menuSpravnost = false;
                        obarvitText("Zadaná hodnota je chybná\n", ConsoleColor.Red, true);
                        break;
                }
            }while(menuSpravnost != true);
        }
    }
}