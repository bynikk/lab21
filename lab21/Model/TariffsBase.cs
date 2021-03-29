using System.Collections.Generic;

namespace lab21.Model.TariffPlans
{
    public class TariffsBase
    {

        public TariffsBase()
        {
            Tariffs = new Dictionary<string, TariffPlan>();
        }

        public Dictionary<string, TariffPlan> Tariffs { get; private set; }

        public void AddTariff(TariffPlan tariffPlan)
        {
            Tariffs.Add(tariffPlan.TariffName, tariffPlan);
        }
    }
}
