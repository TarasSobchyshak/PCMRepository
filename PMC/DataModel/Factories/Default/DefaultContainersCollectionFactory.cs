using DataModel.Factories.IFactories;
using DataModel.Models;
using DataModel.Models.Matrices;
using DataModel.Models.Positions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataModel.Factories.Default
{
    public class DefaultContainersCollectionFactory<T>// : IContainersCollectionFactory<T>
        where T : struct
    {
        public ContainersCollection<T> CreateWithEmptyContainers(int containersCount)
        {
            return new ContainersCollection<T>(new Container<T>[containersCount]);
        }

        public ContainersCollection<T> CreateWithEmptyMatrices(int containersCount, int matricesCount)
        {
            Container<T>[] containers = new Container<T>[containersCount];
            for (int i = 0; i < containers.Length; ++i)
            {
                containers[i] = new Container<T>(new Matrix<T>[matricesCount]);
            }
            return new ContainersCollection<T>(containers);
        }

        public ContainersCollection<T> CreateWithPositions(Position<T>[] positions)
        {
            var matrixX = new List<PositionX<T>>();
            var matrixXY = new List<PositionXY<T>>();
            var matrixXYZ = new List<PositionXYZ<T>>();
            Type type;
            foreach (Position<T> p in positions)
            {
                type = p.GetType();
                if (!type.IsGenericType) continue;
                if (type.GetGenericTypeDefinition() == typeof(PositionX<>))
                {
                    type = type.GetGenericArguments().Single();
       //             matrixX.Add(p as PositionX<>);
                }
                if (type.GetGenericTypeDefinition() == typeof(PositionXY<>))
                {
                    matrixXY.Add(p as PositionXY<T>);
                }
                if (type.GetGenericTypeDefinition() == typeof(PositionXYZ<>))
                {
                    matrixXYZ.Add(p as PositionXYZ<T>);
                }
            }
            Matrix<T>[] matrices = new Matrix<T>[]
            {
                new MatrixX<T>(matrixX.ToArray()),
                new MatrixXY<T>(matrixXY.ToArray()),
                new MatrixXYZ<T>(matrixXYZ.ToArray())
            };
            return new ContainersCollection<T>(new Container<T>(matrices));
        }
    }
}
