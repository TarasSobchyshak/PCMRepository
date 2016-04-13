using System;
using DataModel.Models;
using DataModel.Models.Matrices;
using DataModel.Models.Points;

namespace DataModel.Factories
{
    public interface IContainerFactory<T>
    {
        Container<Point1D<T>, T> CreateX();
        Container<Point2D<T>, T> CreateXY();
        Container<Point3D<T>, T> CreateXYZ();
    }

    public class DefaultContainerFactory<T> : IContainerFactory<T>
    {
        public Container<Point1D<T>, T> CreateX()
        {
            Matrix<Point1D<T>, T>[] matrices = new Matrix<Point1D<T>, T>[0];
            //to do
            return new Container<Point1D<T>, T>(matrices);
        }

        public Container<Point2D<T>, T> CreateXY()
        {
            Matrix<Point2D<T>, T>[] matrices = new Matrix<Point2D<T>, T>[0];
            //to do
            return new Container<Point2D<T>, T>(matrices);
        }

        public Container<Point3D<T>, T> CreateXYZ()
        {
            Matrix<Point3D<T>, T>[] matrices = new Matrix<Point3D<T>, T>[0];
            //to do
            return new Container<Point3D<T>, T>(matrices);
        }
    }
}
