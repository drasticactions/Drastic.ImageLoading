using System;
namespace Drastic.ImageLoading.Exceptions
{
    [Preserve(AllMembers = true)]
    public class DownloadReadTimeoutException : Exception
    {
        public DownloadReadTimeoutException() : base("Read timeout")
        {
        }
    }
}
