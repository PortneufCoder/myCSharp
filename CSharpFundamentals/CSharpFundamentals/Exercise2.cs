using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class Exercise2
    {
        public void BiggestNumber()
        {
            Console.WriteLine("Enter a number: ");
            var firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            var secondNum = Convert.ToInt32(Console.ReadLine());

            var maxNum = (firstNum > secondNum) ? firstNum : secondNum;

            Console.WriteLine("The highest number is " + maxNum);
        }
    }
}
