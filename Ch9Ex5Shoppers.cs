using System;
using System.Collections.Generic;

namespace Shoppers
{
    class ShoppingClub
    {
        // private fields
        public string Name {  get; set; }
        private int _Age ;
        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                _Age = value;
                if (_Age < 18)
                
                    
                    AgeRestriction = true;
                    
                
                else
                
                    
                    AgeRestriction = false;
                   
                
            }
        }
        public bool AgeRestriction { get; private set; } = false;

        // Get methods for private fields
       
      

        // Set methods for private fields
        
    

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            ShoppingClub shopper1 = new ShoppingClub();
            ShoppingClub shopper2 = new ShoppingClub();
            ShoppingClub shopper3 = new ShoppingClub();

            Console.Write("Name: ");
            shopper1.Name= Console.ReadLine();
            Console.Write("Age: ");
            shopper1.Age = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            shopper2.Name = Console.ReadLine();
            Console.Write("Age: ");
            shopper2.Age = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            shopper3.Name = Console.ReadLine();
            Console.Write("Age: ");
            shopper3.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Here's your shopping group");

            Console.WriteLine($"Name: {shopper1.Name}  Age: {shopper1.Age}");
            if (shopper1.AgeRestriction == true)
                Console.WriteLine("This shopper cannot purchase alcohol!");

            Console.WriteLine($"Name: {shopper2.Name}  Age: {shopper2.Age}");
            if (shopper2.AgeRestriction == true)
                Console.WriteLine("This shopper cannot purchase alcohol!");

            Console.WriteLine($"Name: {shopper3.Name}  Age: {shopper3.Age}");
            if (shopper3.AgeRestriction == true)
                Console.WriteLine("This shopper cannot purchase alcohol!");
           
        }
    }
}