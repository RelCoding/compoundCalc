using System;

namespace compoundCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter investment sum:");
            int investment = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter annual interest rate:");
            double interestRate = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the number of times per year that interest is compounded per period:");
            int compoundNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of periods the money is invested for:");
            int investmentPeriod = Convert.ToInt32(Console.ReadLine());
            double nt = Math.Pow((compoundNumber * investmentPeriod),(1+interestRate/ compoundNumber ));
            double futureCapital = investment * nt;
            Console.WriteLine("The future value of your investment is:{0}", + futureCapital);
            Console.ReadLine();

        }
    }
}
