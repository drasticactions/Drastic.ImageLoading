using System;

namespace Drastic.ImageLoading.Exceptions
{
    [Preserve(AllMembers = true)]
    public class DownloadHeadersTimeoutException : Exception
    {
        public DownloadHeadersTimeoutException() : base("Headers timeout")
        {
        }
    }
}
