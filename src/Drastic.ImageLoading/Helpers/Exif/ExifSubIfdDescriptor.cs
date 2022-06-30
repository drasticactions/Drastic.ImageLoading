using System;
using System.Collections.Generic;

namespace Drastic.ImageLoading.Helpers.Exif
{
    internal class ExifSubIfdDescriptor : ExifDescriptorBase<ExifSubIfdDirectory>
    {
        public ExifSubIfdDescriptor(ExifSubIfdDirectory directory) : base(directory)
        {
        }
    }
}
