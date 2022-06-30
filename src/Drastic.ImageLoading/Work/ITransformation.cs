using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drastic.ImageLoading.Work
{
    public interface ITransformation
    {
        string Key { get; }

        IBitmap Transform(IBitmap sourceBitmap, string path, ImageSource source, bool isPlaceholder, string key);
    }
}
