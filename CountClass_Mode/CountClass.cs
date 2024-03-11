namespace CountClass_Mode;
public class CountClass
{
    protected static int count = 0;
    protected bool enable = false;

    public CountClass()
    {
        count++;
        enable = (count == 1) ? true : false;

        if (!enable)
        {
            return;
            Console.WriteLine("超出一个" + count);
            // return;
        }
    }
    public void Op()
    {
        if (!enable)
        {
            return;
        }
        Console.WriteLine("sucess!");
    }
}
