using System;

namespace BOOP_02_17
{
    class Program
    {
        public enum Favorites { Cars, Boats, Motorcycles, Other }
        static void Main(string[] args)
        {
            Favorites yourFavorite = Favorites.Cars;

            // Yet the same using switch expressions
            string myFavorite = yourFavorite switch
            {
                Favorites.Cars => $"I enjoy driving cars fast.",
                Favorites.Boats => "I don't particular care for boats.",
                Favorites.Motorcycles => "I love riding motorcycles!",
                _ => "Well..."
            };
            
            string maybeTogether = yourFavorite switch
            {
                Favorites.Cars => "Lets go together!",
                Favorites.Motorcycles => "Lets go together!",
                _ => "Pls go alone!"
            };

            Console.WriteLine(myFavorite);
            Console.WriteLine(maybeTogether);
        }
    }
}
//Exercises
//1.    Redo Exercise BOOP_02_16 but using Switch expressions instead
