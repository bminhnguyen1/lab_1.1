using System;
using System.Collections.Generic;
using System.Text;

namespace lap_1._2._4
{
    class PriceCalculator
    {
        public enum SeasonMultiplier //enum : hàm liệt kê
        {
            autumn=1, spring, winter, summmer
        }
        public enum DiscountPercentage
        {
            None,
            vip = 10,
            supervip = 20
        }

        private decimal pricePerNight;
        private int nights;
        private SeasonMultiplier seasonMultiplier;
        private DiscountPercentage discountPercentage;

        public PriceCalculator(string[] commandArgs)
        {
            pricePerNight = decimal.Parse(commandArgs[0]);
            nights = int.Parse(commandArgs[1]);
            seasonMultiplier = Enum.Parse<SeasonMultiplier>(commandArgs[2]);
            discountPercentage = DiscountPercentage.None;

            if (commandArgs.Length == 4)
            {
                discountPercentage = Enum.Parse<DiscountPercentage>(commandArgs[3]);
            }
        }

        public decimal GetTotalPrice()
        {
            decimal basePrice = pricePerNight * nights * (int)seasonMultiplier;

            return basePrice - basePrice * (decimal)discountPercentage / 100;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter price per day, number of day, season, discount type");
            var input = Console.ReadLine()
                .Split();
            var priceCalculator = new PriceCalculator(input);

            Console.Write("total price: ");
            Console.WriteLine(priceCalculator.GetTotalPrice().ToString("F2"));
        }
    }
}
