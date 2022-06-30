using System;
using Drastic.ImageLoading.Work;
#if WINDOWS10_0_19041_0_OR_GREATER
using Microsoft.UI.Xaml.Media.Imaging;
#else
using Windows.UI.Xaml.Media.Imaging;
#endif

namespace Drastic.ImageLoading.Targets
{
    public class BitmapTarget: Target<BitmapSource, WriteableBitmap>
    {
        private WeakReference<BitmapSource> _imageWeakReference = null;

        public override void Set(IImageLoaderTask task, BitmapSource image, bool animated)
        {
            if (task == null || task.IsCancelled)
                return;

            if (_imageWeakReference == null)
                _imageWeakReference = new WeakReference<BitmapSource>(image);
            else
                _imageWeakReference.SetTarget(image);
        }

        public BitmapSource BitmapSource
        {
            get
            {
                if (_imageWeakReference == null)
                    return null;

                BitmapSource image = null;
                _imageWeakReference.TryGetTarget(out image);
                return image;
            }
        }
    }
}
