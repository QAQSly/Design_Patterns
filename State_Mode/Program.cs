namespace State_Mode;

class Program
{
    static void Main(string[] args)
    {
        Context theContext = new Context();
        theContext.SetState(new StateEatImpl(theContext));
        theContext.Request(12);
        theContext.Request(22);
    }
}
