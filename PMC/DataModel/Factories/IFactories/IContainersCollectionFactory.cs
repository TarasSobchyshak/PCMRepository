using DataModel.Models;
using System;

namespace DataModel.Factories.IFactories
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IContainersCollectionFactory<T> 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="containersCount"></param>
        /// <param name="types"></param>
        /// <param name="positionsCount"></param>
        /// <param name="pointsCount"></param>
        /// <returns></returns>
        ContainersCollection<T> Create(int containersCount, Type[] types, int positionsCount, params int[][] pointsCount);
    }
}
