using System.Numerics;

namespace Chapter4Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Ice Cream Shoppe");
            Console.WriteLine("Firstly, enter the number of cones you wish to have");

            int i = 0;
            int amount = int.Parse(Console.ReadLine());
            char[] coneSize = new char[amount];
            string[] flavor = new string[amount];
            double[] price = new double[amount];
            double total = 0;


            for (i = 0; i < amount; i++)
            {

                Console.WriteLine($"What size would you like for cone {(i + 1)}\n" +
                    "press [s] for Small\n" +
                    "press [m] for Medium\n" +
                    "press [l] for Large\n" +
                    "once you make your selection we will ask for flavor(s)"
                    );
                coneSize[i] = char.ToLower(char.Parse(Console.ReadLine()));
                
                if (coneSize[i] != 's'&& coneSize[i] != 'm'&& coneSize[i] != 'l')
                {
                    Console.WriteLine("Not a valid choice, please try again.");
                    coneSize[i] = char.ToLower(char.Parse(Console.ReadLine()));
                }
                

                switch (coneSize[i])
                {
                    case 's':
                        Console.WriteLine("What flavor would you like?");
                        flavor[i] = Console.ReadLine();
                        price[i] += 2.50;
                        Console.WriteLine($"Awesome, here is Cone {(i+1)}");
                        break;
                    case 'm':
                        Console.WriteLine("What flavor would you like?\n");
                        for (int m = 0; m < 2; m++)
                        {
                            Console.WriteLine($"what will be flavor {m + 1}?");
                            flavor[i] += "\n"+ Console.ReadLine();
                        }
                        price[i] += 3.00;
                        Console.WriteLine($"Awesome, here is Cone {(i + 1)}");
                        break;
                    case 'l':
                        Console.WriteLine("What flavor would you like? Please state three flavors");
                        for (int l = 0; l < 3; l++)
                        {
                            Console.WriteLine($"what will be flavor {l + 1}?");
                            flavor[i] += "\n"+Console.ReadLine();
                        }
                        price[i] += 3.50;
                        Console.WriteLine($"Awesome, here is Cone {(i + 1)}");
                        break;
                    default:
                        Console.WriteLine("not a valid selection, try again");
                        i--;
                        break;
                }
                
            }

            for (int x = 0; x < amount; x++) {
                
                string[] sizeName = new string[3] { "small", "medium", "large" };
                string[] sizeArr = new string[amount];
                switch (coneSize[x])
                {
                    case 's':
                        sizeArr[x] = sizeName[0];
                        break;
                    case 'm':
                        sizeArr[x]=sizeName[1];
                        break;
                    case 'l':
                        sizeArr[x] = sizeName[2];
                        break;
                }
                Console.WriteLine($"********** Cone {(x + 1)} **********\n" +
                    $"Size: {sizeArr[x]}\n" +
                    $"Flavor: " +
                    $"{flavor[x]}" +
                    $"\nPrice: {price[x]:C}"
                    );
                total += price[x];
                   
                }
            Console.WriteLine($"********************" +
                $"\nYour total is {total:C}");




        }
    }
}

