using System;
using System.Threading;

namespace Drastic.ImageLoading.Helpers
{
	internal static class StaticLocks
	{
		public static SemaphoreSlim DecodingLock { get; set; }
	}
}
