using System;

namespace Drastic.ImageLoading
{
    public interface IAnimatedImage<TNativeImageContainer>
    {
        int Delay { get; set; }

        TNativeImageContainer Image { get; set; }
    }
}
