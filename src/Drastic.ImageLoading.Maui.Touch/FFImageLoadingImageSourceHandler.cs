using System;
using System.Threading;
using System.Threading.Tasks;
using Drastic.ImageLoading.Maui.Handlers;
using Drastic.ImageLoading.Work;
using Microsoft.Maui.Controls.Compatibility.Platform.iOS;

#if __IOS__
using PImage = UIKit.UIImage;
using PImageTarget = Drastic.ImageLoading.Targets.UIImageTarget;
#elif __MACOS__
using PImage = AppKit.NSImage;
using PImageTarget = Drastic.ImageLoading.Targets.NSImageTarget;
using Microsoft.Maui.Controls.Platform.MacOS;
#endif

namespace Drastic.ImageLoading.Maui.Platform
{
	public class FFLoadingImageSourceHandler : HandlerBase<object>, IImageSourceHandler
	{
		public async Task<PImage> LoadImageAsync(Microsoft.Maui.Controls.ImageSource imageSource, CancellationToken cancellationToken = default, float scale = 1)
		{
			try
			{
				var source = ImageSourceBinding.GetImageSourceBinding(imageSource, null);
				if (source == null)
				{
					return null;
				}

				var result = await LoadImageAsync(source, imageSource, null, cancellationToken).ConfigureAwait(false);
				var target = result?.Target as PImageTarget;
				return target?.PImage;
			}
			catch (Exception)
			{
				return null;
			}
		}

		protected override IImageLoaderTask GetImageLoaderTask(TaskParameter parameters, object imageView)
		{
			var target = new PImageTarget();
			var task = ImageService.CreateTask(parameters, target);
			ImageService.Instance.LoadImage(task);
			return task;
		}
	}
}
