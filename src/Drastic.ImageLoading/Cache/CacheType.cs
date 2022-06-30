using System;

namespace Drastic.ImageLoading.Cache
{
    [Preserve(AllMembers = true)]
    public enum CacheType
    {
        Memory,
        Disk,
        All,
        None
    }
}

