using System;
using System.Runtime.InteropServices;
using CSharpFundamentals;
using CSharpFundamentals.Math;
using CSharpFundamentals.Games;


namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var guessingGame = new CheckGuessNumber();
            guessingGame.AllGuessLogic();
            /* 
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

            var season = Season.Autumn;
            var Exercise1 = new Exercise1();
            Exercise1.MagicNumber();

            var Exercise2 = new Exercise2();
            Exercise2.BiggestNumber();

            var ImageExercise = new ImageDimensions();
            ImageExercise.Image();

            var DriverLicense = new SpeedCamera();
            DriverLicense.CalculateSpeedLimit();

            var getRandom = new LearningRandom();
            getRandom.RandomClass();

            var enterCount = new Counts();
            enterCount.getTheCount();

            var reverseLogic = new ReverseNameExercise();
            reverseLogic.ReverseName();

            // Length()
            var numbers = new[] {3, 7, 9, 15, 24, 18};
            Console.WriteLine("Length: " + numbers.Length);

            // Indexof()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9 " + index );

            // Clear()
            Array.Clear(numbers, 0, 5);
            Console.WriteLine("Effect of Clear()");

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            // Copy()
            int[] anotherArray = new int[3];
            Array.Copy(numbers, anotherArray, 3);

            Console.WriteLine("Effect of Copy()");

            foreach (var n in anotherArray)
                Console.WriteLine(n);

            switch (season)
            {
                case Season.Autumn:
                case Season.Spring:
                    Console.WriteLine("We got a promotion");
                    break;

                default:
                    Console.WriteLine("This is a weird season");
                    break;


                   
            }

    */
        }
        /*
        public static void Increment(int number) // this number here is another spot in memory
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
        */
        
    }
}
