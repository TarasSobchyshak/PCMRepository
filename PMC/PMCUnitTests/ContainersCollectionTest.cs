using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataModel.Models.Points;
using DataModel.Models.Positions;
using DataModel.Models.Matrices;
using DataModel.Models;

namespace PMCUnitTests
{
    [TestClass]
    public class ContainersCollectionTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NumberOfPositionsTest()
        {
            // Arrange
            var points = Enumerable.Range(1, 10).Select(r => new Point2D<double>(r, r));
            var positions = Enumerable.Range(1, new Random().Next(10)).Select(r => new PositionXY<double>(points.ToArray()));
            var matrices = Enumerable.Range(1, 10).Select(r => new MatrixXY<double>(positions.ToArray()));
            var containers = Enumerable.Range(1, 10).Select(r => new Container<Point2D<double>, double>(matrices.ToArray()));

            // Act
            var containersColletion = new ContainersCollection<Point2D<double>, double>(containers.ToArray());
        }
        [TestMethod]
        public void LargeDataTest()
        {
            // Arrange
            var points = Enumerable.Range(1, 10).Select(r => new Point2D<double>(r, r));
            var positions = Enumerable.Range(1, 100).Select(r => new PositionXY<double>(points.ToArray()));
            var matrices = Enumerable.Range(1, 50).Select(r => new MatrixXY<double>(positions.ToArray()));
            var containers = Enumerable.Range(1, 10).Select(r => new Container<Point2D<double>, double>(matrices.ToArray()));

            // Act
            var containersColletion = new ContainersCollection<Point2D<double>, double>(containers.ToArray());
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
            // Arrange
            var points = Enumerable.Range(1, 10).Select(r => new Point1D<char>(Convert.ToChar(r)));
            var positions = Enumerable.Range(1, new Random().Next(10)).Select(r => new PositionX<char>(points.ToArray()));
            var matrices = Enumerable.Range(1, 10).Select(r => new MatrixX<char>(positions.ToArray()));
            var containers = Enumerable.Range(1, 10).Select(r => new Container<Point1D<char>, char>(matrices.ToArray()));

            // Act
            var containersColletion = new ContainersCollection<Point1D<char>, char>(containers.ToArray());
        }

    }
}