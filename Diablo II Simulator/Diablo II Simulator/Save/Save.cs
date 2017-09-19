using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diablo_II_Simulator.Save
{
    public class Save
    {

        //Path to txt file
        const string curFile = "Diablo_II_Game_Saves.txt";

        /// <summary>
        /// Metoda zapisująca dane do pliku txt
        /// </summary>
        /// <param name="Lista">Pass List<string></string></param>
        public static void Save_Game(ref List<string> Lista)
        {
            //Clear txt file before saving
            File.WriteAllText(curFile, string.Empty);

            using (StreamWriter sw = File.AppendText(curFile))
            {
                foreach (var item in Lista)
                {
                    try
                    {
                        sw.WriteLine(item);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                Console.Clear();
                Console.WriteLine("\n\n\t!!!Saved!!!");
            }
        }

        /// <summary>
        /// Method create new Game_Saves list basing on Characters_List
        /// </summary>
        /// <param name="ListA">Target List<string></param>
        /// <param name="ListB">Sorce List<Characters></param>
        public static void Create_List_Of_Characters(ref List<string> ListA, ref List<Characters> ListB)
        {
            //Clear our List<string>
            ListA.Clear();

            foreach (var item in ListB)
            {
                ListA.Add(item.Convert_To_string());
            }
        }
    }
}
