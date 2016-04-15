using DataModel.Factories.IFactories;
using DataModel.Models;
using System;

namespace DataModel.Factories.Default
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DefaultContainersCollectionFactory<T> : IContainersCollectionFactory<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="containersCount"></param>
        /// <param name="types"></param>
        /// <param name="positionsCount"></param>
        /// <param name="pointsCount"></param>
        /// <returns></returns>
        public ContainersCollection<T> Create(int containersCount, 
                                              Type[] types, 
                                              int positionsCount, 
                                              params int[][] pointsCount)
        {
            var containers = new Container<T>[containersCount];         
            var factory = new DefaultContainerFactory<T>();

            for (int i = 0; i < containers.Length; ++i)
            {
                containers[i] = factory.Create(types, positionsCount, pointsCount);
            }

            return new ContainersCollection<T>(containers);
        }
    }
}
