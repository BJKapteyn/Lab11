using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class DVD : Movie
    {
        public DVD(string title, string category, int runtime, List<string> scenes) : base(title, category, runtime, scenes)
        {

        }

        public override void Play()
        {
            int startScene = Scenes.Count + 1;
            int choice = 0;
            this.PrintScenes();
            Console.WriteLine($"\nWhich scene would you like to start at? (1-{startScene}) or 'S' to start from the beginning");
            while (true)
            {
                string uPick = Console.ReadLine().ToUpper() ;
                if (uPick.ToUpper() == "S")
                {
                    PlayWholeMovie();
                    break;
                }
                else if (Int32.TryParse(uPick, out choice))
                {
                    if (choice >= 1 && choice <= startScene)
                    {
                        for (int i = choice; i < Scenes.Count; i++)
                        {
                            Console.WriteLine($"{Scenes[i]} ");
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid scene.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a whole number.");
                    continue;
                }
                break;
            }
        }
    }
}
