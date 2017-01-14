using System;

namespace RobotProblem
{
    class Program
    {

        //Assumption:
        //Class 'SortingChip' equal to Chip1
        //Class 'SumOfChips' equal to Chip2-it actaully sums up all the elements in the array
        //Class 'Robot' is Robot.Only one instance of Robot as Robots are expensive
        //Here Chip1('SortingChip') or Chip2('SumOfChips') can be attached.
        //Using 'SetChip()' method Chip1 or Chip2('ChipOfSorts'/'TotalChips') is assigned to Robot(Robot class)
        //Using 'ExecuteOperation()' method Chip1 or Chip2 functionalities are executed.
        //robot.TotalNoOfoOfChipsInstalled = Total number of different unique chips installed through robot's life.
        static void Main(string[] args)
        {


            Console.WriteLine("Robot will perform operations on Array [1,2,3,4]");

            int[] aryVal = { 1, 2, 3 ,4};
            ISortingChips sortingChips = new SortingChips();
            ISumOfChips sumOfChips = new SumOfChips();

            //Only one instace of Robot as it is expensive
            Robot robot = new Robot();  

            //Attaching chip1 for sorting an array
            robot.SetChip<ISortingChips>(sortingChips);

            //Executing Chip1 sorting method
            int[] resObjRobot = robot.ExecuteOperations<int[], ISortingChips>(aryVal, true, sortingChips);
            Console.WriteLine("Sorting an array");
            for (int i = 0; i < resObjRobot.Length; i++)
            {
                Console.WriteLine(resObjRobot[i]);
            }
            Console.WriteLine("*******************");

            // Attaching chip2(TotalChips)
            robot.SetChip<ISumOfChips>(sumOfChips);


            //Executing Chip2(TotalChips) method
            int resObjRobot1 = robot.ExecuteOperations<int, ISumOfChips>(aryVal, false, sumOfChips);
            Console.WriteLine("Sum of total chips-> " + resObjRobot1);
            Console.WriteLine("*******************");
            Console.WriteLine("*******************");

            //Again Attaching chip1 for sorting an array
            robot.SetChip<ISortingChips>(sortingChips);

            //Executing Chip1(Sorts) method
            resObjRobot = robot.ExecuteOperations<int[], ISortingChips>(aryVal, false, sortingChips);

            Console.WriteLine("Sorting the same array again");
            for (int i = 0; i < resObjRobot.Length; i++)
            {
                Console.WriteLine(resObjRobot[i]);
            }

            robot.SetChip<ISumOfChips>(sumOfChips);

            //Executing Chip2(TotalChips) method
            int resObjRobot2 = robot.ExecuteOperations<int, ISumOfChips>(aryVal, false, sumOfChips);
            Console.WriteLine("Sum of total chips after sorting second time-> " + resObjRobot2);

            Console.WriteLine("*******************");
            Console.WriteLine("*******************");

            //Unique functions called count
            Console.WriteLine("No of method calls");
            Console.WriteLine(robot.TotalNoOfoOfChipsInstalled);

            Console.ReadKey();

        }
    }
}
