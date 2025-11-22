using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
namespace MythicalCreatures
{
    class Creature
    {
        // public fields
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        // private fields
        public bool IsDangerous { get; set; }
        public bool IsHuman { get; set; }
        public List<string> Powers { get; set; }
        // default constructor
        public Creature()
        {
            Id = 0;
            Type = string.Empty;
            Name = string.Empty;
            IsDangerous = false;
            IsHuman = false;
            Powers = new List<string> { };
        }
        // parameterized constructor
        public Creature(int i, string typ, string nm, bool danger, bool human, List<string> pow)
        {
            Id = i;
            Type = typ;
            Name = nm;
            IsDangerous = danger;
            IsHuman = human;
            Powers = pow;
        }
        // Get methods for private fields
        
        
        
        // Set methods for private fields
        
        
        public void Print()
        {
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine($"Creature # {Id + 1}, {Name}");
            Console.WriteLine($"Type: {Type}    Dangerous? {IsDangerous}     Human? {IsHuman}");
            if (Powers.Count > 0)
            {
                Console.Write($"Powers include: ");
                for (int i = 0; i < Powers.Count; i++)
                {
                    Console.Write($" {Powers[i]} ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------");
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many creatures would you like to enter?");
            string strCount = Console.ReadLine();
            int count;
            while (!int.TryParse(strCount, out count) && count <= 0)
            {
                Console.WriteLine($"Please enter a whole number greater than zero");
                strCount = Console.ReadLine();
            }
            int creatureCounter = 0;
            // Create an array of creature objects. 
            Creature[] myCreature = new Creature[count];
            // initialize all elements in the myCreature array by running each through the constructor
            for (int i = 0; i < count; i++)
            {
                myCreature[i] = new Creature();
            }
            char select = menu();
            while (select != 'Q')
            {
                switch (select)
                {
                    case 'A':
                        if (creatureCounter < count)
                        {
                            AddCreature(myCreature, ref creatureCounter);
                        }
                        else
                        {
                            Console.WriteLine($"You have reached the maximum number of creatures that you can add.");
                        }
                        break;
                    case 'P':
                        if (creatureCounter == 0)
                            Console.WriteLine($"You must add a creature before you can print it out");
                        else
                        {
                            for (int i = 0; i < creatureCounter; i++)
                                myCreature[i].Print();
                        }
                        break;
                    default:
                        Console.WriteLine($"You have selected a bad command, please try again.");
                        break;
                }
                select = menu();

            }// end while loop
        }// end main()

        private static void AddCreature(Creature[] myCreature, ref int creatureCounter)
        {
            // Handling Public Fields
            // Set the ID to the creature counter
            myCreature[creatureCounter].Id = creatureCounter;

            // Enter the type from the console and validate data
            Console.Write("Enter the type of creature( elf, vampire, werewolf etc.) ");
            string? tempValue = Console.ReadLine();
            while (String.IsNullOrEmpty(tempValue) || String.IsNullOrEmpty(tempValue))
            {
                Console.WriteLine("The Type cannot be spaces, null or empty, try again please");
                tempValue = Console.ReadLine();
            }
            myCreature[creatureCounter].Type = tempValue;

            // Enter the name from the console and validate data
            Console.Write("Enter the name of the creature: ");
            tempValue = Console.ReadLine();
            while (String.IsNullOrEmpty(tempValue) || String.IsNullOrEmpty(tempValue))
            {
                Console.WriteLine("The Type cannot be spaces, null or empty, try again please");
                tempValue = Console.ReadLine();
            }
            myCreature[creatureCounter].Name = tempValue;

            // Handling Private Fields
            // If the creature is dangerous, use the Set method to enter a value of true
            Console.Write("Is the creature dangerous? (y for yes, n for no) ");
            tempValue = Console.ReadLine();
            char temp;
            while (!char.TryParse(tempValue, out temp) && Char.ToLower(temp) != 'y' && Char.ToLower(temp) != 'n')
            {
                Console.WriteLine("The value must be y or n, please try again");
                tempValue = Console.ReadLine();
            }
            if (Char.ToLower(temp) == 'y')
                myCreature[creatureCounter].IsDangerous = true;
            else
                myCreature[creatureCounter].IsDangerous = false;

            // If the creature is human, use the Set method to enter a value of true
            Console.Write("Is the creature all or part human? (y for yes, n for no) ");
            tempValue = Console.ReadLine();
            while (!char.TryParse(tempValue, out temp) && Char.ToLower(temp) != 'y' && Char.ToLower(temp) != 'n')
            {
                Console.WriteLine("The value must be y or n, please try again");
                tempValue = Console.ReadLine();
            }
            if (Char.ToLower(temp) == 'y')
                myCreature[creatureCounter].IsHuman=true;
            else
                myCreature[creatureCounter].IsHuman=false;

            // If the creature has powers, add them to a temporary list 
            // Once the temp list is done, use the SetPowers method to add the powers to the object
            Console.Write("Does the creature have powers? (y for yes, n for no) ");
            tempValue = Console.ReadLine();
            while (!char.TryParse(tempValue, out temp) && Char.ToLower(temp) != 'y' && Char.ToLower(temp) != 'n')
            {
                Console.WriteLine("The value must be y or n, please try again");
                tempValue = Console.ReadLine();
            }
            if (Char.ToLower(temp) == 'y')
            {
                List<string> powers = new List<string> { };
                string? powerEntered = "";
                while (powerEntered != "quit")
                {
                    Console.Write("Enter the super power or quit to end: ");
                    powerEntered = Console.ReadLine();
                    while (String.IsNullOrEmpty(powerEntered) || String.IsNullOrEmpty(powerEntered))
                    {
                        Console.WriteLine("The power cannot be spaces, null or empty, try again please");
                        powerEntered = Console.ReadLine();
                    }
                    if (powerEntered == "quit")
                        continue;
                    powers.Add(powerEntered);
                }
                myCreature[creatureCounter].Powers=powers;
            }
            creatureCounter++;
        }

        public static char menu()
        {
            Console.WriteLine($"Please make a selection from the menu");
            Console.WriteLine($"A - Add, P - Print, Q - Quit");
            string? value = Console.ReadLine();
            char choice;
            while (!char.TryParse(value, out choice) && choice != 'A' && choice != 'P' && choice != 'Q')
            {
                Console.WriteLine($"Please enter an A, P or Q");
                value = Console.ReadLine();
            }
            return Char.ToUpper(choice);
        }

    }// end program class
}// end namespace