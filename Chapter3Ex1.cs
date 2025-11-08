using static System.Formats.Asn1.AsnWriter;
namespace Chapter3Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Prompt for the pin and store the pin in variable
            Console.WriteLine("Enter Pin and press Enter");
            int pin = int.Parse(Console.ReadLine());
            if (pin <= 999 || pin >= 10000)
            {
                Console.WriteLine("Your entered pin is less than or greater than 4 digits!" +
                "\nplease try again");
            }
            int discount = 0;
            if (pin > 5000)
            {
                discount = 20;
            }
            else if (pin > 1000)
            {
                discount = 15;
            }
            else if (pin > 100)
            {
                discount = 10;
            }
            else
            {
                discount = 5;
            }
            Console.WriteLine($"Thank you, Your Pin is {pin} " +
            $"\nwhich means your discount is {discount}%!"
            + "\nHow much have you spent today?");
            int amountSpent = int.Parse(Console.ReadLine());
            double totalCost = amountSpent - (amountSpent * (discount * .01));
            Console.WriteLine($"Your subtotal is {amountSpent:C}" +
            $"\nwith your discount of {discount}% \nyour grand total is {totalCost:C}!");

        }
    }
}
