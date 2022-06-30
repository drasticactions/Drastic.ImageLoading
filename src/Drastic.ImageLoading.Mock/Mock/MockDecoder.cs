using System;
using System.IO;
using System.Threading.Tasks;
using Drastic.ImageLoading.Mock;
using Drastic.ImageLoading.Work;

namespace Drastic.ImageLoading.Decoders
{
    public class MockDecoder : IDecoder<MockBitmap>
    {
        public Task<IDecodedImage<MockBitmap>> DecodeAsync(Stream stream, string path, ImageSource source, ImageInformation imageInformation, TaskParameter parameters)
        {
            var result = new DecodedImage<MockBitmap>()
            {
                Image = new MockBitmap(),
            };

            return Task.FromResult<IDecodedImage<MockBitmap>>(result);
        }
    }
}
