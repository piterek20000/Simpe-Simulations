using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Diablo_II_Simulator
{
    class New_Character
    {
        /// <summary>
        /// Metoda tworzaca nowa postac
        /// </summary>
        /// <param name="Data_Base"></param>
        public static void Create_Character(List<Characters> Data_Base)
        {
            string nazwa;

            nazwa = Get_Name();

            //Return there 
            AAAAAAA:

            Schow_Choices();

            string your_choise;
            your_choise = Your_Choice();

            Console.Clear();

            switch (your_choise)
            {
                case "A":
                    Console.WriteLine("\n\tAmazonka created!");
                    Data_Base.Add(new Amazonka(nazwa));
                    break;

                case "B":
                    Console.WriteLine("\n\tNecromant created!");
                    Data_Base.Add(new Nekromanta(nazwa));
                    break;

                case "C":
                    Console.WriteLine("\n\tBarbarian created!");
                    Data_Base.Add(new Barbarzynca(nazwa));
                    break;

                case "D":
                    Console.WriteLine("\n\tPaladyn created!");
                    Data_Base.Add(new Paladyn(nazwa));
                    break;

                case "E":
                    Console.WriteLine("\n\tWitch created!");
                    Data_Base.Add(new Czarodziejka(nazwa));
                    break;

                case "F":
                    Console.WriteLine("\n\tAssassin created!");
                    Data_Base.Add(new Zabojczyni(nazwa));
                    break;

                case "G":
                    Console.WriteLine("\n\tDrui created!");
                    Data_Base.Add(new Druid(nazwa));
                    break;

                case "H":
                    Console.WriteLine("\n\tExit!");
                    Thread.Sleep(2000);

                    //return to Characters Panel
                    Program.Characters_Panel();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("\n!!!Number out of scope!!!\n\a");
                    Thread.Sleep(2000);

                    goto AAAAAAA;
            }

            Console.ReadLine();

            //return to Characters Panel
            Program.Characters_Panel();
        }

        /// <summary>
        /// Metoda pobierajaca string 
        /// </summary>
        /// <returns>Pass Name</returns>
        private static string Get_Name()
        {
            string nazwa;
            Console.Write("\n\tGive character name: ");
            nazwa = Console.ReadLine();
            Console.Clear();
            return nazwa;
        }

        /// <summary>
        /// Wyswietla panel mozliwosci wyboru postaci
        /// </summary>
        private static void Schow_Choices()
        {
            Console.WriteLine("\n\tChoose class:\n");
            Console.WriteLine("\tA) Amazonka");
            Console.WriteLine("\tB) Necromant");
            Console.WriteLine("\tC) Barbarrian");
            Console.WriteLine("\tD) Paladyn");
            Console.WriteLine("\tE) Witcher");
            Console.WriteLine("\tF) Assassin");
            Console.WriteLine("\tG) Druid\n");
            Console.WriteLine("\tH) Exit");
        }

        /// <summary>
        /// Pobiera lancuch string i ustawia na duze litery
        /// </summary>
        /// <returns>Pass letter</returns>
        private static string Your_Choice()
        {
            string y;
            y = Console.ReadLine();

            return y.ToUpper();
        }
    }
}
