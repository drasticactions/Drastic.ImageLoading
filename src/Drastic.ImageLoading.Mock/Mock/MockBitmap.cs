using System;

namespace Drastic.ImageLoading.Mock
{
    public class MockBitmap
    {
        public MockBitmap()
        {
        }

        public Guid Id { get; } = Guid.NewGuid();
    }
}
