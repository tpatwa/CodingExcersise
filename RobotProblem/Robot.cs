using System;

namespace RobotProblem
{
    public class Robot
    {

        SortingChips sortingChips;
        SumOfChips sumOfChips;
        public int TotalNoOfoOfChipsInstalled = 0;


        //Set chips to Robot
        public void SetChip<T>(T objCommon)
        {
            if (objCommon.GetType().Equals(typeof(SortingChips)))
            {
                if (sortingChips == null)  
                {
                    sortingChips = new SortingChips();
                    TotalNoOfoOfChipsInstalled = TotalNoOfoOfChipsInstalled + 1;
                }

            }
            else
            {
                if (sumOfChips == null)
                {
                    sumOfChips = new SumOfChips();
                    TotalNoOfoOfChipsInstalled = TotalNoOfoOfChipsInstalled + 1;
                }

            }

        }

        //Method to get the result of attached chip
        public T ExecuteOperations<T, T2>(int[] arvVal, bool IsAsc, T2 obj)
        {
            if (obj.GetType().Equals(sortingChips.GetType()) == true)
            {
                return (T)Convert.ChangeType(sortingChips.SortVal(arvVal, IsAsc), typeof(T));
            }
            else
            {
                return (T)Convert.ChangeType(sumOfChips.SumVal(arvVal), typeof(T));
            }

        }

    }
}
