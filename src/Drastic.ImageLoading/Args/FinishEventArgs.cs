using System;
using Drastic.ImageLoading.Work;

namespace Drastic.ImageLoading.Args
{
    [Preserve(AllMembers = true)]
    public class FinishEventArgs : EventArgs
    {
        public FinishEventArgs(IScheduledWork scheduledWork)
        {
            ScheduledWork = scheduledWork;
        }

        public IScheduledWork ScheduledWork { get; private set; }
    }
}
