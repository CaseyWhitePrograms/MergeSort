
using System.Collections.Generic;

namespace Merge_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var results = new Sorter().MergeSort(
                new List<int>()
                {
                     8,6,1,7,10,3,2,5,9,4
                }
                );
        }
    }
}
