using System.Collections.Generic;
using System.Linq;
using lab21.Model.Interfaces;

namespace lab21.Model
{
    class NonParallelManager : IProcessBase
    {
        public double MonthlyIncome(IEnumerable<User> users)
        {
            return users.Sum(x => x.Tariff.Price);
        }
    }
}
