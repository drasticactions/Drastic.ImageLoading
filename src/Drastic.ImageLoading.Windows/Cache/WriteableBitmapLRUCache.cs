using Drastic.ImageLoading.Work;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if WINDOWS10_0_19041_0_OR_GREATER
using Microsoft.UI.Xaml.Media.Imaging;
#else
using Windows.UI.Xaml.Media.Imaging;
#endif

namespace Drastic.ImageLoading.Cache
{
    public class WriteableBitmapLRUCache : LRUCache<string, Tuple<BitmapSource, ImageInformation>>
    {
        public WriteableBitmapLRUCache(int capacity) : base(capacity)
        {
        }

        public override int GetValueSize(Tuple<BitmapSource, ImageInformation> value)
        {
            if (value?.Item2 == null)
                return 0;

            return value.Item2.CurrentHeight * value.Item2.CurrentWidth * 4;
        }
    }
}
