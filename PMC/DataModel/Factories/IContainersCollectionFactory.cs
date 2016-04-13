using System;

namespace DataModel.Factories
{
    public interface IContainersCollectionFactory
    {
        void Create();
    }

    public class DefaultContainersCollectionFactory : IContainersCollectionFactory
    {
        public void Create()
        {
            throw new NotImplementedException();
        }
    }
}
