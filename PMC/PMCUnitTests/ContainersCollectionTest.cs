using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataModel.Models.Matrices;
using DataModel.Models;
using DataModel.Factories.Default;

namespace PMCUnitTests
{
    [TestClass]
    public class ContainersCollectionTest
    {
        [TestMethod]
        public void PositionCountTest()
        {
            // Arrange
            var factory = new DefaultContainerFactory<int>();
            const int positionCount = 3;
            Type[] matricesSignatures = new Type[]
            {
                typeof(MatrixXYZ<>),
                typeof(MatrixX<>),
                typeof(MatrixXY<>),
            };
            int[][] pointsCountForMatricesAndPositions = new int[][]
            {
                new int[] { 5, 5, 5 },
                Enumerable.Repeat(4,3).ToArray(),
                new int[] { 3, 2, 5 }
            };

            Container<int> container = factory.Create(matricesSignatures, positionCount, pointsCountForMatricesAndPositions);

            // Act
            ContainersCollection<int> containersCollection = new ContainersCollection<int>(container);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PositionXYZPointsCountTest()
        {
            //// Arrange
            var factory = new DefaultContainerFactory<int>();
            const int positionCount = 3;
            Type[] matricesSignatures = new Type[]
            {
                typeof(MatrixX<>),
                typeof(MatrixXY<>),
                typeof(MatrixXYZ<>),
                typeof(MatrixXY<>),
                typeof(MatrixXY<>),
                typeof(MatrixX<>),
                typeof(MatrixXYZ<>),
            };
            int[][] pointsCountForMatricesAndPositions = new int[][]
            {
                new int[] { 300, 2223, 15 },
                new int[] { 13, 0, 4 },
                new int[] { 5, 5, 5 },
                new int[] { 54, 823, 5 },
                new int[] { 428, 5, 1 },
                new int[] { 328, 2, 0 },
                new int[] { 5, 56, 5 }
            };

            Container<int> container = factory.Create(matricesSignatures, positionCount, pointsCountForMatricesAndPositions);

            //// Act
            ContainersCollection<int> containersCollection = new ContainersCollection<int>(container);
        }

        [TestMethod]
        public void LargeDataTest()
        {
            // Arrange
            var factory = new DefaultContainerFactory<int>();
            int positionCount = 500;
            Type[] types = new Type[50];
            int[][] points = new int[types.Count()][];
            Container<int>[] containers = new Container<int>[1000];

            for (int i = 0; i < types.Length; ++i)
            {
                types[i] = typeof(MatrixXY<>);
            }

            for (int i = 0; i < points.Length; ++i)
            {
                points[i] = new int[positionCount];
                for(int j = 0; j < positionCount; ++j) points[i][j] = 0;
            }
            for(int i = 0; i < containers.Length; ++i)
            {
                containers[i] = factory.Create(types, positionCount, points);
            }

            // Act
            ContainersCollection<int> containersCollection = new ContainersCollection<int>(containers);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void NotNumericTypeTest()
        {
            // Act
            ContainersCollection<char> containersCollection = new ContainersCollection<char>(new Container<char>[0]);
        }

        [TestMethod]
        public void NumericTypeTest()
        {
            // Act
            ContainersCollection<decimal> containersCollection = new ContainersCollection<decimal>(new Container<decimal>[0]);
        }
    }
}