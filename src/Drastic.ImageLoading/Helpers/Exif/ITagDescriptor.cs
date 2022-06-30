using System;

namespace Drastic.ImageLoading.Helpers.Exif
{
    internal interface ITagDescriptor
    {
        string GetDescription(int tagType);
    }
}
