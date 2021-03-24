using lab21.Utils;

namespace lab21.Model.TariffPlans
{
    public class TariffPlan
    {
        private string _username;

        private double _price;

        private TariffPlans.TariffNames.TariffName _tariffName;

        public TariffPlan()
        {

        }

        public TariffPlan(string username, TariffPlans.TariffNames.TariffName tarifname)
        {
            Username = username;
            TariffName = tarifname;
            Price = TariffPriceCalculator.Calculate(tarifname);
        }

        public double Price 
        {
            get => _price;
            set { _price = value; }
        }

        public TariffPlans.TariffNames.TariffName TariffName { get => _tariffName; set => _tariffName = value; }
        public string Username { get => _username; set => _username = value; }

        public override string ToString()
        {
            return $"User: {_username} - {_tariffName} - {_price} BYN/month";
        }
    }
}
