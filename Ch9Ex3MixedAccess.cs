using System.ComponentModel.Design;

namespace Ch9Ex3MixedAccess
{
    class Game
    {
        private int _ReleaseYear;
        private double _Cost;
        public string Title;
        public string Platform;

        //default
        public Game()
        {
            Title = string.Empty;
            Platform = string.Empty;
            _ReleaseYear = 0;
            _Cost = 0;
        }
        //parameterized
        public Game(string title, string platform, int releaseYear, int cost)
        {
            Title = title;
            Platform = platform;
            _ReleaseYear = releaseYear;
            _Cost = cost;
        }
        //get methods
        public int GetReleaseYear()
        {
            return _ReleaseYear;
        }
        public double GetCost()
        {
            return _Cost;
        }
        //set methods
        public void SetReleaseYear(int releaseYear)
        { while(releaseYear < 1990)
            {
                Console.WriteLine("Release Year must be 1990 or newer, try again.");
                while(!int.TryParse(Console.ReadLine(), out releaseYear))
                {
                    Console.WriteLine("Release Year must be 1990 or newer, try again.");
                }
            }
            
            

                _ReleaseYear = releaseYear;
            
        }

        public void SetCost(double gameCost)
        {
            while (gameCost < 10 || gameCost > 200)
            {
                Console.WriteLine("Cost must be between 10 to 200, try again.");
                while(!double.TryParse(Console.ReadLine(), out gameCost))
                {
                    Console.WriteLine("Cost must be between 10 to 200, try again.");
                }
            }
            _Cost = gameCost;
        }
        public void Print()
        {
            Console.WriteLine($"Game: {Title} for {Platform} released in {_ReleaseYear} MSRP: {_Cost:C}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many games would you like to add?");
            string stringCount = Console.ReadLine();
            int count;
            while (!int.TryParse(stringCount, out count) || count <= 0)
            {
                Console.WriteLine("Enter a number greater than zero.");
                stringCount = Console.ReadLine();
            }
            int gamesCreated = 0;
            //game array
            Game[] games = new Game[count];

            for (int i = 0; i < count; i++)
            {
                games[i] = new Game();
            }

            char userEnter = Menu();
            
            while (userEnter != 'Q')
            {
                
                switch (userEnter)
                {
                    case 'A':
                        if (gamesCreated < count)
                        {
                            AddGame(games, ref gamesCreated);
                        }
                        else
                        {
                            Console.WriteLine("Max number of entries have been reached.");
                        }
                        break;
                    case 'P':
                        if (gamesCreated == 0)
                        {
                            Console.WriteLine("There are no entries to display.");
                            break;
                        }
                        else
                        {
                            for (int i = 0; i < count; i++)
                            {
                                games[i].Print();
                            }
                            break;
                        }
                        
                    case 'Q':
                        break;
                    default:
                        Menu();
                        break;

                }
                userEnter=Menu();
                

            }
        }
    
        public static char Menu()
        {
            string choice = string.Empty;
            char userEnter;
            Console.WriteLine("********************\n\n" +
                "[A] Add\n" +
                "[P] Print\n" +
                "[Q] Quit\n\n" +
                "********************");
            choice = Console.ReadLine().ToUpper();
            
            while (!char.TryParse(choice, out userEnter) && String.IsNullOrEmpty(choice)&&
                String.IsNullOrWhiteSpace(choice))
            {
               
                Console.WriteLine("Please select from the above menu options.");
                choice = Console.ReadLine().ToUpper();
            }
            
            return userEnter;
        }
        public static void AddGame(Game[] games, ref int gamesCreated)
        {
           
            Console.WriteLine("Enter the Title of the game");
            string tempTitle = Console.ReadLine();
            while (string.IsNullOrEmpty(tempTitle) || string.IsNullOrWhiteSpace(tempTitle))
            {
                Console.WriteLine("Not a valid title.");
                tempTitle = Console.ReadLine();
            }
            games[gamesCreated].Title = tempTitle;

            Console.WriteLine("Enter the platform used for the game");
            string tempPlatform = Console.ReadLine();
            while(string.IsNullOrEmpty(tempPlatform) || string.IsNullOrWhiteSpace(tempPlatform))
            {
                Console.WriteLine("Not a valid platform.");
                tempPlatform = Console.ReadLine();
            }
            games[gamesCreated].Platform = tempPlatform;
            int releaseYear = 0;
            Console.WriteLine("Enter the year of the game");
            string tempYear = Console.ReadLine();
            while (!int.TryParse(tempYear, out releaseYear))
            {
                
                    Console.WriteLine("Not a valid year.");
                    tempYear = Console.ReadLine();
                
                
            }
            games[gamesCreated].SetReleaseYear(releaseYear);
            double gameCost = 0;
            Console.WriteLine("Enter the cost for this title");
            string cost = Console.ReadLine();
            while (!double.TryParse(cost, out gameCost) || gameCost <= 0)
            {
                Console.WriteLine("Cost must be a number and greater than zero.");
                cost = Console.ReadLine();
            }
            games[gamesCreated].SetCost(gameCost);
            gamesCreated++;
        }
    }
}
