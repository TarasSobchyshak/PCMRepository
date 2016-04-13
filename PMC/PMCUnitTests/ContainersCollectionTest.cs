using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataModel.Interfaces;
using DataModel;


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
            var points = Enumerable.Range(1, 10).Select(r => (IPoint<double>)new Point1D<double>(r));
            var positions = Enumerable.Range(1, new Random().Next(10)).Select(r => new Position<IPoint<double>>(points.ToList()));
            var matrices = Enumerable.Range(1, 10).Select(r => new Matrix<IPoint<double>>(positions.ToList()));
            var containers = Enumerable.Range(1, 10).Select(r => new Container<double>(matrices.ToList()));

            // Act
            var containersColletion = new ContainersCollection<double>(containers.ToList());
        }

        [TestMethod]
        [ExpectedException(typeof(ArrayTypeMismatchException))]
        public void NotNumericTypeTest()
        {
            // Arrange
            var points = Enumerable.Range(1, 10).Select(r => (IPoint<char>)new Point1D<char>(Convert.ToChar(r)));
            var positions = Enumerable.Range(1, new Random().Next(10)).Select(r => new Position<IPoint<char>>(points.ToList()));
            var matrices = Enumerable.Range(1, 10).Select(r => new Matrix<IPoint<char>>(positions.ToList()));
            var containers = Enumerable.Range(1, 10).Select(r => new Container<char>(matrices.ToList()));

            // Act
            var containersColletion = new ContainersCollection<char>(containers.ToList());
        }

    }
}