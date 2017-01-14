using System;


namespace RobotProblem
{
    class SortingChips : ISortingChips
    {
        public int[] SortVal(int[] arr, bool IsAsc)
        {

            if (IsAsc == true)
            {
                Array.Sort(arr);
            }
            else
            {
                Array.Reverse(arr);
            }

            return arr;
        }
    }
}

