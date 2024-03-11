namespace State_Mode;
public class Context
{
    State m_State = null;

    public void Request(int value)
    {
        m_State.Handler(value);
    }

    public void SetState(State theState)
    {
        Console.WriteLine($"Context.SetState {theState}");
        m_State = theState;
    }
}
