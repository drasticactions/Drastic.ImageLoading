using System;
using System.Diagnostics;

namespace Drastic.ImageLoading.Helpers
{
    [Preserve(AllMembers = true)]
    public interface IMiniLogger
    {
        void Debug(string message);

		void Error(string errorMessage);

        void Error(string errorMessage, Exception ex);
    }
}

