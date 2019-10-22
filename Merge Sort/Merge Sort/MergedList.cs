
using System.Collections.Generic;

namespace Merge_Sort
{
    class MergedList
    {
    
        public List<int> List { get; set; }
        public List<int> Left { get; set; }
        public List<int> Right { get; set; }
        public int LeftIndex { get; set; }
        public int RightIndex { get; set; }

        public MergedList()
            {
            List = new List<int>();
            Left = new List<int>();
            Right = new List<int>();
        }
        public int TotalLength()
        {
            return Left.Count + Right.Count;
        }

        public void AddCurrentRight(int i)
        {
            try
            {
                this.List.Add(CurrentRightValue());
                this.RightIndex++;
            }
            catch
            {
                AddCurrentLeft();
            }
        }
        public void AddCurrentLeft(int i)
        {
            try
            {
                this.List.Add(CurrentLeftValue());
                this.LeftIndex++;
            }
            catch
            {
                AddCurrentRight();
            }


        }
        public int CurrentLeftValue()
        {
            return this.Left[this.LeftIndex];
        }
        public int CurrentRightValue()
        {
            return this.Right[this.RightIndex];
        }
        public bool CurrentLeftSmaller()
        {
            return CurrentRightValue() <= CurrentLeftValue();
        }
        public bool CurrentRightSmaller()
        {
            return CurrentLeftValue() <= CurrentRightValue();
        }
    }

}
