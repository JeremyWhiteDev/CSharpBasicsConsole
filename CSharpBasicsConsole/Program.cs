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
             */

            Console.Write("Enter your name: ");
            
            // ? - putting a ? after a Type makes it so that it is nullable, which means the value of that thing is allowed to be null
            string? name = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Please enter a valid name: ");
                name = Console.ReadLine();
            }
            Console.Clear();

            Console.Write("What is your favorite day of the week? ");
            string? dayOfWeek = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(dayOfWeek))
            {
                Console.WriteLine("Please enter a valid day of the week: ");
                dayOfWeek = Console.ReadLine();
            }
            Console.Clear();

            Console.Write("What is/was your least favorite subject in school? ");
            string? leastFaveSchoolSubject = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(leastFaveSchoolSubject))
            {
                Console.WriteLine("Please enter a valid school subject: ");
                leastFaveSchoolSubject = Console.ReadLine();
            }
            Console.Clear();


            // @ - string verbatim, keeps alllllllll spacing, new lines, white space, etc
            string displayText = @$"Name: {name}
                                    Favorite Day of the Week: {dayOfWeek}
                                    Least Favorite School Subject: {leastFaveSchoolSubject}";

            Console.Write(displayText);

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