namespace IDataAPI.Interfaces.Counters
{
    public interface ICounter
    {
        void Add();
        int GetCount();
    }

    public interface IScopedCounter : ICounter
    {
    }
    public interface ITransientCounter : ICounter
    {
    }
    public interface ISingletonCounter : ICounter
    {
    }
}
