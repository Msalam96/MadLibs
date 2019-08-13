using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {   
        static void Main(string[] args)
        {
            while(true) {
                Console.WriteLine("Welcome to the MadLibs App!");
                string[][] puzzles =
                {
                    new string[] {
                        "Avengers",
                        "The others looked for **{0}** and sure enough the sky was filled with **{1}** flying **{2}**",
                        "plural noun",
                        "adjective",
                        "animal (plural)",
                    },
                    new string[] {
                        "Star Wars",
                        "It doesn't matter how **{0}** these objects are, it only matters how **{1}** the Jedi believes.",
                        "adjective",
                        "adverb",
                    },
                };

                Console.WriteLine("Here are the list of available puzzles:");

                for (int i = 0; i < puzzles.Length; ++i)
                {
                    Console.WriteLine("{0}: {1}", i + 1, puzzles[i][0]);
                }

                Console.Write("Select an Option: ");
                int choice = int.Parse(Console.ReadLine());

                string[] puzzle = puzzles[choice - 1];
                string[] words = new string[puzzle.Length - 2];

                for (int i = 2; i < puzzle.Length; i++)
                {
                    Console.Write("Enter a {0}: ", puzzle[i]);
                    words[i - 2] = Console.ReadLine();
                }

                string answer = string.Format(puzzle[1], words);
                Console.WriteLine(answer);
                Console.ReadKey();

                Console.Write("Do you wish to replay (type y to replay, anything else to quit): ");
                string replay = Console.ReadLine();

                if (replay.ToLower() == "y")
                {
                    continue;
                } else
                {
                    break;
                }
            }
         
        }
    }
}
