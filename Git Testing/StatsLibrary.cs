using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git_Testing
{
    //creating a class named 'StatsLibrary'
    class StatsLibrary
    {
        //adding the default constructor
        public StatsLibrary() 
        { 
        
        }

        //making a method with the return type double and the param of an arr
        public double getMean(double[] arr)
        {

            //making a variable to store the sum
            double sum = 0;

            //for loop to add all the numbers in the arr
            foreach (double nums in arr)
            {
                sum = sum + nums;
            }

            //making a variable to return mean
            double mean = sum / arr.Length;

            return mean;
        }

    }
}
