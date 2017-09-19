using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Diablo_II_Simulator.Bosses;

namespace Diablo_II_Simulator
{
    partial class Program
    {
        #region Colections

        //Characters collection
        static List<Characters> Characters_List = new List<Characters>();

        //Converted Characters stats (string chain form)
        static List<string> Game_Saves = new List<string>();

        //Bosses collection
        static List<Boss> Boss_List = new List<Boss>();

        #endregion

        #region Static parametrs

        //Check if Character missed
        static bool Miss;

        //Random Number Generator for Attack
        static int Attack_RNG;

        //Taken Dmg form Character/Boss
        static int Dmg;

        #endregion

        #region Panels Methods

        /// <summary>
        /// Main Panel Description
        /// </summary>
        public static void Main_Panel()
        {
            Console.Clear();

            Console.WriteLine("\n\n\t\t MAIN PANEL\n");
            Console.WriteLine("\t A) Load Saves");
            Console.WriteLine("\t B) Characters");
            Console.WriteLine("\t C) Fight simulation");
            Console.WriteLine("\t D) Save");
            Console.WriteLine("\t E) Exit");

            Main_Panel_Switch();
        }

        /// <summary>
        /// Characters Panel Description
        /// </summary>
        public static void Characters_Panel()
        {
            Console.Clear();

            Console.WriteLine("\n\n\t\t CHARACTERS PANEL\n");
            Console.WriteLine("\t A) Create new Characters");
            Console.WriteLine("\t B) Show all Characters");
            Console.WriteLine("\t C) Delete Character");
            Console.WriteLine("\t D) Back");

            Character_Panel_Switch();
        }

        /// <summary>
        /// Show Characters Panel Description
        /// </summary>
        private static void Show_Characters_Panel()
        {
            Console.Clear();

            Console.WriteLine("\n\n\t\t SHOW CHARACTERS PANEL");
            Console.WriteLine("\n\t A) Sorted by Name");
            Console.WriteLine("\n\t B) Sorted by lvl");
            Console.WriteLine("\n\t C) Sorted by lvl > X");
            Console.WriteLine("\n\t D) Back");

            Show_Characters_Panel_Switch();
        }

        /// <summary>
        /// Fight Simulation Panel Description
        /// </summary>
        private static void Fight_Simulation_Panel()
        {
            Console.Clear();

            Console.WriteLine("\n\n\t\t FIGHT SIMULATION PANEL");
            Console.WriteLine("\n\n\t A) Select Character");
            Console.WriteLine("\n\t B) Save Game");
            Console.WriteLine("\n\t C) Back");

            Fight_Simulation_Panel_Switch();
        }

        #endregion

        #region Panels Switch Methods

        /// <summary>
        /// Main Panel Options
        /// </summary>
        private static void Main_Panel_Switch()
        {
            switch(Your_Choise())
            {
                case "A":
                            Load_Saves();
                            break;

                case "B":
                            Characters_Panel();
                            break;

                case "C":
                            Fight_Simulation_Panel();
                            break;

                case "D":
                            Save_Main_Panel();
                            break;

                case "E":
                            Say_Bay();
                            break;

                default:
                            Out_Of_Scope_Main_Panel();
                            break;
            }
        }

        /// <summary>
        /// Character Panel Options
        /// </summary>
        private static void Character_Panel_Switch()
        {
            switch (Your_Choise())
            {
                case "A":
                            New_Character.Create_Character(Characters_List);
                            break;
                case "B":
                            Show_Characters_Panel();
                            break;

                case "C":
                            Delete_Character();
                            break;

                case "D":
                            Main_Panel();
                            break;

                default:
                            Out_Of_Scope_Characters_Panel();
                            break;

            }
        }

        /// <summary>
        /// Show Characters Panel Options
        /// </summary>
        private static void Show_Characters_Panel_Switch()
        {
            switch (Your_Choise())
            {
                case "A":
                            Order_By_Name();
                            break;

                case "B":
                            Order_By_Lvl();
                            break;

                case "C":
                            Order_By_XLvl();
                            break;

                case "D":
                            Characters_Panel();
                            break;

                default:
                            Out_Of_Scope_Show_Characters_Panel();
                            break;
            }
        }

