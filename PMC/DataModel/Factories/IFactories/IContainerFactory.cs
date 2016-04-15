using DataModel.Models;
using System;

namespace DataModel.Factories.IFactories
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IContainerFactory<T> 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="types"></param>
        /// <param name="positionsCount"></param>
        /// <param name="pointsCount"></param>
        /// <returns></returns>
        Container<T> Create(Type[] types, int positionsCount, params int[][] pointsCount);
    }
}
