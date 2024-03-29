﻿using System;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Drastic.ImageLoading.Work
{
    public interface IDataResolver
    {
        Task<DataResolverResult> Resolve(string identifier, TaskParameter parameters, CancellationToken token);
    }
}
