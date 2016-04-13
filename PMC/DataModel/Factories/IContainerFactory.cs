using System;

namespace DataModel.Factories
{
    public interface IContainerFactory<T>
    {
        Container<T> Create();
    }

    public class DefaultContainerFactory<T> : IContainerFactory<T>
    {

    }
}
