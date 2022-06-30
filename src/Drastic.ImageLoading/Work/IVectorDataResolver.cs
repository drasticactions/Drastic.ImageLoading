﻿using System;
using System.Collections.Generic;

namespace Drastic.ImageLoading.Work
{
    public interface IVectorDataResolver : IDataResolver
    {
        int VectorWidth { get; }

        int VectorHeight { get; }

        bool UseDipUnits { get; }

        Dictionary<string, string> ReplaceStringMap { get; set; }
    }
}
