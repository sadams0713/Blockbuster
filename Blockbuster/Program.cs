namespace Blockbuster
{
    public class Program
    {
        static int selection;

        public static void Main()
        {
            while (true)
            {
                
                Console.WriteLine("Welcome to the other last Blockbuster! *They don't know we're here*. Here's a list of the movies currently in stock");
                Scenes s = new Scenes();
                s.PrintMovies();
                Console.WriteLine("Yes. It is only 6 movies. We're Blockbuster, not Netflix.");
                Console.WriteLine("");

                Console.WriteLine("Sorry. Long day with lots of customers. ");
                //try
                //{
                //    selection = int.Parse(GetUserInput($"Please enter the number of the movie you'd like to watch 0 through { s.PrintMovies().Count - 1}."));
                //    if (selection > s.PrintMovies().Count - 1)
                //    {
                //        Console.WriteLine("I'm sorry we don't have that movie. Would you like to pick another one?");
                //        continue;
                //    }
                //    else
                //    {
                        // Here's where we set them up with the movie.
                //        continue;
                //    }
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine("Please enter a valid number.");
                //    continue;
                //}
                bool check = PleaseReturn();
                    if(check==false)
                    {
                        break;
                    }
                
            }
        }
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;
        }
        public static bool PleaseReturn()
        {
            string input = GetUserInput("Would you like to check out some other movies?  Y/N").ToLower();

            if (input == "y" || input == "yes")
            {
                return true;
            }
            else if (input == "n" || input == "no")
            {
                Console.WriteLine("Thanks for visiting the other last Blockbuster!");
                return false;
            }
            else
            {
                Console.WriteLine("Sorry I didn't catch that. Let's try again.");
                return PleaseReturn();
            }
        }
    }
}