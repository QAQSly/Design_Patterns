namespace Singleton_Mode;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Singleton.Instance.Name = "Nihao";
        Singleton.Instance.Name = "hh";
        Console.WriteLine(Singleton.Instance.Name);
    }
}
