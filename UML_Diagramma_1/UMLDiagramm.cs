namespace StatePattern
{
    interface State
    {
        public void handleRequest(Context context);
    }

    class ConcreteState1 : State
    {
        public void handleRequest(Context context)
        {
            context.setState(new ConcreteState2());
        }
    }

    class ConcreteState2 : State
    {
        public void handleRequest(Context context)
        {
            context.setState(new ConcreteState1());
        }
    }

    class Context
    {
        State state;
        public Context(State state)
        {
            this.setState(new ConcreteState1());
        }

        public void setState(State _state)
        {
            this.state = _state;
        }

        public void request()
        {
            this.state.handleRequest(this);
        }
    }
}
