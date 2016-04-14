using DataModel.Models.Points;

namespace DataModel.Models.Positions
{
    public class PositionXY<T> : Position<T> where T : struct
    {
        public PositionXY(): base()
        {
            _points = new Point2D<T>[0];
        }
        public PositionXY(params Point2D<T>[] points): base(points)
        {
        }
    }
}
