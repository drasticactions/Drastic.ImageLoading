using System;
using Android.Graphics;

namespace Drastic.ImageLoading.Drawables
{
	public interface ISelfDisposingAnimatedBitmapDrawable : ISelfDisposingBitmapDrawable
	{
		IAnimatedImage<Bitmap>[] AnimatedImages { get; }
	}
}
