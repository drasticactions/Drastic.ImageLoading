using System;

namespace Drastic.ImageLoading.Work
{
    public interface IScheduledWork
    {
        void Cancel();

        bool IsCancelled { get; }

        bool IsCompleted { get; }
    }
}

