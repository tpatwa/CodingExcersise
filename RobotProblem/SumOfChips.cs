using System.Linq;

namespace RobotProblem
{
    public class SumOfChips : ISumOfChips
    {
        public int SumVal(int[] arr)
        {
            return arr.Sum();
        }
    }
}
