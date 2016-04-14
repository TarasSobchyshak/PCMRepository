using DataModel.Factories.IFactories;
using DataModel.Models.Points;
using DataModel.Models.Positions;
using System.Linq;

namespace DataModel.Factories.Default
{
    public class DefaultPositionFactory<T> : IPositionFactory<T> where T : struct
    {
        public PositionX<T> CreatePositionX(int pointsCount)
        {
            var points = new Point1D<T>[pointsCount];
            for (int i = 0; i < pointsCount; ++i)
            {
                points[i] = new Point1D<T>();
            }
            return new PositionX<T>(points.ToArray());
        }

        public PositionXY<T> CreatePositionXY(int pointsCount)
        {
            var points = new Point2D<T>[pointsCount];
            for (int i = 0; i < pointsCount; ++i)
            {
                points[i] = new Point2D<T>();
            }
            return new PositionXY<T>(points.ToArray());
        }

        public PositionXYZ<T> CreatePositionXYZ(int pointsCount)
        {
            var points = new Point3D<T>[pointsCount];
            for (int i = 0; i < pointsCount; ++i)
            {
                points[i] = new Point3D<T>();
            }
            return new PositionXYZ<T>(points.ToArray());
        }
    }
}
