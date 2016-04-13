using DataModel.Models.Points;

namespace DataModel.Models.Positions
{
    public class PositionXY<T> : Position<Point2D<T>, T>
    {
        public PositionXY() { }
        public PositionXY(Point2D<T>[] points) : base(points)
        {
        }
    }
}
