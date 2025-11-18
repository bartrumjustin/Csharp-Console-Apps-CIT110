using System;
using System.ComponentModel.Design;
using System.Xml.Linq;
namespace FunwithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> members = new List<string> { "Mickey", "Minnie", "Donald", "Daisy" };
            string? name = String.Empty;
            string[] nameArr;
            int? menu = 0;
            //Removed redundant call for input validation as while loop's else condition will invoke call
            
            
            while (menu != 4)
            {
                if (menu == 1)
                {
                    printList(members);
                    menu = 0;
                }
                else if (menu == 2)
                {
                    nameArr = addList();
                    members.AddRange(nameArr);
                    menu = 0;
                }
                else if (menu == 3)
                {
                   
                    name = NameValidation();
                    if (members.Contains(name))
                    {
                        members.Remove(name);
                        Console.WriteLine("The name has been deleted");
                        menu = 0;
                    }
                    else
                        Console.WriteLine("Sorry, that name does not exist, please try again");
                }
                else
                    menu = InputValidation();
            }


        }
        static void printList(List<string> mem)
        {
            mem.Sort();
            foreach (string s in mem)
                Console.WriteLine(s);
            return;
        }
        static string[] addList()
        {
            bool isIntFlag= false;
            int number = 0;
            while (isIntFlag==false)
            {
                Console.Write("How many members do you wish to add? ");

                if (int.TryParse(Console.ReadLine(), out number))
                {
                    isIntFlag = true;
                }
                else
                {
                    Console.WriteLine("Enter a valid Integer");
                }
                    
            }
            
            string[] newMembers = new string[number];
            for (int i = 0; i < number; i++)
            {
                Console.Write("Member name? ");
                
                string tempName = Console.ReadLine();
                while (string.IsNullOrEmpty(tempName)==true || string.IsNullOrWhiteSpace(tempName)==true){
                    
                    Console.WriteLine($"Your name entry, {tempName}, is invalid, please try again");
                    tempName = Console.ReadLine();
                }
                newMembers[i] = tempName;
                Console.WriteLine("Valid entry, Name has been added to the list");
            }
            return newMembers;
        }
        static int InputValidation() 
        {
            int parsedInt = 0;
            bool isItNumber = false;
            int selectmin = 1;
            int selectmax = 4;
            
                Console.WriteLine("Please make a selection from the menu");
                Console.WriteLine("1. Print sorted list\n2. Add to List\n3. Delete List\n4. Quit");
                while(!int.TryParse(Console.ReadLine(), out parsedInt) || parsedInt<selectmin||parsedInt>selectmax)
                {
                    Console.WriteLine("Select a valid selection, please.");
                }
              
            return parsedInt;
        }
        static string NameValidation()
        {
            string validName = string.Empty;
            
            bool valid = false;
            while (valid == false)
            {
                Console.Write("Enter the name of the person you want removed from the list: ");
                validName = Console.ReadLine();
                bool emptyOrNull = string.IsNullOrEmpty(validName);
                bool whiteSpace = string.IsNullOrWhiteSpace(validName);
                if (emptyOrNull == true || whiteSpace == true)
                {
                    Console.WriteLine("The name provided is not a valid string, try again.");
                }
                else
                {
                    Console.WriteLine("The name is a valid string");
                    valid = true;
                }
            }
            return validName;
        }
    }
}