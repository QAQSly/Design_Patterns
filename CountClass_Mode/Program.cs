namespace CountClass_Mode;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        CountClass a = new CountClass();
        a.Op();
        CountClass b = new CountClass();
        b.Op();
        a.Op();
        Test();
    }

    static void Test()
    {
        int age = 10;
        Func<int, string> ConsoleAge = i => $"age = {i}";

        Console.WriteLine(ConsoleAge(age));
    }
}
