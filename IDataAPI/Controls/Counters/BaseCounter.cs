using IDataAPI.Interfaces.Counters;

namespace IDataAPI.Controls.Counters
{
    public class BaseCounter : ICounter
    {
        protected int count;

        public void Add()
        {
            count++;
        }

        public int GetCount()
        {
            return count;
        }
    }
}
