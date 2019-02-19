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
           var numbers = new List<int>();

           while (numbers.Count < 5)
           {
               Console.WriteLine("Enter a number: ");
               var number = Convert.ToInt32(Console.ReadLine());

               if (numbers.Contains(number))
               {
                   Console.WriteLine("You've already entered: " + number);
                   continue; //re-do the guess : go up
               }
               numbers.Add(number); // add guessed numbers to the numbers List
           }

           numbers.Sort();
           Console.WriteLine(numbers);

           foreach (var number in numbers)
           {
               Console.WriteLine(number);
           }
        }
        
    }
}
