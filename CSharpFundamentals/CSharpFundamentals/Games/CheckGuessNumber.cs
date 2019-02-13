using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.Games
{
    public class CheckGuessNumber
    {
        public void AllGuessLogic()
        {
            Console.WriteLine("Please enter the first number: ");
            var firstTry = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number: ");
            var secondTry = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the third number: ");
            var thirdTry = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the fourth number: ");
            var fourthTry = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the fifth number: ");
            var fifthTry = Convert.ToInt32(Console.ReadLine());

            if (firstTry == secondTry) return;

            if (firstTry == thirdTry) return;

            if (firstTry == fourthTry) return;

            if (firstTry == fifthTry) return;
            var allTries = new int[] {firstTry,secondTry,thirdTry,fourthTry,fifthTry};
            Array.Sort(allTries, 0, 5);
            Console.WriteLine(allTries);


        }
    }
}
