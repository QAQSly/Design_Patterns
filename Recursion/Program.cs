namespace Recursion;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        CountDown(10);
    }

    static void CountDown(int num)
    {
        if (num == 0)
        {
            return;
        }
        Console.WriteLine(num);
        CountDown(num - 1);
    }
}
