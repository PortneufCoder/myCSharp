using System;
using CSharpFundamentals;
using CSharpFundamentals.Math;


namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1; // held in one spot in memory since its a value type
            Increment(number);
            Console.WriteLine(number); // 1

            var person = new Person() {Age = 20}; // this age will be added to the MakeOld method since its a reference type(Class)
            MakeOld(person);
            Console.WriteLine(person.Age);


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

        public static void Increment(int number) // this number here is another spot in memory
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
