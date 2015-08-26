using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetRunPeriodicTask.PeriodicTask
{
    class CheckDatabasePeriodicTask : IPeriodicTask
    {
        public Int32 RunInterval { get; } = 60*1000;
        public void TaskStart()
        {
            // Transfer data between databases
            System.Diagnostics.Debug.WriteLine("database checked");
        }
    }
}
