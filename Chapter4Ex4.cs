using System;

namespace Chapter4Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int P1Total = 0;
            int P2Total = 0;
            bool play = false;
            Console.WriteLine("Shall we play a game?\n\n" +
                "Y to intialize or any other key to quit.");
            string answer = Console.ReadLine();
            if (answer == "Y" || answer == "y")
            {
                play = true;

                while (play == true)
                {
                    P1Total = 0;
                    P2Total = 0;
                    int currentResult = 0;
                    Console.WriteLine("Rolling for Player 1");
                    for (int i = 1; i <= 28; i++)
                    {
                        currentResult = random.Next(1, 7);
                        P1Total += currentResult;
                        Console.WriteLine($"This roll is {i} and was {currentResult} and the total is {P1Total}");
                        currentResult = 0;
                    }

                    bool P2Ready = false;
                    Console.WriteLine($"final score for Player 1 is {P1Total}\n" +
                        $"Are you ready for your rolls?\n" +
                        $"y to begin or any other key to quit");
                    string P2Answer = Console.ReadLine();
                    if (P2Answer == "Y" || P2Answer == "y")
                    {

                        P2Ready = true;
                        do
                        {

                            currentResult = random.Next(1, 7);
                            P2Total += currentResult;
                            Console.WriteLine($"This roll was {currentResult} and the total is {P2Total}\n" +
                                "Continue? Y to do so, any other key to quit and check results");
                            string cont = Convert.ToString(Console.ReadLine());
                            currentResult = 0;
                            if (cont == "Y" || cont == "y")
                            {

                                Console.WriteLine("Lets roll!");

                            }
                            else
                            {
                                P2Ready = false;
                                play = false;
                                P2Answer = "";
                            }


                        } while (P2Ready == true);
                        string P1Result = "Player 1 Wins!";
                        string P2Result = "Player 2 Wins!";
                        string tie = "The Game is a Tie!";
                        string inject = "";
                        if (P1Total > 100 && P2Total > 100 )
                        {
                            inject = tie;
                        }
                        else if (P2Total > 100 && P1Total <= 100)
                        {
                            inject = P1Result;
                        }
                        else if (P1Total > 100 && P2Total <= 100 )
                        {
                            inject = P2Result;
                        }
                        else if (P1Total < P2Total)
                        {
                            inject = P2Result;
                        }
                        else if (P1Total > P2Total)
                        {
                            inject = P1Result;
                        }
                        else
                        {
                            inject = tie;
                        }
                        Console.WriteLine($"Currently the total for Player 1 the total is {P1Total}\n" +
                            $"For Player 2 is {P2Total} Congrats, {inject}");
                        Console.WriteLine("Shall we play again?\n\n" +
                "Y to intialize or any other key to quit.");
                        answer = Console.ReadLine();
                        if (answer == "Y" || answer == "y")
                        {
                            play = true;
                        }
                        else
                        {
                            play = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("goodbye");
                        play = false;
                    }
                }
            }
        }
    }
}
