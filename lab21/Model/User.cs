using lab21.Model.TariffPlans;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab21.Model
{
    public class User
    {
        public string Name { get; set; }
        public TariffPlan Tariff { get; set; }

        public User()
        {
        }

        public override string ToString()
        {
            return $"{Name} - {Tariff}";
        }
    }
}