        /// <summary>
        /// Fight Simulation Panel Options
        /// </summary>
        private static void Fight_Simulation_Panel_Switch()
        {
            switch (Your_Choise())
            {
                case "A":
                            Chose_Fighter();
                            Console.ReadLine();
                            break;
                case "B":
                            Save();
                            break;

                case "C":
                            Main_Panel();
                            break;

                default:
                            Out_Of_Scope_Fight_Simulation();
                            break;
            }
        }

        #endregion

        #region Out of scope Methods

        /// <summary>
        /// Choice out of scope for Main Panel
        /// </summary>
        private static void Out_Of_Scope_Main_Panel()
        {
            Console.WriteLine("\n\n\tChoice out of scope\a");

            Thread.Sleep(1000);

            Console.Clear();

            Main_Panel();
        }

        /// <summary>
        /// Choice out of scope for Characters Panel
        /// </summary>
        private static void Out_Of_Scope_Characters_Panel()
        {
            Console.WriteLine("\n\n\tChoice out of scope\a");

            Thread.Sleep(1000);

            Console.Clear();

            Characters_Panel();
        }

        /// <summary>
        /// Choice out of scope for Show Characters Panel
        /// </summary>
        private static void Out_Of_Scope_Show_Characters_Panel()
        {
            Console.WriteLine("\n\n\tChoice out of scope\a");

            Thread.Sleep(1000);

            Console.Clear();

            Show_Characters_Panel();
        }

