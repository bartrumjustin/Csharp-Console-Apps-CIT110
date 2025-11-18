using System.Reflection.Metadata.Ecma335;

namespace Ch7MathMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            string test = "";
            bool testFlag = false;
            
            
                for (int i = 1; i < 3; i++) {
                while (testFlag == false)
                {
                    Console.WriteLine($"Pick a number for n{i}");
                    test = Console.ReadLine();
                    testFlag = ValidateInt(test);
                }
                if (i == 1)
                {
                   n1=int.Parse(test);
                    testFlag = false;
                }
                else
                {
                    n2=int.Parse(test);
                }
            }
            int max = Math.Max(n1, n2);
            Console.WriteLine($"Max is {max}");
            int min = Math.Min(n1, n2);
            Console.WriteLine($"Min is {min}");
            double pown1 = Math.Pow(n1,2);
            Console.WriteLine($"n1 to the power of 2 is {pown1}");
            double pown2 = Math.Pow(n2,2);
            Console.WriteLine($"n2 to the power of 2 is {pown2}");
            double sqr1 = Math.Sqrt(n1);
            Console.WriteLine($"square root of n1 {n1} is {sqr1}");
            double sqr2 = Math.Sqrt(n2);
            Console.WriteLine($"square root of n2 {n2} is {sqr2}");
            if (Math.Abs(n2) > 0)
            {
                int div = n1 / n2;
                int rem = n1 % n2;
                Console.WriteLine($"dividing n2 by n1 is {div} with {rem} as the remainder");
            }
            else
            {
                Console.WriteLine("Could not perform a division and remainder method");
            }

        }
        static bool ValidateInt(string test)
        {
            int examined;
            bool result = false;
            if (int.TryParse(test, out examined)) {
              result = true;
            } return result;
        }
    }
}
