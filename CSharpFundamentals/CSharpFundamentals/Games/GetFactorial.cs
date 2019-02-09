using System;


namespace CSharpFundamentals.Games
{
    public class GetFactorial
    {
        public void CalculateFactorial()
        {
            Console.WriteLine("Please enter a number: ");
            var highestFactorial = Convert.ToInt32(Console.ReadLine());

            var lowestFactorial = 1;

            for (var i = 1; i <= highestFactorial; i++)
            {
                lowestFactorial *= i;

                Console.WriteLine("{0}! = {1}", highestFactorial, lowestFactorial);
            }
        }
    }
}
