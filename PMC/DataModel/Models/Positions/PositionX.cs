using DataModel.Models.Points;

namespace DataModel.Models.Positions
{
    public class PositionX<T> : Position<T> where T :struct
    {
        public PositionX(): base()
        {
            _points = new Point1D<T>[0];
        }
        public PositionX(params Point1D<T>[] points): base(points)
        {
        }
    }
}
