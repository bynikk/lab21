using lab21.Model.TariffPlans;
using System;
using System.Collections.Generic;

namespace lab21.Utils
{
    public class UsersPrinter
    {
        public static void PrintUsersList(List<TariffPlan> users)
        {
            foreach (TariffPlan user in users)
            {
                Console.WriteLine(user.ToString());
            }
        }
}
}
