using System;
using CSharpFundamentals;
using CSharpFundamentals.Math;


namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var victor = new Person();
            victor.FirstName = "Albert";
            victor.LastName = "Einstein";
            victor.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(3, 4);
            Console.WriteLine(result);

            int[] myArray = new int[4] { 5, 7, 9, 12 };
            Console.WriteLine(myArray[1]);
        }
    }
}
