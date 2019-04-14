using System.Collections.Generic;

namespace video
{
    public interface IWorkFlow
    {
        void AddActivity(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }
}
