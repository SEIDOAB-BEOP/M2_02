using System;

namespace BOOP_02_15
{
    class Program
    {
        public enum Favorites { Cars, Boats, Motorcycles, Other}

        static void Main(string[] args)
        {
            Favorites yourFavorite = Favorites.Cars;

            // using nested if statements
            string myFavorite;
            if (yourFavorite == Favorites.Cars)
                myFavorite = "I enjoy driving cars fast.";
            
            else if (yourFavorite == Favorites.Boats)
                myFavorite = "I don't particular care for boats.";
            
            else if (yourFavorite == Favorites.Motorcycles)
                myFavorite = "I love riding motorcycles!";
            
            else
                myFavorite = "Well...";

            // Using the conditional expression
            string maybeTogether = (yourFavorite == Favorites.Cars|| yourFavorite == Favorites.Motorcycles)? "Lets go together!" : "Pls go alone!";

            Console.WriteLine(myFavorite);
            Console.WriteLine(maybeTogether);
        }
    }
}
//Exercises
//1.    Add Bicycles and Horses to the Favorite enum and modify above code to:
//      - print out "Love two wheels" if myFavorites is Bicycles or Motorcycles.
//      - print out "Love horse powers" if myFavorites is Motorcycles or Horses.
//      - print "Lets go together only for Bicycles and Horses