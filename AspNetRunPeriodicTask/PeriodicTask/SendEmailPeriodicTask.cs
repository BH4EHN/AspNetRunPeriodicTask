using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetRunPeriodicTask.PeriodicTask
{
    class SendEmailPeriodicTask : IPeriodicTask
    {
        public Int32 RunInterval { get; } = 45*1000;
        public void TaskStart()
        {
            // Send email with ads to registered users ...
            System.Diagnostics.Debug.WriteLine("Emails sent");
        }
    }
}
