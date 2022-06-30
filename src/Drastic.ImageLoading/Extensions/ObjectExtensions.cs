﻿using System;

namespace Drastic.ImageLoading
{
    public static class ObjectExtensions
    {
        public static bool TryDispose(this IDisposable obj)
        {
            try
            {
                if (obj != null)
                {
                    obj?.Dispose();
                    return true;
                }
            }
            catch (ObjectDisposedException)
            {
            }

            return false;
        }
    }
}
