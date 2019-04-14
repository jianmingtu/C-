namespace video
{

    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach (var activity in workFlow.GetActivities())
            {
                activity.Execute();
            }
        }
    }
}
