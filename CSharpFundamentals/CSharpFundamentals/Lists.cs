using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class Lists
    {
        // Lists in C# are arrays with a dynamic length
        public void LearnList()
        {
            var listItems = new List<int>() { 1,2,3,4 };
            listItems.Add(2);
            Console.WriteLine(listItems);

            listItems.AddRange(new int[3] {5,6,7});

            foreach (var number in listItems)
            {
                Console.WriteLine(number);
            }


        }
    }
}
