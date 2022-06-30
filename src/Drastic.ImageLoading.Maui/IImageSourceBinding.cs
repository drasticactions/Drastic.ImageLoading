using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Drastic.ImageLoading.Work;
using ImageSource = Drastic.ImageLoading.Work.ImageSource;

namespace Drastic.ImageLoading.Maui
{
    [Preserve(AllMembers = true)]
    public interface IImageSourceBinding
    {
        ImageSource ImageSource { get; }

        string Path { get; }

        Func<CancellationToken, Task<Stream>> Stream { get; }
    }
}
