using System;
using SkiaSharp;

namespace Drastic.ImageLoading.Svg.Platform
{
    internal interface ISKSvgFill
    {
        void ApplyFill(SKPaint fill, SKRect bounds);
    }
}
