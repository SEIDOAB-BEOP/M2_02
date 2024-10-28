using System;

namespace BOOP_02_17
{
    class Program
    {
        public enum Favorites { Cars, Boats, Motorcycles, Other }
        static void Main(string[] args)
        {
            Favorites myFavorite = Favorites.Cars;

            // Yet the same using switch expressions
            string ILike = myFavorite switch
            {
                Favorites.Cars => $"I enjoy driving cars fast.",
                Favorites.Motorcycles => "I love riding motorcycles!",
                Favorites.Boats => "I like fishing in a boat.",
                _ => "Not sure what I like..."
            };
            
            Console.WriteLine(ILike);
        }
    }
}
