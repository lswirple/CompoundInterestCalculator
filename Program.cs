using System;
using System.Security.Cryptography.X509Certificates;

namespace CompoundInterestCalculator
{
    public class NumberGather // class for gathering inputs
    {
        public double money;
        public double years;
        public void numbGather(double x) // x is amount of money inputted
        {
            money = x;
        }

        public void yearGather(double z) // gathering the years to be calculated for interest
        {
            years = z;
        }

        public void apyCalc()
        {
            switch (years)
            {
                case 1:
                    double yearOne = money * 1.05D;
                    Console.WriteLine($"$" + Math.Round(yearOne, 2));
                    Console.ReadKey();
                    break;
                case 2:
                    double yearTwo1 = money * 1.05D;
                    double yearTwo2 = yearTwo1 * 1.05D;
                    Console.WriteLine($"$" + Math.Round(yearTwo1, 2));
                    Console.ReadKey();
                    break;
                case 3:
                    double yearThree1 = money * 1.05D * 1.05D * 1.05D;
                    Console.WriteLine($"$" + Math.Round(yearThree1, 2));
                    Console.ReadKey();
                    break;
                case 4:
                    double yearFour = money * 1.05D * 1.05D * 1.05D * 1.05D;
                    Console.WriteLine($"$" + Math.Round(yearFour, 2));
                    Console.ReadKey();
                    break;
                case 5:
                    double yearFive = money * 1.05D * 1.05D * 1.05D * 1.05D * 1.05D;
                    Console.WriteLine($"$" + Math.Round(yearFive, 2));
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Please enter value between 1-5.");
                    Console.ReadKey();
                    break;
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            double monFun;
            double yearFun;
            NumberGather mainGather = new NumberGather();
            Console.Write("How much money are you depositing?\n$");
            while (true)
            {
                try
                {
                    monFun = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Not a valid input.");
                }
            }
            Console.WriteLine("How many years are you looking to deposit for?\nPlease choose from 1 to 5 years.");
            while (true)
            {
                try
                {
                    yearFun = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Not a valid input.");
                }
            }
            mainGather.yearGather(yearFun);
            mainGather.numbGather(monFun);
            mainGather.apyCalc();
            
        }
    }
}