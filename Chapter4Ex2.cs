namespace Chapter4Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...Welcome to Test your Math...");
            Console.WriteLine("Enter Q to continue or anything to quit.");
            string? go = Console.ReadLine();
            Random rand = new Random();
            int num1 = 0;
            int num2 = 0;
            while (go == "q" || go == "Q")
            {
                num1 = rand.Next(1, 100);
                num2 = rand.Next(1, 100);
                Console.WriteLine($"What is {num1} + {num2}?");
                int answer = int.Parse(Console.ReadLine());
                while (answer != (num1 + num2))
                {
                    Console.WriteLine("That is incorrect, please try again!");
                    answer = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Great job!");
                Console.WriteLine("Enter Q to continue, or anything to quit.");
                go = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("Thanks for playing!");
        }
    }
}