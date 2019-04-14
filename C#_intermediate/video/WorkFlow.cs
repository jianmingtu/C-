using System.Collections.Generic;

namespace video
{
    public class WorkFlow : IWorkFlow
    {
        private readonly List<IActivity> _workFlow;
        public WorkFlow()
        {
            _workFlow = new List<IActivity>();
            
        }

        public void AddActivity(IActivity activity)
        {
            _workFlow.Add(activity);
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _workFlow;
        }

    }
}
