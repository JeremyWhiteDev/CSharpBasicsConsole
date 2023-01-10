namespace CSharpBasicsConsole.Classes
{
    //class - a blueprint to represent something in your application
    //all code in a class will be related
    public class UserInput
    {
        /*
             * Name: Brian Neal
             * Favorite day of the week: Wednesday
             * Least favorite school subject: Gym
             * 
             * const userInput = {
             *    name: "Brian",
             *    favoriteDayOfWeek: "Wednesday",
             *    leastFavoriteSubject: "Gym"
             * 
             * }
             */

        public string Name { get; set; }
        public string FavoriteDayOfWeek { get; set; }
        public string LeastFavoriteSubject { get; set; }

        public override string ToString()
        {
            return @$"Name: {Name}
Favorite Day of the Week: {FavoriteDayOfWeek}
Least Favorite School Subject: {LeastFavoriteSubject}";
        }
    }
}
