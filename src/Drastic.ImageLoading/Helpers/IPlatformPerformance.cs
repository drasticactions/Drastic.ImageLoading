using System;
namespace Drastic.ImageLoading
{
    [Preserve(AllMembers = true)]
    public interface IPlatformPerformance
    {
        int GetCurrentManagedThreadId();

        int GetCurrentSystemThreadId();

        string GetMemoryInfo();
    }
}

