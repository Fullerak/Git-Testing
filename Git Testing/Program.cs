// See https://aka.ms/new-console-template for more information
using Git_Testing;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creaing an object called test of the class
            StatsLibrary test = new StatsLibrary();

            //making a test array
            double[] array = { 1.0, 2.0, 3.0, 4.0};

            //calling the mean method on the array and printing it
            Console.WriteLine("The mean is: " + test.getMean(array));

            Console.ReadKey();
        }
    }
}


