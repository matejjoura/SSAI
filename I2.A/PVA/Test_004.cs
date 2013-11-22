using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, r = 3, s = 4;

            int[,] pole;
            pole = new int[r, s];

            pole[0, 0] = 1;
            pole[0, 1] = -2;
            pole[0, 2] = -5;
            pole[0, 3] = 4;
            pole[1, 0] = -1;
            pole[1, 1] = -12;
            pole[1, 2] = 5;
            pole[1, 3] = 6;
            pole[2, 0] = -9;
            pole[2, 1] = 12;
            pole[2, 2] = 15;
            pole[2, 3] = 3;

            Console.WriteLine();

            Console.WriteLine("Byla zadána čísla:");
            for (i = 0; i < r; i++)
            {
                for (j = 0; j < s; j++)
                {
                    Console.Write(pole[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //PÍSEMKA----------------------------------------------------

            /*
             * Skupina A
             * 1.) Součet z libovolného řádku
             * 2.) Součet čísel z 3 řádku (2 index)
             */

            //1
            Console.WriteLine("\n===== Součet čísel z libovolného řádku =====");

            Console.Write("Zadejte z jakého řádku chcete sečíst: ");
            int radek = Convert.ToInt32(Console.ReadLine());
            int soucet = 0;
            for (int z = 0; z < s; z++)
                soucet = pole[radek - 1, z];
            Console.WriteLine("Součet čísel z {0} řádku je: {1}", radek, soucet);

            //2
            Console.WriteLine("\n===== Součet čísel z 3 řádku =====");
            soucet = 0; // Musí být 0!
            for (int z = 0; z < s; z++)
                soucet += pole[2, z];
            Console.WriteLine("Součet čísel: {0}", soucet);

            /*
            * Skupina B
            * 
            * 1.) Najděte minimum z 2 řádku (1 index)
            * 2.) Součet sudých čísel z 3 sloupce (2 index)
            */

            //1 
            Console.WriteLine("\n====== Nejmenší číslo ======");
            int minimum = pole[1, 0]; // Nezapomenout!
            for (int z = 0; z < s; z++)
                if (minimum > pole[1, z])
                    minimum = pole[1, z];
            Console.WriteLine("Nejmenší číslo je: {0}", minimum);

            //2 
            Console.WriteLine("\n====== Součet čísel ======");
            soucet = 0;
            for (int z = 0; z < r; z++)
                soucet += pole[z, 2];
            Console.WriteLine("Součet čísel je: {0}", soucet);

            //PÍSEMKA----------------------------------------------------
            Console.ReadLine();
        }
    }
}
