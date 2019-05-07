using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; }
        private Random ran = new Random();

        private void InitializeTime(Random r)
        {
            CurrentTime = r.Next(0, Scenes.Count);
        }

        public VHS(string title, string category, int runtime, List<string> scenes) : base(title, category, runtime, scenes)
        {
            InitializeTime(ran);
        }

        public override void Play()
        {
            //Console.WriteLine("Press 'S' to stop or any key to continue.");
            //string stop = Console.ReadLine().ToUpper();
            //if (stop != "S")
            //{
            if (CurrentTime == Scenes.Count)
            {
                CurrentTime = 0;
                Console.WriteLine(Scenes[CurrentTime]);
            }
            else
            {
                Console.WriteLine(Scenes[CurrentTime]);
                CurrentTime++;
            }
            //}
            //else
            //{
            //    return;
            //}
        }

        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
