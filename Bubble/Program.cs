namespace Bubble;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] nums = {1, 4, 5, 6, 9, 2, 3};
        Bubble(nums);
        for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine(nums[i]);
        }
    }


    static void Bubble(int[] nums)
    {
        // 获得数组下标以及长度
        int length = nums.Length;
        int unsortEndIndex = length - 1;

        bool sorted = false;

        while (!sorted)
        {
            sorted = true;
            for (int i = 0; i < unsortEndIndex; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    sorted = false;
                    int temp = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = temp;
                }
            }
            unsortEndIndex--;
        }

    }
}
