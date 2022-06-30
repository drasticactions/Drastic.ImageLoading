using System;
using Drastic.ImageLoading.Work;

namespace Drastic.ImageLoading.Transformations
{
    [Preserve(AllMembers = true)]
	public class ColorSpaceTransformation: ITransformation
	{
		public ColorSpaceTransformation()
		{
			Helpers.ThrowOrDefault();
		}

		public ColorSpaceTransformation(float[][] rgbawMatrix)
		{
			Helpers.ThrowOrDefault();
		}

        public IBitmap Transform(IBitmap sourceBitmap, string path, ImageSource source, bool isPlaceholder, string key)
		{
			return Helpers.ThrowOrDefault<IBitmap>();
		}

		public float[][] RGBAWMatrix { get; set; }

		public string Key => Helpers.ThrowOrDefault<string>();
	}
}

