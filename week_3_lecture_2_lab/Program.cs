
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(String[] args)
        {
            //Even and Odd
            Console.WriteLine("please enter number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine(number + "is even");
            }
            else
            {
                Console.WriteLine(number + "is odd");
            }
            // A - 90 <= grade <= 100
            // B - 80 <= grade <= 90
            // C - 70 <= grade <= 80
            // D - 55 <= grade <= 70
            // F - grade <= 55

            //take input from user
            Console.WriteLine("please enter your grade:");
            double grade = Convert.ToDouble(Console.ReadLine());
            char lettergrade = ' ';
            if(grade > 100)
            {
                Console.WriteLine("Grade should be between 0 to 100,please try again.");
                return;
            }
            if(grade >=90 && grade < 100) 
            {
                lettergrade = 'A';
            }
            else if(grade >= 80 && grade < 90)
            {
                lettergrade = 'B';
            }
            else if (grade >= 70 && grade < 80)
            {
                lettergrade = 'C';
            }
            else if (grade >= 55 && grade < 70)
            {
                lettergrade = 'D';
            }
            else
            {
                Console.WriteLine("Unfortunately you did not pass the course and your Grade is F.");
                return;
            }

            string output = $"Your Grade is {lettergrade}";
            Console.WriteLine(output);
        }
    }
}