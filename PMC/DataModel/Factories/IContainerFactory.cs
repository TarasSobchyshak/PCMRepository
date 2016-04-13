using DataModel.Interfaces;
using System.Collections.Generic;

namespace DataModel.Factories
{
    public interface IContainerFactory<T>
    {
        Container<T> Create();
    }

    public class DefaultContainerFactory<T> : IContainerFactory<T>
    {
        public Container<T> Create()
        {
            List<Matrix<IPoint<T>>> matrices = new List<Matrix<IPoint<T>>>() { };
            //to do
            return new Container<T>(matrices);
        }
    }
}
