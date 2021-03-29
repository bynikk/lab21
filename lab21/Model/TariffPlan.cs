using lab21.Utils;
using System.Collections.Generic;

namespace lab21.Model.TariffPlans
{
    public class TariffPlan
    {
        public TariffPlan()
        {
        }

        public double Price { get; set; }
        public string TariffName { get; set; }

        public override string ToString()
        {
            return $" {TariffName} - {Price} BYN/month";
        }
    }
}
