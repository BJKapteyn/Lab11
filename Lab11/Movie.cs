using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Movie
    {
        public string Title { get; }
        public string Category { get; }
        public int Runtime { get; }
        public List<string> Scenes = new List<string>();

        public Movie(string title, string category, int runtime, List<string> scenes)
        {
            Title = title;
            Category = category;
            Runtime = runtime;
            Scenes = scenes;
        }

        public virtual void Play()
        {

        }

        public virtual void Printinfo()
        {
            Console.WriteLine($"\nTitle:      {Title}" +
                              $"\nCategory:   {Category}" +
                              $"\nRuntime:    {Runtime} mins");
        }

        public void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"\nScene {i + 1}:" +
                    $"\n     {Scenes[i]}\n");
            }
        }
        
        public void PlayWholeMovie()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine(Scenes[i]);
            }
        }

        
    }
}
