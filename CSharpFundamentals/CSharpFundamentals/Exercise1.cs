using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class Exercise1
    {
        public void MagicNumber()
        {
            Console.WriteLine("Please pick a number btw 1 and 10: ");
            var askNumber = Console.ReadLine();
            var pickedNumber = Convert.ToInt32(askNumber);

            if (pickedNumber < 10)
            {
                Console.WriteLine("Great, that is valid.");
            }
            else
            {
                Console.WriteLine("That is invalid");
            }
        }
    }
}
