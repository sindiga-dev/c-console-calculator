// Develop a C# Interest Calculator Console Application. Your calculator should require a user to enter the values of Principal, Rate and Time, it should then ask the user to choose between Simple Interest and Compound Interest before computing and displaying the interest. (Copy and paste your code into the textbox and submit)

using System;

namespace InterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Principal Amount");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Rate of Interest");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Time");
            double time = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of times the interest is compounded per year");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter 1 for Simple Interest and 2 for Compound Interest");
            int choice = Convert.ToInt32(Console.ReadLine());
            double interest = 0;
            if (choice == 1)
            {
                interest = principal * rate * time;
            }
            else if (choice == 2)
            {
                interest = principal * Math.Pow((1 + rate / n), n * time);
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
            Console.WriteLine("The interest is " + interest);
        }
    }
}

