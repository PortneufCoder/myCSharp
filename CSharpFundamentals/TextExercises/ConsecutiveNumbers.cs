using System;
using System.Collections.Generic;


namespace TextExercises
{
public class ConsecutiveNumbers
{

public void NumberSolution()
{
    Console.WriteLine("Please enter some numbers:");
    var input = Console.ReadLine();
    var listOfNumbers = new List<int>();

    foreach (var number in input.Split('-'))
    {
        listOfNumbers.Add(Convert.ToInt32(number));

       listOfNumbers.Sort();

       var isConsecutive = true;

       for (var i = 1; i < listOfNumbers.Count; i++)
       {
           if (listOfNumbers[i] != listOfNumbers[i - 1] + 1)
           {
               isConsecutive = false;
               break;
           }
       }

       var output = isConsecutive ? "Consecutive" : "Not Consecutive";
       Console.WriteLine(output);
    }
}
}
}
