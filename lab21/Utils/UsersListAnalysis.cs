using System.Collections.Generic;
using lab21.Model.TariffPlans;

namespace lab21.Utils
{
    public class UsersListAnalysis
    {
        public static double CalculateProfitPerMonth(List<TariffPlan> users)
        {
            double profit = 0;

            foreach (TariffPlan user in users)
            {
                profit += user.Price;
            }

            return profit;
        }

        public static TariffPlan FindMaxProfitUser(List<TariffPlan> users)
        {
            TariffPlan temp = new TariffPlan();

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Price > temp.Price)
                {
                    temp = users[i];
                }
            }

            return temp;
        }

        public static TariffPlan FindMinProfitUser(List<TariffPlan> users)
        {
            TariffPlan temp = new TariffPlan();

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].Price <= temp.Price)
                {
                    temp = users[i];
                }
            }

            return temp;
        }
    }
}
