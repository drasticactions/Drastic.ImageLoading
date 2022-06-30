using System.Threading.Tasks;
using System.Threading;
using Drastic.ImageLoading.Work;
using Drastic.ImageLoading.Config;

namespace Drastic.ImageLoading.Cache
{
    [Preserve(AllMembers = true)]
	public interface IDownloadCache
	{
        Task<CacheStream> DownloadAndCacheIfNeededAsync (string url, TaskParameter parameters, Configuration configuration, CancellationToken token);
	}
}

