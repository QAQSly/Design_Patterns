namespace State_Mode;
public class StateSleepImpl : State
{
    public StateSleepImpl(Context theContext) : base(theContext)
    {
    }

    public override void Handler(int value)
    {
        Console.WriteLine("StateSleepImpl.Handler");
        if (value > 20)
        {
            m_Context.SetState(new StateEatImpl(m_Context));
        }
    }
}
    
