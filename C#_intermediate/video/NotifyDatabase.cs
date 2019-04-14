using System;

namespace video
{
    public class NotifyDatabase : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Change the status of the video record in the database to “Processing”");
        }
    }
}