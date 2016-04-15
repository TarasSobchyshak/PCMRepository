using DataModel.Factories.IFactories;
using DataModel.Models.Points;
using DataModel.Models.Positions;

namespace DataModel.Factories.Default
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DefaultPositionFactory<T> : IPositionFactory<T> 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointsCount"></param>
        /// <returns></returns>
        public PositionX<T> CreatePositionX(int pointsCount)
        {
            var points = new Point1D<T>[pointsCount];
            for (int i = 0; i < pointsCount; ++i)
            {
                points[i] = new Point1D<T>();
            }
            return new PositionX<T>(points);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointsCount"></param>
        /// <returns></returns>
        public PositionXY<T> CreatePositionXY(int pointsCount)
        {
            var points = new Point2D<T>[pointsCount];
            for (int i = 0; i < pointsCount; ++i)
            {
                points[i] = new Point2D<T>();
            }
            return new PositionXY<T>(points);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pointsCount"></param>
        /// <returns></returns>
        public PositionXYZ<T> CreatePositionXYZ(int pointsCount)
        {
            var points = new Point3D<T>[pointsCount];
            for (int i = 0; i < pointsCount; ++i)
            {
                points[i] = new Point3D<T>();
            }
            return new PositionXYZ<T>(points);
        }
    }
}
