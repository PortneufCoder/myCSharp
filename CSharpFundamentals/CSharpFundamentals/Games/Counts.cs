using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Games
{
    public class Counts
    {
        public void getTheCount()
        {
            Console.WriteLine("Please enter a number: or press ok to exit");
            var firstTry = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Take 2... please enter a number: or press ok to exit");
            var secondTry = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final chance! please enter a number: or press ok to exit");
            var thirdTry = Convert.ToInt32(Console.ReadLine());

            var sumOfAllTries = firstTry + secondTry + thirdTry;

            Console.WriteLine("Total tries = " + sumOfAllTries);
        }
    }
}