        /// <summary>
        /// Choice out of scope for Show Characters Panel
        /// </summary>
        private static void Out_Of_Scope_Fight_Simulation()
        {
            Console.WriteLine("\n\n\tChoice out of scope\a");

            Thread.Sleep(1000);

            Console.Clear();

            Fight_Simulation_Panel();
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// Method show all characters 
        /// </summary>
        private static void Show_All_Characters()
        {
            foreach (var item in Characters_List)
            {
                item.Class_Introduction();
            }

            Console.ReadLine();
            Characters_Panel();
        }

        /// <summary>
        /// Method loading saves
        /// </summary>
        private static void Load_Saves()
        {
            //Load informations about characters from file
            Load.Load.Load_Saves(ref Game_Saves);
            
            //Check if file with saves exist
            if (File.Exists(Load.Load.curFile))
            {
                //Create Characters basing on Game_Saves list
                Load.Load.Load_Saves(ref Game_Saves, ref Characters_List);
            }
        }

        /// <summary>
        /// Method say By
        /// </summary>
        private static void Say_Bay()
        {
            Console.Clear();

            Console.WriteLine("\n\n\n\t\tBye!\a");

            Thread.Sleep(2000);
        }

        /// <summary>
        /// Method returns Your choice
        /// </summary>
        /// <returns>Upper letter</returns>
        private static string Your_Choise()
        {
            string xxxx;

            Console.Write("\n\t\t Choice: ");

            xxxx = Console.ReadLine();

            return xxxx.ToUpper();
        }

        /// <summary>
        /// Method Delete pointed Character from list
        /// </summary>
        private static void Delete_Character()
        {
            Console.Clear();

            if (Characters_List.Count == 0)
            {
                Console.WriteLine("\n\n\t Characters list is empty");

                Thread.Sleep(1500);

                Characters_Panel();
            }

            else
            {
                    AAA:

                //Pointer
                int Pointer = 1;

                Console.WriteLine("\n\n\t\t CHARACTERS: \n\n");

                foreach (var item in Characters_List)
                {
                    Console.Write("\n\tNr: " + Pointer + "\t");
                    item.Class_Introduction();
                    Console.WriteLine("\n");
                    Pointer++;
                }

                int nr;

                try
                {
                    Console.Write("\n\n\tGive a number of Character to delete, or 0 for back to Character Panel: ");
                    nr = Int32.Parse(Console.ReadLine()) - 1;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\tChoice out of scope!");
                    Console.WriteLine(e.Message);
                    Thread.Sleep(2000);
                    Console.Clear();

                    goto AAA;
                }

                //Return to Main Panel
                if (nr == -1) Characters_Panel();

                else
                {
                    if (nr > Pointer)
                    {
                        Console.WriteLine("\n\n\tNumber out of scope!!!");
                        Thread.Sleep(2000);
                        Console.Clear();

                        goto AAA;
                    }

                    else
                    {
                        Console.WriteLine("\n\n\t Are You shure?\t 1 = YES, else = NO");


                        //TODO: Add try block (in case when we put letter)
                        bool answer = Int32.Parse(Console.ReadLine()) == 1 ? true : false;

                        if (answer)
                        {
                            Characters_List[nr].Class_Introduction(); Console.WriteLine("\t\tDELETED");
                            Characters_List.RemoveAt(nr);

                            Console.ReadLine();
                        }

                        //Return to Characters Panel
                        Characters_Panel();
                    }
                }
            }
        }

        /// <summary>
        /// Show characters ordered by names
        /// </summary>
        private static void Order_By_Name()
        {
            Console.Clear();

            var Conteiner = from item in Characters_List
                            orderby item.Name descending
                            select item;

            Console.WriteLine("\n\n\t\t Results: \n\n");

            foreach (var item in Conteiner)
            {
                item.Class_Introduction();
                Console.WriteLine("\n");
            }

            Console.ReadLine();

            //Return to Show Characters Panel
            Show_Characters_Panel();
        }

        /// <summary>
        /// Show characters ordered by names + position number
        /// </summary>
        private static void Show_Characters()
{
            Console.Clear();

            Console.WriteLine("\n\n\t\t Results: \n\n");

            short nr = 1;
            foreach (var item in Characters_List)
            {
                Console.Write(nr + " ");
                item.Class_Introduction();
                Console.WriteLine("\n");
                nr++;
            }
        }

        /// <summary>
        /// Show characters ordered by lvl
        /// </summary>
        private static void Order_By_Lvl()
        {
            Console.Clear();

            var List = from item in Characters_List
                       orderby item.Lvl descending
                       select item;

            Console.WriteLine("\n\n\t\t Results: \n\n");

            foreach (var item in List)
            {
                item.Class_Introduction();
                Console.WriteLine("\n");
            }

            Console.ReadLine();

            //Return to Show Characters Panel
            Show_Characters_Panel();
        }

        /// <summary>
        /// Show characters ordered by lvl
        /// </summary>
        private static void Order_By_XLvl()
        {
            Console.Clear();

            Console.Write("\n\tPass minimal lvl: ");

            int X = Int32.Parse(Console.ReadLine());

            var Lista = from item in Characters_List
                       where item.Lvl >= X 
                       orderby item.Lvl descending
                       select item;

            Console.WriteLine("\n\n\t\t Results: \n\n");

            foreach (var item in Lista)
            {
                item.Class_Introduction();
                Console.WriteLine("\n");
            }

            Console.ReadLine();

            //Return to Show Characters Panel
            Show_Characters_Panel();
        }

        /// <summary>
        /// Method save current Characters conditions 
        /// </summary>
        private static void Save()
        {
            //Check if we have any characters to save
            if (Characters_List.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\t No Characters\a");
                Console.ReadLine();

                Main_Panel();
            }

            else
            {
                Diablo_II_Simulator.Save.Save.Create_List_Of_Characters(ref Game_Saves, ref Characters_List);
                Diablo_II_Simulator.Save.Save.Save_Game(ref Game_Saves);
                Fight_Simulation_Panel();
            }
        }

        /// <summary>
        /// Method save current Characters conditions 
        /// </summary>
        private static void Save_Main_Panel()
        {
            //Check if we have any characters to save
            if (Characters_List.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\t No Characters\a");
                Console.ReadLine();

                Main_Panel();
            }

            else
            {
                Diablo_II_Simulator.Save.Save.Create_List_Of_Characters(ref Game_Saves, ref Characters_List);
                Diablo_II_Simulator.Save.Save.Save_Game(ref Game_Saves);

                Console.Clear();
                Console.WriteLine("\n\n\t\t Saved");
                Console.ReadLine();

                Main_Panel();
            }
        }

        #endregion

        //TODO: Find difrend solution for fight simulation
        #region Fight Simulation Methods

        /// <summary>
        /// Method start fight simulation
        /// </summary>
        private static void Chose_Fighter()
        {
            //Check if we have any characters to play
            if (Characters_List.Count == 0)
            {
                Console.Clear();
                Console.WriteLine("\n\n\t\t No Characters\a");
                Console.ReadLine();

                Main_Panel();
            }

            else
            {

                //Pointe must be out of Characters_List scope ( < 0 , Character_List.Count -1 > )
                int pointer = -3;

                pointer = Chose_Character_To_Fight(ref pointer);

                //Life reset
                Characters_List[pointer].Life = 100 + 10 * (Int32)(Characters_List[pointer].X * Characters_List[pointer].Lvl);

                while (Boss_List[0].Hp > 0 && Characters_List[pointer].Life > 0)
                {
                    Random A = new Random();

                    Console.Clear();
                    Console.WriteLine("\n\n\t Your Hp: {0},\t\t Boss Hp:{1}", Characters_List[pointer].Life, Boss_List[0].Hp);

                    Character_Attack(ref pointer, ref A);

                    Boss_Attack(ref pointer, ref A);
                }

                Console.Clear();

                if (Boss_List[0].Hp > 0)
                {
                    Console.WriteLine("\n\n\t\t Boss win!");
                }

                else
                {
                    Console.WriteLine("\n\n\t\tYou win!!!");

                    Characters_List[pointer].Expirience += Boss_List[0].Expirience;

                    pointer = Check_Expirience(pointer);
                }

                Console.ReadLine();

                Main_Panel();
            }
        }

        /// <summary>
        /// Method check if our Character crossed border expirience for next lvl
        /// </summary>
        /// <param name="pointer"></param>
        /// <returns></returns>
        private static int Check_Expirience(int pointer)
        {
            //Check Character expirience
            if (Characters_List[pointer].Expirience > 1000 * Characters_List[pointer].Lvl)
            {
                Characters_List[pointer].Expirience -= 1000 * Characters_List[pointer].Lvl;

                Lvl_Up(ref pointer);
            }

            return pointer;
        }

        /// <summary>
        /// Method incris Character stats 
        /// </summary>
        /// <param name="pointer"></param>
        private static void Lvl_Up(ref int pointer)
        {
            Console.Clear();

            Console.WriteLine("\n\n\t\t Lvl UP!!\a");

            //specific parameter for each character
            float X = Characters_List[pointer].X;

            Characters_List[pointer].Lvl += 1;
            Characters_List[pointer].Strenght += 2 * (Int32)(X * Characters_List[pointer].Lvl);
            Characters_List[pointer].Agility += (Int32)(X * Characters_List[pointer].Lvl);
            Characters_List[pointer].Vitality += 2*(Int32)(X * Characters_List[pointer].Lvl);
            Characters_List[pointer].Life += 10 * (Int32)(X * Characters_List[pointer].Lvl);
            Characters_List[pointer].Stamina += 3*(Int32)(X * Characters_List[pointer].Lvl);
            Characters_List[pointer].Energy += (Int32)(X * Characters_List[pointer].Lvl);
            Characters_List[pointer].Mana += 8*(Int32)(X * Characters_List[pointer].Lvl);
        }

        /// <summary>
        /// Boss Attack 1
        /// </summary>
        /// <param name="pointer"></param>
        /// <param name="A"></param>
        private static void Boss_Attack(ref int pointer, ref Random A)
        {
            //Miss simulation
            Miss = A.Next(1, 10) > 8 ? true : false;

            if (Miss)
            {
                Console.WriteLine("\n\n\t Boss Missed");
            }

            else
            {
                Attack_RNG = A.Next(1, 3);
                Dmg = (Boss_List[0].Strenght * (Attack_RNG))/8;
                Console.WriteLine("\n\n\t Character - {0} Dmg", Dmg);
                Characters_List[pointer].Life -= Dmg;
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Character Attack 1
        /// </summary>
        /// <param name="pointer"></param>
        /// <param name="A"></param>
        private static void Character_Attack(ref int pointer,ref Random A)
        {
            //Miss simulation
            Miss = A.Next(1, 10) > 7 ? true : false;

            if (Miss)
            {
                Console.WriteLine("\n\n\t Character Missed");
            }

            else
            {
                Attack_RNG = A.Next(1, 5);
                Dmg = Characters_List[pointer].Strenght * (Attack_RNG);
                Console.WriteLine("\n\n\t Boss - {0} Dmg", Dmg);
                Boss_List[0].Hp -= Dmg;
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Method 
        /// </summary>
        /// <param name="pointer">Pointer to selected Character</param>
        /// <returns></returns>
        private static int Chose_Character_To_Fight(ref int pointer)
        {
            while (pointer < 0 || pointer >= Characters_List.Count)
            {
                Console.Clear();
                Show_Characters();
                Console.Write("\n\n\t\t Your choice: ");

                try
                {
                    // -1 becouse list start at 0
                    pointer = Int32.Parse(Console.ReadLine()) - 1;
                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }

                //Check if pointer is in scope
                if (pointer < 0 || pointer > Characters_List.Count)
                {
                    Console.WriteLine("Choice out of scope!");
                }

                Create_Random_Boss();

                Console.ReadLine();
            }

            return pointer;
        }

        /// <summary>
        /// Method create random boss
        /// </summary>
        private static void Create_Random_Boss()
        {
            Random Nr = new Random();

            bool accept = true;

            while (accept)
            {
                Console.Clear();

                    switch (Nr.Next(1,7))
                    {
                        case 1:
                                    Console.WriteLine("\n\n\t Andariel");
                                    Console.WriteLine("\n\t Hp = 200 \n\t Strenght = 50 \n\t Expirience = 100");
                                    accept = Accept_Fight_With_Boss();
                                    if (accept == false)
                                    {
                                        Boss_List.Clear();
                                        Boss_List.Add(new Andariel()); 
                                    }
                                    break;

                        case 2:
                                    Console.WriteLine("\n\n\t Lilithe");
                                    Console.WriteLine("\n\t Hp = 300 \n\t Strenght = 100 \n\t Expirience = 200");
                                    accept = Accept_Fight_With_Boss();
                                    if (accept == false)
                                    {
                                        Boss_List.Clear();
                                        Boss_List.Add(new Lilith());
                                    }
                                    break;

                        case 3:
                                    Console.WriteLine("\n\n\t Duriel");
                                    Console.WriteLine("\n\t Hp = 400 \n\t Strenght = 150 \n\t Expirience = 300");
                                    accept = Accept_Fight_With_Boss();
                                    if (accept == false)
                                    {
                                        Boss_List.Clear();
                                        Boss_List.Add(new Duriel());
                                    }
                                    break;

                        case 4:
                                    Console.WriteLine("\n\n\t Mefisto");
                                    Console.WriteLine("\n\t Hp = 500 \n\t Strenght = 200 \n\t Expirience = 400");
                                    accept = Accept_Fight_With_Boss();
                                    if (accept == false)
                                    {
                                        Boss_List.Clear();
                                        Boss_List.Add(new Mefisto());
                                    }
                                    break;

                        case 5:
                                    Console.WriteLine("\n\n\t Izual");
                                    Console.WriteLine("\n\t Hp = 600 \n\t Strenght = 250 \n\t Expirience = 500");
                                    accept = Accept_Fight_With_Boss();
                                    if (accept == false)
                                    {
                                        Boss_List.Clear();
                                        Boss_List.Add(new Izual());
                                    }
                                    break;

                        case 6:
                                    Console.WriteLine("\n\n\t Diablo");
                                    Console.WriteLine("\n\t Hp = 700 \n\t Strenght = 300 \n\t Expirience = 600");
                                    accept = Accept_Fight_With_Boss();
                                    if (accept == false)
                                    {
                                        Boss_List.Clear();
                                        Boss_List.Add(new Diablo());
                                    }
                                    break;

                        case 7:
                                    Console.WriteLine("\n\n\t Mefisto");
                                    Console.WriteLine("\n\t Hp = 800 \n\t Strenght = 400 \n\t Expirience = 700");
                                    accept = Accept_Fight_With_Boss();
                                    if (accept == false)
                                    {
                                        Boss_List.Clear();
                                        Boss_List.Add(new Mefisto());
                                    }
                                    break;
                    }
            }
        }

        /// <summary>
        /// Method ask do You wona to fight
        /// </summary>
        /// <returns></returns>
        private static bool Accept_Fight_With_Boss()
        {
            bool accept = true;
            Console.Write("\n\n\t1 = Fight,\n\n\tElse = Find difrend enemy\n\n\t\tAnswer: ");

            int answer = 0;
            try
            {
                answer = Int32.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\n\t Choice out of scope!");
                Console.ReadLine();
                return true;
            }

            if (answer == 1)
            {
                return accept = false;
            }

            else return true;
        }

        #endregion
    }
}
