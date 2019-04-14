using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video
{

    class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new WorkFlow();
            workFlow.AddActivity(new UploadVedioToCloud());
            workFlow.AddActivity(new NotifyDatabase());
            workFlow.AddActivity(new SendEmail());
            workFlow.AddActivity(new NotifyDatabase());

            var workFlowEngine = new WorkFlowEngine();
            workFlowEngine.Run(workFlow);
        }
    }
}
