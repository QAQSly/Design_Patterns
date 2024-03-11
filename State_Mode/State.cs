namespace State_Mode;
public abstract class State
{
    public Context m_Context = null;

    public State(Context theContext)
    {
        m_Context = theContext;
    }

    public abstract void Handler(int value);
}
