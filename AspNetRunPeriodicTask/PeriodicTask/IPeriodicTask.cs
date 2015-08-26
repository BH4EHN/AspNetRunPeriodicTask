using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetRunPeriodicTask.PeriodicTask
{
    interface IPeriodicTask
    {
        /// <summary>
        /// Task running interval, indicats how long between two execution of current task
        /// </summary>
        Int32 RunInterval { get; }

        /// <summary>
        /// Task body, code here
        /// </summary>
        void TaskStart();
    }
}
