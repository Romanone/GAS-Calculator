namespace GAS_Calculator
{
    static class Math
    {
        static private decimal pricePerOne;
        static private decimal savingsPerOne;

        static public decimal Result { get; set; }
        static public decimal PetrolPrice { get; set; }
        static public decimal GASPrice { get; set; }
        static public decimal PetrolRate { get; set; }
        static public decimal GASRate { get; set; }
        static public decimal PriceForParts { get; set; }


        static public decimal PricePerOne(decimal patrol, decimal rate)
        {
            return pricePerOne = patrol * rate / 100;
        }

        static public void SavingsPerOne()
        {
            if (PetrolPrice > GASPrice)
                savingsPerOne = (PetrolPrice * PetrolRate / 100) - (GASPrice * GASRate / 100);
            else
                savingsPerOne = (GASPrice * GASRate / 100) - (PetrolPrice * PetrolRate / 100);
        }

        static public decimal DistanceForZeroPrice()
        {
            Result = -1;

            for (int i = 1; Result <= 0; i++)
            {
                Result = savingsPerOne * i - PriceForParts;

                if (Result >= 0)
                {
                    Result = i;
                    break;
                }
            }
            return Result;
        }
    }
}
