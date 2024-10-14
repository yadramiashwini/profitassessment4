namespace profitassessment4
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Sample input for total cost
            Console.Write("Enter the total cost: ");
            object totalCostInput = Convert.ToDouble(Console.ReadLine());

            // Calculate discounted price
            object discountedPrice = CalculateDiscountedPrice(totalCostInput);

            // Output the result
            Console.WriteLine($"Discounted Price: {discountedPrice}");
        }

        public static object CalculateDiscountedPrice(object totalCost)
        {
            // Unbox the total cost from object to double
            double cost = (double)totalCost;

            // Calculate discount based on cost range
            double discount;
            if (cost >= 100 && cost <= 500)
            {
                discount = 0.05 * cost; // 5% discount
            }
            else if (cost > 500 && cost <= 1000)
            {
                discount = 0.15 * cost; // 15% discount
            }
            else if (cost > 1000)
            {
                discount = 0.30 * cost; // 30% discount
            }
            else
            {
                discount = 0; // No discount for costs below 100
            }

            // Calculate the discounted price
            double discountedPrice = cost - discount;

            // Box the result double value as an object and return it
            return (object)discountedPrice;
        }
    }
}