using System;
using Drastic.ImageLoading.Helpers;

namespace Drastic.ImageLoading.Mock
{
    public class MockLogger : IMiniLogger
    {
        public void Debug(string message)
        {
        }

        public void Error(string errorMessage)
        {
        }

        public void Error(string errorMessage, Exception ex)
        {
        }
    }
}
