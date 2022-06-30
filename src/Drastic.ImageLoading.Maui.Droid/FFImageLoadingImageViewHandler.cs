using System;
using System.Threading;
using System.Threading.Tasks;
using Drastic.ImageLoading.Work;
using Android.Widget;
using Drastic.ImageLoading.Maui.Handlers;
using Microsoft.Maui.Controls.Platform.Android;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;

//[assembly: Microsoft.Maui.Controls.ExportImageSourceHandler(typeof(Microsoft.Maui.Controls.FileImageSource), typeof(Drastic.ImageLoading.Maui.Platform.Drastic.ImageLoadingImageViewHandler))]
//[assembly: Microsoft.Maui.Controls.ExportImageSourceHandler(typeof(Microsoft.Maui.Controls.StreamImageSource), typeof(Drastic.ImageLoading.Maui.Platform.Drastic.ImageLoadingImageViewHandler))]
//[assembly: Microsoft.Maui.Controls.ExportImageSourceHandler(typeof(Microsoft.Maui.Controls.UriImageSource), typeof(Drastic.ImageLoading.Maui.Platform.Drastic.ImageLoadingImageViewHandler))]
//[assembly: Microsoft.Maui.Controls.ExportImageSourceHandler(typeof(Drastic.ImageLoading.Maui.EmbeddedResourceImageSource), typeof(Drastic.ImageLoading.Maui.Platform.Drastic.ImageLoadingImageViewHandler))]
//[assembly: Microsoft.Maui.Controls.ExportImageSourceHandler(typeof(Drastic.ImageLoading.Maui.DataUrlImageSource), typeof(Drastic.ImageLoading.Maui.Platform.Drastic.ImageLoadingImageViewHandler))]

namespace Drastic.ImageLoading.Maui.Platform
{
	[Preserve(AllMembers = true)]
	public class FFImageLoadingImageViewHandler : HandlerBase<ImageView>, IImageViewHandler
	{
		public Task LoadImageAsync(Microsoft.Maui.Controls.ImageSource imageSource, ImageView imageView, CancellationToken cancellationToken = default)
		{
			try
			{
				if (!IsValid(imageView))
					return Task.CompletedTask;

				var source = ImageSourceBinding.GetImageSourceBinding(imageSource, null);
				if (source == null)
				{
					imageView.SetImageResource(Android.Resource.Color.Transparent);
					return Task.CompletedTask;
				}

				return LoadImageAsync(source, imageSource, imageView, cancellationToken);
			}
			catch (Exception)
			{
				return Task.CompletedTask;
			}
		}

		private static bool IsValid(ImageView imageView)
		{
			if (imageView == null || imageView.Handle == IntPtr.Zero)
				return false;
				
#pragma warning disable CS0618 // Type or member is obsolete
			var activity = imageView.Context as Android.App.Activity;
#pragma warning restore CS0618 // Type or member is obsolete
			if (activity != null)
			{
				if (activity.IsFinishing)
					return false;
				if (activity.IsDestroyed)
					return false;
			}
			else
			{
				return false;
			}

			return true;
		}

		protected override IImageLoaderTask GetImageLoaderTask(TaskParameter parameters, ImageView imageView)
		{
			return parameters.Into(imageView) as IImageLoaderTask;
		}
	}
}
