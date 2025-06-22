using System;

namespace FinancialForecasting
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialValue = 5000;
            double growthRate = 0.07;
            int years = 10;

            double futureValue = CalculateFutureValue(initialValue, growthRate, years);
            Console.WriteLine($"Future Value after {years} years: {futureValue:F2}");

            Console.ReadLine();
        }

        static double CalculateFutureValue(double principal, double rate, int years)
        {
            if (years == 0)
                return principal;

            return CalculateFutureValue(principal, rate, years - 1) * (1 + rate);
        }
    }
}
