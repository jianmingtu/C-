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
            var workFlowEngine = new WorkFlowEngine();
            workFlowEngine.AddActivity(new UploadVedioToCloud());
            workFlowEngine.AddActivity(new NotifyDatabase());
            workFlowEngine.AddActivity(new SendEmail());
            workFlowEngine.AddActivity(new NotifyDatabase());
            workFlowEngine.Run();
        }
    }
}
