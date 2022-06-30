using System;
using System.Collections.Generic;
using Drastic.ImageLoading.Work;

namespace Drastic.ImageLoading.Maui
{
    [Preserve(AllMembers = true)]
	public interface IVectorImageSource
	{
		IVectorDataResolver GetVectorDataResolver();

		Microsoft.Maui.Controls.ImageSource ImageSource { get; }

		int VectorWidth { get; set; }

		int VectorHeight { get; set; }

		bool UseDipUnits { get; set; }

        Dictionary<string, string> ReplaceStringMap { get; set; }

		IVectorImageSource Clone();
	}
}
