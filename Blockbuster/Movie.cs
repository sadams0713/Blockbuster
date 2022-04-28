using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    public enum Genre
    {
        Action,
        Drama,
        Horror,
        Comedy,
        Romance
    }
    public abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }
        public int MovieLength { get; set; }
        public List<string> Scenes { get; set; }

        public Movie(string Title, Genre Category, int MovieLength, params string[] Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.MovieLength = MovieLength;
            this.Scenes = Scenes.ToList();

        }
        public void PrintInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine("Category: " + Category);
            Console.WriteLine($"Movie Length: {MovieLength}");
            
        }
        public void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine($"Scene {i}: {Scenes[i]}");
            }
        }
        public abstract void Play();
    }
}
