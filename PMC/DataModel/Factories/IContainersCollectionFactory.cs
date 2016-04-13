using System.Collections.Generic;

namespace DataModel.Factories
{
    public interface IContainersCollectionFactory<T>
    {
        ContainersCollection<T> Create();
    }

    public class DefaultContainersCollectionFactory<T> : IContainersCollectionFactory<T>
    {
        public ContainersCollection<T> Create()
        {
            List<Container<T>> containers = new List<Container<T>>();
            //to do
            return new ContainersCollection<T>(containers);
        }
    }
}
