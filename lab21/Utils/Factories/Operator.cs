using lab21.Model;
using lab21.Model.TariffPlans;
using lab21.Utils.Factories.Base;

namespace lab21.Utils.Factories
{
    public class Operator : IMakeUser, IMakeTariff
    {
        public User MakeUser(string name, TariffPlan tariff)
        {
            return new User() { Name = name, Tariff = tariff };
        }

        public TariffPlan MakeTariff(string name, double price)
        {
            return new TariffPlan() { TariffName = name, Price = price };
        }
    }
}
