using System;
using System.Collections.Generic;

namespace Drastic.ImageLoading.Exceptions
{
    [Preserve(AllMembers = true)]
    public class DownloadAggregateException : AggregateException
    {
        public DownloadAggregateException()
        {
        }

        public DownloadAggregateException(IEnumerable<Exception> exceptions) : base(exceptions)
        {
        }
    }
}
