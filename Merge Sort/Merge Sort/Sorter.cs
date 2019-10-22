
using System.Collections.Generic;


namespace Merge_Sort
{
    class Sorter
    {
        public List<int> MergeSort(List<int> list)
        {
            //Base Case
            if (list.Count <= 1)
            {
                return list;
            }
            int leftSize = list.Count / 2;  //Left half
            int rightSize = list.Count / 2; //Right half
            if (list.Count % 2 != 0) rightSize++;   //If its odd
            
            
            List<int> left = list.GetRange(0,leftSize); 
            List<int> right = list.GetRange(leftSize, rightSize); 

            left = MergeSort(left);//sorting left side
            right = MergeSort(right);//sorting right side

            return Merge(left, right);
        }

        private List<int> Merge(List<int> left, List<int> right)
        {
            MergedList mergedList = new MergedList(left, right);

            for (int i = 0; i < mergedList.TotalLength(); i++)
            {

                if (mergedList.CurrentLeftSmaller())
                {
                    mergedList.AddCurrentLeft();
                   
                }
                else if (mergedList.CurrentRightSmaller())
                {
                    mergedList.AddCurrentRight();
                    
                }
            }
            return mergedList.List;
        }
    }
}
