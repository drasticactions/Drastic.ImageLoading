﻿using System;
using System.Threading;
using System.Threading.Tasks;
using Drastic.ImageLoading.Config;

namespace Drastic.ImageLoading.Work
{
    [Preserve(AllMembers = true)]
    public interface IImageLoaderTask : IScheduledWork, IDisposable
    {
        Task Init();

        TaskParameter Parameters { get; }

        bool CanUseMemoryCache { get; }

        string Key { get; }

        string KeyRaw { get; }

        Task<bool> TryLoadFromMemoryCacheAsync();

        Task RunAsync();

        ITarget Target { get; }

        Configuration Configuration { get; }

        ImageInformation ImageInformation { get; }

        DownloadInformation DownloadInformation { get; }
    }
}

