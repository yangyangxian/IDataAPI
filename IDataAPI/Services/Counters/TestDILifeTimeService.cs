using IDataAPI.Controls.Counters;
using IDataAPI.Interfaces.Counters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IDataAPI.Services.Counters
{
    public class TestDILifeTimeService
    {
        private IScopedCounter scopedCounter;
        private ITransientCounter transientCounter;
        private ISingletonCounter singletonCounter;

        public IScopedCounter ScopedCounter
        {
            set { this.scopedCounter = value; }
            get { return this.scopedCounter; }
        }
        public ITransientCounter TransientCounter
        {
            set { this.transientCounter = value; }
            get { return this.transientCounter; }
        }
        public ISingletonCounter SingletonCounter
        {
            set { this.singletonCounter = value; }
            get { return this.singletonCounter; }
        }

        public TestDILifeTimeService(IScopedCounter scopedCounter,
            ITransientCounter transientCounter,
            ISingletonCounter singletonCounter)
        {
            this.ScopedCounter = scopedCounter;
            this.TransientCounter = transientCounter;
            this.SingletonCounter = singletonCounter;
        } 

        public void AddCounts()
        {
            this.ScopedCounter.Add();
            this.TransientCounter.Add();
            this.SingletonCounter.Add();
        }

        public IList<string> ReturnCounts()
        {
            return new List<string> { "ScopedCounter:" + this.ScopedCounter.GetCount(),
                "TransientCounter:" + this.TransientCounter.GetCount(),
                "SingleCounter:" + this.SingletonCounter.GetCount() };
        }
    }
}
