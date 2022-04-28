using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    public class DVD : Movie
    {
        public DVD(string Title, Genre Category, int MovieLength, params string[] Scenes) : base(Title, Category, MovieLength, Scenes)
        {
        }

        public override void Play()
        {
            Console.WriteLine($" What scene would you like to watch? Please select a number 0 through {Scenes.Count - 1}");
            string input = Console.ReadLine();
            int index = int.Parse(input);
            string scene = Scenes[index];
            Console.WriteLine(scene);
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
