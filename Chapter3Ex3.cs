namespace Chapter3Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the conference center, Trainee!\nenter trainee number");
            int numbers = Convert.ToInt32(Console.ReadLine());
            if (numbers > 500)
            {
                Console.WriteLine("Proceed to training room 7A!");
            }
            else if(numbers > 300)
            {
                Console.WriteLine("Proceed to main ballroom!");
            }
            else if( numbers > 200)
            {
                Console.WriteLine("Proceed to gymnasium!");
            }
            else if (numbers > 100)
            {
                Console.WriteLine("Proceed to training room 6A!");
            }
            else
            {
                Console.WriteLine("Proceed to training room 2B!");
            }
            Console.WriteLine("\n\nlunch will be from 11:30 to 1:00. using # 1-5 please choose from the following" +
                "\n1 = Italian" +
                "\n2 = Vegan" +
                "\n3 = Chinese" +
                "\n4 = French" +
                "\n5 = Chef's Surprise" +
                "\n\nDisclaimer: if number is not within the selection range you will get #5\n");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.WriteLine("\nItalian lunch is in Courtyard A");
                    break;
                    case 2: Console.WriteLine("\nVegan lunch is in Courtyard B");
                    break;
                    case 3: Console.WriteLine("\nChinese lunch is in Courtyard C");
                    break;
                    case 4: Console.WriteLine("\nFrench lunch is in the Upper Deck");
                    break;
                    default: Console.WriteLine("\nChef’s Surprise is in the Tower Restaurant");
                    break;
            }
            Console.WriteLine("\n\nEnjoy the conference!");
        }
    }
}
