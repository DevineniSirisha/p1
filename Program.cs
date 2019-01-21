using System;

namespace p1
{
    class Program
    {
        const decimal FOOD_COST = 200m;
        const decimal TRAVEL_COST = 400m;
        static void Main(string[] args)
        {
            char exit = 'c';
            while (exit != 'q')
            {
                string name = "";
                string jobName = "";
                decimal laborCost = 0.0m;
                int days = 0;
                int hours = 0;
                decimal acCost = 0.0m;
                bool includeFood = false;
                bool includeTravel = false;
                while (name == "")
                {
                    Console.WriteLine("Hello User! Please enter your name: ");
                    name = Console.ReadLine();

                }
                while (jobName == "")
                {
                    Console.WriteLine("Please enter the job name");
                    jobName = Console.ReadLine();
                }

                while (laborCost == 0.0m)
                {
                    Console.WriteLine($"Enter the cost of labor per hour: ");
                    laborCost = Convert.ToDecimal(Console.ReadLine());
                }

                while (hours == 0.0)
                {
                    Console.WriteLine($"Enter number of hours per day: ");
                    hours = Convert.ToInt32(Console.ReadLine());
                }
                while (days == 0)
                {
                    Console.WriteLine($"Enter number of days: ");
                    days = Convert.ToInt32(Console.ReadLine());
                }
                while (acCost == 0.0m)
                {
                    Console.WriteLine($"Enter cost of accomodation :");
                    acCost = Convert.ToDecimal(Console.ReadLine());
                }
                Console.WriteLine($"Do you want to include food cost ?(yes/no)");
                var ans = Console.ReadLine();
                if (ans.ToLower() == "yes")
                {
                    includeFood = true;
                }
                else
                {
                    includeFood = false;
                }
                Console.WriteLine($"Do you want to include travel cost ?(yes/no)");
                var a = Console.ReadLine();
                switch (a.ToLower())
                {
                    case "yes":
                        includeTravel = true;
                        break;
                    case "no":
                        includeTravel = false;
                        break;
                    default:
                        includeTravel = false;
                        break;

                }
                var res = calEstimate(laborCost, days, hours, acCost, includeFood, includeTravel);
                Console.WriteLine($"Hello {name}, your job {jobName} costs you {res} ");


                Console.WriteLine($"Enter q to quit or c to continue :");
                exit = Convert.ToChar(Console.ReadLine());
                if (exit == 'q')
                {
                    Console.WriteLine($"GoodBye! Have a nice day !!");
                    break;
                }
            }

        }
        static decimal calEstimate(decimal laborCost, int days, int hours, decimal acCost, bool includeFood, bool includeTravel)
        {
            var num = days * hours;
            return days * hours * (laborCost) + days * (acCost + FOOD_COST + TRAVEL_COST);

        }
    }
}
