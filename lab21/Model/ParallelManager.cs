using lab21.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lab21.Model
{
    class ParallelManager : IProcessBase
    {
        public double MonthlyIncome(IEnumerable<User> users)
        {
            return users.AsParallel().Sum(x => x.Tariff.Price);
        }
    }
}
