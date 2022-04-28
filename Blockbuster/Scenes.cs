using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blockbuster
{
    class Scenes
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public Scenes()
        {
            Movies.Add(new DVD( "RocknRolla", Genre.Action, 114, "People ask the question... what's a RocknRolla? And I tell 'em - it's not about drums, drugs, and hospital drips, oh no. There's more there than that, my friend. We all like a bit of the good life - some the money, some the drugs, other the sex game, the glamour, or the fame. But a RocknRolla, oh, he's different. Why? Because a real RocknRolla wants the fucking lot", "Now, if a slap don't work, you cut 'em or you pay 'em, but you keep your receipts, cos this ain't the Mafia", "It's my lucky painting", "Smoking Monologue", "No need to worry just yet, fellas. Nothing’s gonna happen while we're standing in the lift. Because then they'd have to carry the corpses to the cars, and that seems too much like hard work. In about two minutes from now, when we’re all walking along happily, Danny-boy over there is gonna turn, and pop me two in the head, then one in the throat, just to be sure. You shouldn't have brought me here, fellas. You're just going to end up as witnesses. Once they've dealt with us, they’re gonna put our corpses in the boot of a stolen car, then pour six gallons of petrol on top. I can let your imagination fill in the rest. But see now Danny-boy is rattled, because he knows that you know. And so, he's going to fire"));

            Movies.Add(new DVD("Onward", Genre.Drama, 102, "Meet Ian and Barley", "Ian brings back half his dad", "The hunt for another Phoenix gem", "Wild adventurous shenanigins", "Dragon Fight", "Heartbreaker Finish" ));

            Movies.Add(new DVD("Hot Rod", Genre.Comedy, 88, "I like to party", "You look pretty Denise, I SAID YOU LOOK SHITTY OK BYE", "I've been drinking green tea all god damn day!", "You’re wrong, Frank. I’m not a kid. I’m a man. I am going to get you better, and then I’m going to beat you to death!", "Respect" ));

            Movies.Add(new VHS("Snatch", Genre.Action, 102, "You like dags?", "Diamonds are worth a lot", "The pikey fights", "It's good to know about fake guns", "Lots of people are dead" ));

            Movies.Add(new VHS("A Walk to Remember", Genre.Romance, 102, "Oops we hurt this kid", "Don't fall in love with me", "Hey let's go on a date", "I'm sick and dying", "Let's get married", "Retrospective on his dead wife"));

            Movies.Add(new VHS("A Goofy Movie", Genre.Comedy, 78, "Powerline is awesome", "Dad, you're embarassing me", "Let's go on a fishing trip", "Ok we're going to LA", "The perfect cast", "Now we're onstage with Powerline"));

        }
        public void PrintMovies()
        {
            for(int i = 0; i < Movies.Count; i++)
            {
                Movie s = Movies[i];
                Console.WriteLine($"Indexed at {i}, {s.Title}");
            }
        }
        public Movie Checkout()
        {
            PrintMovies();
            Console.WriteLine("Which movie would you like to check out today?");
            string input = Console.ReadLine();
            int index = int.Parse(input);
            Movie s = Movies[index];
            s.PrintInfo();
            return s;
        }
    }
} 
