using System;
using System.Collections.Generic;
using System.Text;
using lab21.Model;
using lab21.Model.TariffPlans;

namespace lab21.Model
{
    public interface IMakeUser
    {
        public User MakeUser(string name, TariffPlan tariff);
    }
}
