using System;
using System.Diagnostics;


namespace BMI_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight in lbs: ");
            double pounds = double.Parse(Console.ReadLine());//variable to hold weight

            Console.Write("Enter your height in inches: ");
            double inches = double.Parse(Console.ReadLine()); //variable to hold height

            double bmi = (pounds * 703) / (inches * inches); //calculate bmi

            if(bmi < 18.5)
            {
                Console.WriteLine($"Your body mass index is {bmi}\naccording to the Department of Health and Human Services your BMI falls within the Underweight cateogry");
                
            } else if(bmi > 18.5 && bmi < 24.9)
            {
                Console.WriteLine($"Your body mass index is {bmi}\naccording to the Department of Health and Human Services your BMI falls within the Normal cateogry");
            } else if(bmi > 25 && bmi < 29.9)
            {
                Console.WriteLine($"Your body mass index is {bmi}\naccording to the Department of Health and Human Services your BMI falls within the Overweight cateogry");
            } else if(bmi > 30)
            {
                Console.WriteLine($"Your body mass index is {bmi}\naccording to the Department of Health and Human Services your BMI falls within the Obese cateogry");
            }
        }
    }
}
