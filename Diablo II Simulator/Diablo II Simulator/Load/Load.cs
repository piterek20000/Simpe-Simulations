using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Diablo_II_Simulator.Load
{
    public class Load
    {
        //Path to txt file
        public const string curFile = "Diablo_II_Game_Saves.txt";

        #region Loading Method 

        public static void Load_Saves(ref List<string> List)
        {
            //Clear our list in case when we load multiple times from one file
            List.Clear();

            try
            {
                using (StreamReader StreamR = File.OpenText(curFile))
                {
                    string data;
                    while ((data = StreamR.ReadLine()) != null)
                    {
                        //Check if line is null on empty
                        if (!string.IsNullOrEmpty(data))
                            List.Add(data);
                    }
                }
            }
            catch (Exception e)
            {
                Console.Clear();

                //Check if curFile exist
                if (!File.Exists(curFile))
                {
                    Console.WriteLine("\n\n\tFile doesn't exist");
                }

                Console.WriteLine("\n\n\t" + e.Message + "\n\n");

                Console.ReadLine();

                Console.Clear();

                //Return to Main Panel
                Program.Main_Panel();
            }
        }

        #endregion

        #region Created List of Characters

        //Spare loading controlers
        static int Loaded = 0;
        static int Missed = 0;

        /// <summary>
        /// Method Create Character basing on Game_Saves list
        /// </summary>
        /// <param name="String_List">List of Characters (Loaded information convertet to string)</param>
        /// <param name="List_Of_Characters">List of Characters</param>
        public static void Load_Saves(ref List<string> String_List, ref List<Characters> List_Of_Characters)
        {
            //In case loading multiple time the same objects (prevent duplicating objects)
            List_Of_Characters.Clear();

            //Chcek if our list have any object
            if (String_List.Count == 0)
            {
                Console.Clear();

                Console.WriteLine("\n\n\t\tNo Saves");

                Console.ReadLine();

                Console.Clear();

                //Return to Main Panel
                Program.Main_Panel();
            }

            else
            {
                Loaded = 0;
                Missed = 0;

                foreach (var item in String_List)
                {
                    string[] helper = Split_String(item);
                    Create_List_Of_Characters(ref helper, ref List_Of_Characters);
                }

                Console.Clear();
                Console.WriteLine("\n\n\tSaves loading completed!");
                Thread.Sleep(2000);

                //Show how many missed lines (nr)
                if (Missed > 0)
                {
                    Console.WriteLine("\n\n\t Missed: " + Missed);
                }
            }
            
            Console.ReadLine();

            Console.Clear();

            //Return to Main Panel
            Program.Main_Panel();
        }

        /// <summary>
        /// Method return spleated string by '#'
        /// </summary>
        /// <param name="data">Pass string</param>
        /// <returns></returns>
        private static string[] Split_String(string data)
        {
            return data.Split('#');
        }

        /// <summary>
        /// Method created list of Characters
        /// </summary>
        /// <param name="A">Pass string[] A</param>
        /// <param name="List_Of_Characters">Pass List<Characters> List_Of_Characters </param>
        private static void Create_List_Of_Characters(ref string[] A, ref List<Characters> List_Of_Characters)
        {
            Loaded++;
            switch (A[0])
            {
                case "Amazonka":
                    List_Of_Characters.Add(new Amazonka(A[1],
                        Convert.ToInt32(A[2]),
                        Convert.ToInt32(A[3]),
                        Convert.ToInt32(A[4]),
                        Convert.ToInt32(A[5]),
                        Convert.ToInt32(A[6]),
                        Convert.ToInt32(A[7]),
                        Convert.ToInt32(A[8]),
                        Convert.ToInt32(A[9]),
                        Convert.ToInt32(A[10])));
                    break;

                case "Nekromanta":
                    List_Of_Characters.Add(new Nekromanta(A[1],
                        Convert.ToInt32(A[2]),
                        Convert.ToInt32(A[3]),
                        Convert.ToInt32(A[4]),
                        Convert.ToInt32(A[5]),
                        Convert.ToInt32(A[6]),
                        Convert.ToInt32(A[7]),
                        Convert.ToInt32(A[8]),
                        Convert.ToInt32(A[9]),
                        Convert.ToInt32(A[10])));
                    break;

                case "Barbarzynca":
                    List_Of_Characters.Add(new Barbarzynca(A[1],
                        Convert.ToInt32(A[2]),
                        Convert.ToInt32(A[3]),
                        Convert.ToInt32(A[4]),
                        Convert.ToInt32(A[5]),
                        Convert.ToInt32(A[6]),
                        Convert.ToInt32(A[7]),
                        Convert.ToInt32(A[8]),
                        Convert.ToInt32(A[9]),
                        Convert.ToInt32(A[10])));
                    break;

                case "Paladyn":
                    List_Of_Characters.Add(new Paladyn(A[1],
                        Convert.ToInt32(A[2]),
                        Convert.ToInt32(A[3]),
                        Convert.ToInt32(A[4]),
                        Convert.ToInt32(A[5]),
                        Convert.ToInt32(A[6]),
                        Convert.ToInt32(A[7]),
                        Convert.ToInt32(A[8]),
                        Convert.ToInt32(A[9]),
                        Convert.ToInt32(A[10])));
                    break;

                case "Czarodziejka":
                    List_Of_Characters.Add(new Czarodziejka(A[1],
                        Convert.ToInt32(A[2]),
                        Convert.ToInt32(A[3]),
                        Convert.ToInt32(A[4]),
                        Convert.ToInt32(A[5]),
                        Convert.ToInt32(A[6]),
                        Convert.ToInt32(A[7]),
                        Convert.ToInt32(A[8]),
                        Convert.ToInt32(A[9]),
                        Convert.ToInt32(A[10])));
                    break;

                case "Zabojczyni":
                    List_Of_Characters.Add(new Zabojczyni(A[1],
                        Convert.ToInt32(A[2]),
                        Convert.ToInt32(A[3]),
                        Convert.ToInt32(A[4]),
                        Convert.ToInt32(A[5]),
                        Convert.ToInt32(A[6]),
                        Convert.ToInt32(A[7]),
                        Convert.ToInt32(A[8]),
                        Convert.ToInt32(A[9]),
                        Convert.ToInt32(A[10])));
                    break;

                case "Druid":
                    List_Of_Characters.Add(new Druid(A[1],
                        Convert.ToInt32(A[2]),
                        Convert.ToInt32(A[3]),
                        Convert.ToInt32(A[4]),
                        Convert.ToInt32(A[5]),
                        Convert.ToInt32(A[6]),
                        Convert.ToInt32(A[7]),
                        Convert.ToInt32(A[8]),
                        Convert.ToInt32(A[9]),
                        Convert.ToInt32(A[10])));
                    break;

                default:
                    //In case when our txt saves have a bags
                    Console.WriteLine("\n\t\t Incorrect lines missed!!!!!\t\t" + Loaded);
                    Missed++;
                    break;
            }
        }

        #endregion
    }
}
