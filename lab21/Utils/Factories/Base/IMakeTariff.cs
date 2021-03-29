using lab21.Model.TariffPlans;

namespace lab21.Utils.Factories.Base
{
    interface IMakeTariff
    {
        public TariffPlan MakeTariff(string name, double price);
    }
}
