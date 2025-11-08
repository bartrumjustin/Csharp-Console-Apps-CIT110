namespace Chapter3Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool lateShift = false;
            bool earlyShift = false;
            int hours = 40;
            int payRate = 50;
            int salary = 0;
            Console.WriteLine("Do you work mornings? Y for yes or press any key");
            string answer = Convert.ToString(Console.ReadLine());
            if(answer == "y" || answer == "Y")
            {
                earlyShift = true;
            }
            else
            {
                lateShift = true;
            }
            if (earlyShift == true)
            {
                salary = hours * payRate;
            }
            else
            {
                salary = hours * payRate + 500;
            }
            Console.WriteLine($"You have worked {hours} and your salary is " + String.Format("{0:C}", salary));
        }
    }
}
