namespace OOP.Classes
{
    public class FindMaxAndMinNums
    {
        public FindMaxAndMinNums()
        {
            // Console.WriteLine();
        }

        public void FindLargestElement()
        {
            int[] nums = {5, 8, 12, 21, 3, 25, 9, 16, 100, 4};

            int largestElement = nums.Max();
            Console.WriteLine("The maximum element in the array is " + largestElement);

            int minimumElement = nums.Min();
            Console.WriteLine("The minimum element in tha array is " + minimumElement);
        }
    }
}