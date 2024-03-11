namespace State_Mode;
public class StateEatImpl : State
{
    public StateEatImpl(Context theContext) : base(theContext)
    {

    }

    public override void Handler(int value)
    {
        Console.WriteLine("StateEatImpl.Handler");
        if (value > 10)  
        {
            m_Context.SetState(new StateSleepImpl(m_Context));
        }

    }
}
