using System;

namespace p1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name="";
            string jobname="";
            char EXIT='q';
            decimal laborCost=0.0m;
            int days=0;
            double hours=0.0;
            decimal acCost=0.0m;
            decimal FOOD_COST=200m;
            decimal TRAVEL_COST=400m;
            bool includeFood=false;
            bool includeTravel=false;

            Console.WriteLine("Hello User! Please enter your name: ");
            name=Console.ReadLine();
            Console.WriteLine("Please enter the job name");
            jobname=Console.ReadLine();
            Console.WriteLine("Enter the cost of labor");
            laborCost=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter number of hours: ");
            hours=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enetr number of days: ");
            days=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter cost of accomodation :");
            acCost=Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Do you want to include food cost ?");
            includeFood=Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Do you want to include travel cost ?");
            includeTravel=Convert.ToBoolean(Console.ReadLine());
            







        }
    }
}
