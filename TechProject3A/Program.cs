// Programmer: Nikhil Patel
// Date: 09/24/2020
// Description: Creating lines of code to tell user to enter their name and spit out a welcome message including the input
using System;

namespace TechProject3A
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, input;
            int age;
            Console.WriteLine(" What is your Name? Please enter it below. ");
            name = Console.ReadLine();
            Console.WriteLine(" What is your Age? Please enter it below");
            input = Console.ReadLine();
            age = Convert.ToInt32(input);
            Console.WriteLine(" Hello " + name + " It's cool that you are " + age +  " , also USF is #1 "); 
            Console.Read();
        }
    }
}
