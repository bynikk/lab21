using lab21.Model.TariffPlans;
using lab21.Utils;
using lab21.View;
using System.Collections.Generic;


namespace lab21
{
    class Program
    {
        static void Main()
        {
            List<TariffPlan> users = new List<TariffPlan>()
            {
                new TariffPlan("Nikita", TariffNames.TariffName.Beginner),
                new TariffPlan("Alex", TariffNames.TariffName.Unlimited),
                new TariffPlan("Danila", TariffNames.TariffName.Advanced),
                new TariffPlan("Sergey", TariffNames.TariffName.Unknown),
                new TariffPlan("Vlad", TariffNames.TariffName.Comfort),
                new TariffPlan("Ptn", TariffNames.TariffName.Unlimited)
            };

            UsersPrinter.PrintUsersList(users);

            Printer.Print($"Company profit per month {UsersListAnalysis.CalculateProfitPerMonth(users)} BYN\n");
            Printer.Print($"Max profit user {UsersListAnalysis.FindMaxProfitUser(users)}\n");
            Printer.Print($"min profit user {UsersListAnalysis.FindMinProfitUser(users)}\n");

        }
    }
}
