using System.Runtime.Serialization;

namespace Ch9Ex2PrivateAccess
{
    class Work
    {
        public int WO;
        public int TechId;
        public int Serial;
        public string Tech;

        //constructors
        //default
        public Work()
        {
            WO = 0;
            TechId = 0;
            Serial = 0;
            Tech = string.Empty;
        }
        //parameter
        public Work(int WO, int techId, int serial, string tech)
        {
            this.WO = WO;
            TechId = techId;
            Serial = serial;
            Tech = tech;
        }
        public void Print()
        {
            Console.WriteLine($"Work Order#{WO} for serial # {Serial} assigned to {TechId}, {Tech}");
        }

    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Work work = new Work();
            AddData( work );
            work.Print();

            //default with direct assignment

            Work workb = new Work();
            workb.WO = 1231;
            workb.Serial = 10001;
            workb.TechId = 616;
            workb.Tech = "John";
            Console.WriteLine($"Work Order#{workb.WO} for serial # {workb.Serial} assigned to {workb.TechId}, {workb.Tech}");

            // parameterized

            Work workc = new Work(5555, 231, 20002, "Fred");
            workc.Print();

        }
        static void AddData(Work work)
        {

            Console.WriteLine("Please enter a 4 digit Work Order number to begin\n\n" +
                "First number can not be [0].");
            string strWo = Convert.ToString(Console.ReadLine());
            while (strWo.Length != 4 || strWo.StartsWith('0')|| !int.TryParse(strWo, out work.WO))
            {
                Console.WriteLine("Your entry is too short/long" +
                    "\nstarted with 0 or had letters/characters");
                strWo = Convert.ToString(Console.ReadLine());
            }
            Console.WriteLine("Enter the Serial number (numbers only)\n" +
                "that will be associated to the WO#");
            while (!int.TryParse(Console.ReadLine(),out work.Serial))
            {
                Console.WriteLine("Serial number is not valid, only numbers 0-9");
                
            }
            Console.WriteLine("please enter the Tech Id Number (3 numbers) that you wish to assign");
            string number = Console.ReadLine();
            Console.WriteLine("please enter the Tech's name that you wish to assign to this WO");
            string name = Console.ReadLine();
            while (!int.TryParse(number, out work.TechId)|| number.Length!=3)
            {
                Console.WriteLine("The tech ID is not a valid ID");
                number = Console.ReadLine();
            }
            for (int i = 0; i < name.Length; i++) 
            {
                if (!char.IsLetter(name[i]) || char.IsWhiteSpace(name[i])) 
                {
                    Console.WriteLine("Tech Name is not a valid name, Try again.");
                    i= -1;
                    name=Console.ReadLine();
                }
            }
            work.Tech = name;

            
           
        }
    }
}
