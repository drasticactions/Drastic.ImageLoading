using System;
using Drastic.ImageLoading.Config;

namespace Drastic.ImageLoading.Work
{
    public interface IDataResolverFactory
    {
        IDataResolver GetResolver(string identifier, ImageSource source, TaskParameter parameters, Configuration configuration);
    }
}
