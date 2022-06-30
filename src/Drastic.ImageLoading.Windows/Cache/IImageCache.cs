#if WINDOWS10_0_19041_0_OR_GREATER
	using Microsoft.UI.Xaml.Media.Imaging;
#else
	using Windows.UI.Xaml.Media.Imaging;
#endif


namespace Drastic.ImageLoading.Cache
{
    interface IImageCache : IMemoryCache<BitmapSource>
    {
    }
}
