namespace Singleton_Mode;
public class Singleton
{
    public string Name {get; set;}

    public static Singleton instance;

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }

    private Singleton() {}
}
