using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task3
{
    internal class ParameterDemo
    {
        public int Increase(ref int number)
        {
            // adds 10 to the number using ref
            number += 10;
            return number;
        }

        public void GetFullName(out string fullName)
        {
            // assigning a default full name
            fullName = "Karan Thapa";
        }

        public int SumAll(params int[] numbers)
        {
            // sums all numbers passed in params
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}
