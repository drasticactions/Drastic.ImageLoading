using System;
namespace Drastic.ImageLoading.Exceptions
{
    [Preserve(AllMembers = true)]
    public class DownloadException : Exception
    { 
        public DownloadException(string message) : base(message)
        {
        }
    }
}
