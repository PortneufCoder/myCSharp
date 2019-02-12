using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    public class Lists
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
                Console.WriteLine(number); // 1,2,3,4,2,5,6,7
            }

            for (var i = 0; i < listItems.Count; i++)
            {
                if (listItems[i] == 1)
                {
                    listItems.Remove(listItems[i]); // remove all occurrences of 1 in the List
                }
            }

        }
    }
}
