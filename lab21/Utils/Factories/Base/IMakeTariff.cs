using lab21.Model.TariffPlans;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab21.Utils.Factories.Base
{
    interface IMakeTariff
    {
        public TariffPlan MakeTariff(string name, double price);
    }
}
