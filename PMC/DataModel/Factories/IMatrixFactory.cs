using System.Collections.Generic;

namespace DataModel.Factories
{
    public interface IMatrixFactory<T>
    {
        Matrix<Point1D<T>> CreateMatrixX();
        Matrix<Point2D<T>> CreateMatrixXY();
        Matrix<Point3D<T>> CreateMatrixXYZ();
    }

    public class DefaultMatrixFactory<T> : IMatrixFactory<T>
    {
        public Matrix<Point1D<T>> CreateMatrixX()
        {
            List<Position<Point1D<T>>> points = new List<Position<Point1D<T>>>();
            // to do
            return new Matrix<Point1D<T>>(points);
        }

        public Matrix<Point2D<T>> CreateMatrixXY()
        {
            List<Position<Point2D<T>>> points = new List<Position<Point2D<T>>>();
            // to do
            return new Matrix<Point2D<T>>(points);
        }

        public Matrix<Point3D<T>> CreateMatrixXYZ()
        {
            List<Position<Point3D<T>>> points = new List<Position<Point3D<T>>>();
            // to do
            return new Matrix<Point3D<T>>(points);
        }
    }
}
