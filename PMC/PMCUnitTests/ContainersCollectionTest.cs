using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
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
            var points = Enumerable.Range(1, 10).Select(r => new Point1D<int>(r));
            var positions = Enumerable.Range(1, new Random().Next(10)).Select(r => new Position<Point1D<int>>(points.ToList()));
            var matrices = Enumerable.Range(1, 10).Select(r => new Matrix<Point1D<int>>(positions.ToList()));
            var containers = Enumerable.Range(1, 10).Select(r => new Container<Point1D<int>>(matrices.ToList()));

            // Act
            var containersColletion = new ContainersCollection<Point1D<int>>(containers.ToList());
        }
    }
}