using DataModel.Models;
using DataModel.Models.Matrices;
using DataModel.Factories.IFactories;
using System;

namespace DataModel.Factories.Default
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DefaultContainerFactory<T> : IContainerFactory<T> 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="types"></param>
        /// <param name="positionsCount"></param>
        /// <param name="pointsCount"></param>
        /// <returns></returns>
        public Container<T> Create(Type[] types, int positionsCount, params int[][] pointsCount)
        {
            DefaultMatrixFactory<T> factory = new DefaultMatrixFactory<T>();

            var matrices = new Matrix<T>[types.Length];
            Type t;

            for (int i = 0; i < types.Length; ++i)
            {
                t = types[i];
                if (t == typeof(MatrixX<>))
                {
                    matrices[i] = factory.CreateMatrixX(positionsCount, pointsCount[i]);
                }
                else
                if (t == typeof(MatrixXY<>))
                {
                    matrices[i] = factory.CreateMatrixXY(positionsCount, pointsCount[i]);
                }
                else
                if (t == typeof(MatrixXYZ<>))
                {
                    matrices[i] = factory.CreateMatrixXYZ(positionsCount, pointsCount[i]);
                }
            }

            return new Container<T>(matrices);
        }
    }
}
