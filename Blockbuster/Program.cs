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
                s.Checkout();
                
            }
        }
        
    }
}