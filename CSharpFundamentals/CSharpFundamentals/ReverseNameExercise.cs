using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class ReverseNameExercise
    {
        public void ReverseName()
        {
            Console.WriteLine("Please enter your name: ");
            var userName = Console.ReadLine();
            char[] arr = userName.ToCharArray();

            Array.Reverse(arr);
            Console.WriteLine(arr);



        }
    }
}
