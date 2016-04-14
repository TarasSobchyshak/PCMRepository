using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataModel.Models.Points;
using DataModel.Models.Positions;
using DataModel.Models.Matrices;
using DataModel.Models;
using System.Collections.Generic;
using DataModel.Factories;
using DataModel.Factories.Default;

namespace PMCUnitTests
{
    [TestClass]
    public class ContainersCollectionTest
    {
        [TestMethod]
        public void Testing()
        {
            //// Arrange

            var factory = new DefaultContainerFactory<int>();

            Container<int> container = factory.Create(2, 
                new int[][] 
                {
                    Enumerable.Repeat(1,2).ToArray(),
                    Enumerable.Repeat(1,2).ToArray()
                });

            //// Act
        }
        [TestMethod]
        //   [ExpectedException(typeof(ArgumentException))]
        public void NumberOfPositionsTest()
        {
            //// Arrange
            //var points = Enumerable.Range(1, 1).Select(r => new Point2D<double>(r, r));
            //var positions = Enumerable.Range(1, 1)
            //    .Select(r => new DefaultPositionFactory<double>().CreatePositionXY(1));

            //var matrices = Enumerable.Range(1, 2)
            //    .Select(r => new DefaultMatrixFactory<double>().CreateMatrixXY(15,2));

            // var positions = Enumerable.Range(1, new Random().Next(15)).Select(r => new PositionXY<double>(points.ToArray()));
            //   var matrices = Enumerable.Range(1, 10).Select(r => new MatrixXY<double>(positions.ToArray()));
            var containers = Enumerable.Range(1, 1)
                .Select(r => new Container<int>(
                    new Matrix<int>[]
                    {
                        new MatrixXY<int>(new PositionXY<int>[2]
                            { new PositionXY<int>(), new PositionXY<int>() }),
                        new MatrixXY<int>(new PositionXY<int>[2]
                            { new PositionXY<int>(), new PositionXY<int>() }),
                        new MatrixXY<int>(new PositionXY<int>[2]
                            { new PositionXY<int>(), new PositionXY<int>() }),
                        new MatrixX<int>(new PositionX<int>[2]
                            { new PositionX<int>(), new PositionX<int>() }),
                        new MatrixXY<int>(new PositionXY<int>[2]
                            { new PositionXY<int>(), new PositionXY<int>() }),
                    }
                    ));

            //// Act
            var containersColletion = new ContainersCollection<int>(containers.ToArray());
        }
        [TestMethod]
        public void NumberOfPositionsXYZTest()
        {
            //// Arrange
            //var points = Enumerable.Range(1, 10).Select(r => new Point3D<double>(r, r, r));
            //var positions = Enumerable.Range(1, new Random().Next(10)).Select(r => new PositionXYZ<double>(points.ToArray()));
            //var matrices = Enumerable.Range(1, 10).Select(r => new MatrixXYZ<double>(positions.ToArray()));
            //var containers = Enumerable.Range(1, 10).Select(r => new Container<Point3D<double>, double>(matrices.ToArray()));

            //// Act
            //var containersColletion = new ContainersCollection<Point3D<double>, double>(containers.ToArray());
        }
        [TestMethod]
        public void LargeDataTest()
        {
            //// Arrange

            //// Act
            //var m = new Container<Point1D<int>, int>(new Matrix<Point1D<int>, int>[] {
            //    new Matrix<Point1D<int>, int>(new Position<Point1D<int>, int>[0])
            //});
        }
        //[TestMethod]
        //[ExpectedException(typeof(ArgumentException))]
        //public void NumberOfPositionsTest()
        //{
        //    // Arrange
        //    var points = Enumerable.Range(1, 10).Select(r => new Point3D<double>(r, r, r));
        //    var positions10 = Enumerable.Range(1, new Random().Next(10)).Select(r => new PositionXYZ<double>(points.ToArray()));
        //    var positions11 = Enumerable.Range(1, new Random().Next(11)).Select(r => new PositionXYZ<double>(points.ToArray()));
        //    var matrices = Enumerable.Range(1, 10).Select(r => new MatrixXYZ<double>(positions10.Union(positions11).ToArray()));
        //    var containers = Enumerable.Range(1, 10).Select(r => new Container<Point3D<double>, double>(matrices.ToArray()));

        //    // Act
        //    var containersColletion = new ContainersCollection<Point3D<double>, double>(containers.ToArray());
        //}

        [TestMethod]
        [ExpectedException(typeof(ArrayTypeMismatchException))]
        public void NotNumericTypeTest()
        {
            //// Arrange
            //var points = Enumerable.Range(1, 10).Select(r => new Point1D<char>(Convert.ToChar(r)));
            //var positions = Enumerable.Range(1, new Random().Next(10)).Select(r => new PositionX<char>(points.ToArray()));
            //var matrices = Enumerable.Range(1, 10).Select(r => new MatrixX<char>(positions.ToArray()));
            //var containers = Enumerable.Range(1, 10).Select(r => new Container<Point1D<char>, char>(matrices.ToArray()));

            //// Act
            //var containersColletion = new ContainersCollection<Point1D<char>, char>(containers.ToArray());
        }

    }
}