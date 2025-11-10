using System;

namespace Chapter4Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double price = 0;
            int i;
            for (i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Enter the price of item# {i}");
                price += double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Your total for {i - 1} items is: ${price}");
            price = 0;
            //convert to while loop
            price = 0;
            i = 1;
            while (i <= 5)
            {
                Console.WriteLine($"Enter the price of item# {i}");
                price += double.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine($"Your total for {i - 1} items is: ${price}");
            price = 0;
            // end of conversion...
            //convert to do...while loop
            i = 1;
            price = 0;
            do
            {
                Console.WriteLine($"Enter the price of item# {i}");
                price += double.Parse(Console.ReadLine());
                i++;
            }while(i <= 5);
            Console.WriteLine($"Your total for {i - 1} items is: ${price}");
            //end of conversion...
        }
    }
}