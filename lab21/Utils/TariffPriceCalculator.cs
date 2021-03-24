using lab21.Model.TariffPlans;

namespace lab21.Utils
{
    public class TariffPriceCalculator
    {
        public static double Calculate(TariffNames.TariffName TariffName)
        {
            return TariffName switch
            {
                TariffNames.TariffName.Unlimited => 29.9,
                TariffNames.TariffName.Advanced => 16.5,
                TariffNames.TariffName.Comfort => 9.9,
                TariffNames.TariffName.Beginner => 7.7,
                TariffNames.TariffName.Unknown => 0,
                _ => 1
            };
        }
    }
}
