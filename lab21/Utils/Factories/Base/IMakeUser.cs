using lab21.Model.TariffPlans;

namespace lab21.Model
{
    public interface IMakeUser
    {
        public User MakeUser(string name, TariffPlan tariff);
    }
}
