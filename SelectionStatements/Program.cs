namespace SelectionStatements
{
    internal class program
    {
        static void Main(string[] args)
        {
            //Switch Statements
            Console.WriteLine("What is your favorite school subject?");

            string subject = Console.ReadLine();

            switch (subject.ToLower()) 
            {
                case "math":
                case "calculus":
                    Console.WriteLine("I hate Math, it's pretty boring.");
                    break;
                case "science":
                case "biology":
                case "physics":
                    Console.WriteLine("I love Science, you get to do some very interesting labs.");
                    break;
                case "english":
                case "literacy":
                    Console.WriteLine("I love English, especially the creative writing projects.");
                    break;
                case "history":
                case "social studies":
                    Console.WriteLine("Interesting choice, but I can agree. Learning about our past is pretty engaging.");
                    break;
                case "art":
                case "drawing":
                    Console.WriteLine("I love Art, you could do so many creative projects! What's your favorite thing about it?");
                    break;
                case "pe":
                case "phys ed":
                case "physical education":
                    Console.WriteLine("PE is pretty fun, especially engaging in all the sports and games.");
                    break;
                case "orchestra":
                case "band":
                    Console.WriteLine("Very fun! What was your instrument?");
                    break;
                default:
                    Console.WriteLine("Interesting choice! What do you like about it?");
                    break;
            }
        }
    }
}
