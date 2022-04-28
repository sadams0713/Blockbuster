using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    public class VHS : Movie
    {
        public int CurrentScene { get; set; } = 0;
        public VHS(string Title, Genre Category, int MovieLength, params string[] Scenes) : base(Title, Category, MovieLength, Scenes)
        {
        }

        public void Rewind()
        {
            CurrentScene = 0;
        }
        public override void Play()
        {
            if (CurrentScene < Scenes.Count)
            {
                string scene = Scenes[CurrentScene];
                Console.WriteLine(scene);
                CurrentScene++;
            }
            else
            {
                Rewind();
            }
        }
        public void PlayWholeMovie()
        {
            for (int s = 0; s < Scenes.Count; s++)
            {
                string scene = Scenes[s];
                Console.WriteLine($"{s}:{scene}");
            }
        }
    }
}
