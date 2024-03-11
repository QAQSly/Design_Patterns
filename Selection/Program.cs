namespace Selection;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        int[] nums_ = {2, 4, 1, 3, 5};
        Selection(nums_);
        for (int i = 0; i < nums_.Length; i++)
        {
            Console.WriteLine(nums_[i]);
        }
    }

    static void Selection(int[] nums)
    {
        int length = nums.Length;
        int lowestIndex = 0;

        for (int i = 0; i < length; i++)
        {
            lowestIndex = i;
            for (int j = i + 1; j < length; j++)
            {
                if (nums[lowestIndex] > nums[j])
                {
                    lowestIndex = j;
                }
            }

            if (lowestIndex != i)
            {
                int temp = nums[i];
                nums[i] = nums[lowestIndex];
                nums[lowestIndex] = temp;

            }

        }
    }
}
