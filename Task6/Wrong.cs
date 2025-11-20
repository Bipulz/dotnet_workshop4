using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Wrong
    {
        static void Main(string[] args)
        {
            Console.Write("Marks: ");
            string mInput = Console.ReadLine();

            Console.Write("Total: ");
            string tInput = Console.ReadLine();

            int m;
            int t;

            bool okM = int.TryParse(mInput, out m);
            bool okT = int.TryParse(tInput, out t);

            if (!okM || !okT)
            {
                Console.WriteLine("Invalid entry! Only integers allowed.");
                return;
            }

            // Still incorrect because both values are integers
            double percent = m / t * 100;

            Console.WriteLine("Computed percentage: " + percent);
            Console.ReadLine();
        }
    }
}
