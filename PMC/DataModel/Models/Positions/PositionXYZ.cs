using DataModel.Models.Points;

namespace DataModel.Models.Positions
{
    public class PositionXYZ<T> : Position<Point3D<T>, T>
    {
        public PositionXYZ(Point3D<T>[] points) : base(points)
        {
        }
    }
}
