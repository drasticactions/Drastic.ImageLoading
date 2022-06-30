using System;

namespace Drastic.ImageLoading.Cache
{
    [Preserve(AllMembers = true)]
	public enum CacheResult
	{
		Found,
		NotFound,
		ErrorOccured
	}
}

