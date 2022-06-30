﻿using System;
using AppKit;
using Drastic.ImageLoading.Work;

namespace Drastic.ImageLoading.Targets
{
    public class NSImageTarget : Target<NSImage, NSImage>
    {
        private WeakReference<NSImage> _imageWeakReference = null;

        public override void Set(IImageLoaderTask task, NSImage image, bool animated)
        {
            if (task == null || task.IsCancelled)
                return;

            if (_imageWeakReference == null)
                _imageWeakReference = new WeakReference<NSImage>(image);
            else
                _imageWeakReference.SetTarget(image);
        }

        public NSImage PImage
        {
            get
            {
                if (_imageWeakReference == null)
                    return null;

                NSImage image = null;
                _imageWeakReference.TryGetTarget(out image);
                return image;
            }
        }
    }
}
