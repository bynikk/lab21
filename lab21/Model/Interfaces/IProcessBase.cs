using System;
using System.Collections.Generic;
using System.Text;

namespace lab21.Model.Interfaces
{
    public interface IProcessBase
    {
        public double MonthlyIncome(IEnumerable<User> users);

    }
}
