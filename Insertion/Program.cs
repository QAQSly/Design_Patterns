namespace Insertion;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        int[] nums_ = {1, 3, 2, 5, 4};
        Insertion(nums_);
        for (int i = 0; i < nums_.Length; i++)
        {
            Console.WriteLine(nums_[i]);

        }
        string z = "Ｚ";
        int test = System.Text.Encoding.UTF8.GetByteCount(z);
        Console.WriteLine(test);
    }


    static void Insertion(int[] nums)
    {
        int length = nums.Length;

        for (int i = 1; i < length; i++)
        {
            int postion = i;

            int temp = nums[i];

            while (postion > 0 && nums[postion - 1] > temp)
            {
                nums[postion] = nums[postion -1];
                postion--;
            }
            nums[postion] = temp;
        }

    }
}
