using System.Collections.Generic;

namespace video
{
    public class WorkFlowEngine
    {
        private readonly List<IActivity> _workFlow;
        public WorkFlowEngine()
        {
            _workFlow = new List<IActivity>();
            
        }

        public void AddActivity(IActivity activity)
        {
            _workFlow.Add(activity);
        }

        public void Run()
        {
            foreach (var activity in _workFlow)
            {
                activity.Execute();
            }
        }
    }
}
