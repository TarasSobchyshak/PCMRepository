using DataModel.Models.Points;

namespace DataModel.Models.Positions
{
    public class PositionXYZ<T> : Position<T> where T : struct
    {
        public PositionXYZ() : base()
        {
            _points = new Point3D<T>[0];
        }
        public PositionXYZ(params Point3D<T>[] points) : base(points)
        {
        }
    }
}
