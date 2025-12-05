namespace TigerSoccerClub
{
    public static class PriceCalculator
    {
        public static double Calculate(string registration, string jersey, bool applyDiscount)
        {
            int kids = 150;
            int adult = 230;
            int jerseyPrice = 100;

            // basePrice MUST be double because of discount
            double basePrice = (registration == "Kids") ? kids : adult;

            if (jersey == "Yes")
                basePrice += jerseyPrice;

            if (applyDiscount)
                basePrice -= (basePrice * 0.05);

            return basePrice;
        }
    }
}
