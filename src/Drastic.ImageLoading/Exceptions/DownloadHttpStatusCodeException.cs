using System;
using System.Net;

namespace Drastic.ImageLoading.Exceptions
{
    [Preserve(AllMembers = true)]
    public class DownloadHttpStatusCodeException : Exception
    {
        public DownloadHttpStatusCodeException(HttpStatusCode httpStatusCode, string content = null) 
            : base(string.IsNullOrWhiteSpace(content) ? httpStatusCode.ToString() : $"{httpStatusCode} {content}")
        {
            HttpStatusCode = httpStatusCode;
        }

        public HttpStatusCode HttpStatusCode { get; }
    }
}
