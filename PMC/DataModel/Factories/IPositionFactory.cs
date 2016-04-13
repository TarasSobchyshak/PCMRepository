using DataModel.Models.Points;
using DataModel.Models.Positions;
using System.Linq;

namespace DataModel.Factories
{
    public interface IPositionFactory<T>
    {
        PositionX<T> CreatePositionX(int pointsCount);
        PositionXY<T> CreatePositionXY(int pointsCount);
        PositionXYZ<T> CreatePositionXYZ(int pointsCount);
    }

    public class DefaultPositionFactory<T> : IPositionFactory<T>
    {
        public PositionX<T> CreatePositionX(int pointsCount)
        {
            var points = Enumerable.Range(1, pointsCount).Select(r => new Point1D<T>());
            return new PositionX<T>(points.ToArray());
        }

        public PositionXY<T> CreatePositionXY(int pointsCount)
        {
            var points = Enumerable.Range(1, pointsCount).Select(r => new Point2D<T>());
            return new PositionXY<T>(points.ToArray());
        }

        public PositionXYZ<T> CreatePositionXYZ(int pointsCount)
        {
            var points = Enumerable.Range(1, pointsCount).Select(r => new Point3D<T>());
            return new PositionXYZ<T>(points.ToArray());
        }
    }
}
