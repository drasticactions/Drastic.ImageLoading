using System;
using Drastic.ImageLoading.Work;

namespace Drastic.ImageLoading.Maui
{
    public static class CachedImageEvents
    {
        public class ErrorEventArgs : Drastic.ImageLoading.Args.ErrorEventArgs
        {
            public ErrorEventArgs(Exception exception) : base(exception) { }
        }

        public class SuccessEventArgs : Drastic.ImageLoading.Args.SuccessEventArgs
        {
            public SuccessEventArgs(ImageInformation imageInformation, LoadingResult loadingResult) : base(imageInformation, loadingResult) { }
        }

        public class FinishEventArgs : Drastic.ImageLoading.Args.FinishEventArgs
        {
            public FinishEventArgs(IScheduledWork scheduledWork) : base(scheduledWork) { }
        }

        public class DownloadStartedEventArgs : Drastic.ImageLoading.Args.DownloadStartedEventArgs
        {
            public DownloadStartedEventArgs(DownloadInformation downloadInformation) : base(downloadInformation) { }
        }

        public class DownloadProgressEventArgs : Drastic.ImageLoading.Args.DownloadProgressEventArgs
        {
            public DownloadProgressEventArgs(DownloadProgress downloadProgress) : base(downloadProgress) { }
        }

        public class FileWriteFinishedEventArgs : Drastic.ImageLoading.Args.FileWriteFinishedEventArgs
        {
            public FileWriteFinishedEventArgs(FileWriteInfo fileWriteInfo) : base(fileWriteInfo) { }
        }
    }
}

