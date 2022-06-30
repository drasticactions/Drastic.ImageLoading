using System;
using Microsoft.Maui.Controls;

namespace Drastic.ImageLoading.Maui
{
    [Preserve(AllMembers = true)]
	public interface ICacheKeyFactory
	{
		string GetKey(ImageSource imageSource, object bindingContext);
	}
}

