using CSharpBasicsConsole.Classes;

namespace CSharpBasicsConsole
{
    internal class Program
    {
        static void Main(string[] args)
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
             * 
             * 
             * 
             */

            //object userInput = new
            //{
            //    Name = "Test",
            //    FavoriteDay = "Wednesday",
            //    LeastFavoriteSubject = "Gym",
            //    Age = 0
            //};

           
            UserInput userInput = new UserInput();

            Console.Write("Enter your name: ");
            
            // ? - putting a ? after a Type makes it so that it is nullable, which means the value of that thing is allowed to be null
            userInput.Name = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(userInput.Name))
            {
                Console.WriteLine("Please enter a valid name: ");
                userInput.Name = Console.ReadLine();
            }
            Console.Clear();

            Console.Write("What is your favorite day of the week? ");
            userInput.FavoriteDayOfWeek = Console.ReadLine();

            //I'm making a change and adding this comment
            //I made this change on a branch


            while (String.IsNullOrWhiteSpace(userInput.FavoriteDayOfWeek))
            {
                Console.WriteLine("Please enter a valid day of the week: ");
                userInput.FavoriteDayOfWeek = Console.ReadLine();
            }
            Console.Clear();

            Console.Write("What is/was your least favorite subject in school? ");
            userInput.LeastFavoriteSubject = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(userInput.LeastFavoriteSubject))
            {
                Console.WriteLine("Please enter a valid school subject: ");
                userInput.LeastFavoriteSubject = Console.ReadLine();
            }
            Console.Clear();


            // @ - string verbatim, keeps alllllllll spacing, new lines, white space, etc
            

            //const myFunction = () => {do some stuff}
            //const myFunction = (name) => {do some stuff}

            Console.Write(userInput);
            
            //Console.Write(displayText);
            //Console.Write(1);

            Console.ReadLine();

            //string input = "";

            //while (input == "" || input.StartsWith("QQ"))
            //{
            //    //Console.WriteLine("You need to type a real name.");
            //Console.WriteLine("Enter your name: ");
            //    input = Console.ReadLine();
            //}

            //Console.WriteLine($"Hello, {input}.");

        }
        
    }


}