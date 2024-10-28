using System;

namespace BOOP_02_16
{
    class Program
    {
        #region Exercise
        public enum PlayingCardColor
        {
            Heart = 0b1,
            Diamond = 0b1 << 1,
            Club = 0b1 << 2,
            Spade = 0b1 << 3,

            Red = Heart | Diamond,
            Black = Club | Spade
        }
        public enum PlayingCardValue
        {
            Ace = 1,
            One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten,
            Knight, Queen, King
        }
        public struct PlayingCard
        {
            public PlayingCardColor Color;
            public PlayingCardValue Value;
        }
        #endregion

        public enum Favorites { Cars, Boats, Motorcycles, Other }
        static void Main(string[] args)
        {
            Favorites myFavorite = Favorites.Cars;

            // using the switch statement
            string ILike;
            switch (myFavorite)
            {
                case Favorites.Cars:
                    ILike = "I enjoy driving cars fast.";
                    break;
                case Favorites.Motorcycles:
                    ILike = "I love riding motorcycles!";
                    break;
                case Favorites.Boats:
                    ILike = "I like fishing in a boat.";
                    break;
                default:
                    ILike = "Not sure what I like...";
                    break;
            }

            Console.WriteLine(ILike);

            Favorites yourFavorite = Favorites.Cars;
            
            string maybeTogether;
            switch (yourFavorite)
            {
                case Favorites.Cars:
                case Favorites.Motorcycles:

                    if (myFavorite == Favorites.Cars || myFavorite == Favorites.Motorcycles)
                        maybeTogether = "Lets go together!";
                    else
                        maybeTogether = "Pls go alone!";
                    break;
                default:
                    maybeTogether = "Pls go alone!";
                    break;
            }

            Console.WriteLine(maybeTogether);
        }
    }
}
//Exercises
//1.    Use the structure in region "Exercise". Write a program that 
//      - Declare a variable of type PlayaingCard and initializes it. 
//      - Uses a switch statement to assign a string variable to "Face" in case of Ace, Knight, Queen and King. Otherwise 
//        assign it to "Value"
//      - Print a card description such as:
//      - "Red Face Card: Ace of Diamonds" and "Black Value Card: Five of Clubs"