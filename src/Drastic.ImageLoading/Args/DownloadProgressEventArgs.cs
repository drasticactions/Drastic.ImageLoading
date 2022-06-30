using System;

namespace Drastic.ImageLoading.Args
{
    [Preserve(AllMembers = true)]
    public class DownloadProgressEventArgs : EventArgs
    {
        public DownloadProgressEventArgs(DownloadProgress downloadProgress)
        {
            DownloadProgress = downloadProgress;
        }

        public DownloadProgress DownloadProgress { get; private set; }
    }
}
