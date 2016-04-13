using System.Collections.Generic;

namespace DataModel.Factories
{
    internal interface IPositionFactory<T>
    {
        Position<Point1D<T>> CreatePositionX();
        Position<Point2D<T>> CreatePositionXY();
        Position<Point3D<T>> CreatePositionXYZ();
    }

    internal class DefaultPositionFactory<T> : IPositionFactory<T>
    {
        public Position<Point1D<T>> CreatePositionX()
        {
            List<Point1D<T>> points = new List<Point1D<T>>();
            // to do
            return new Position<Point1D<T>>(points);
        }

        public Position<Point2D<T>> CreatePositionXY()
        {
            List<Point2D<T>> points = new List<Point2D<T>>();
            // to do
            return new Position<Point2D<T>>(points);
        }

        public Position<Point3D<T>> CreatePositionXYZ()
        {
            List<Point3D<T>> points = new List<Point3D<T>>();
            // to do
            return new Position<Point3D<T>>(points);
        }
    }
}
