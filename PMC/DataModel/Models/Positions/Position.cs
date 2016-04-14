using DataModel.Models.Points;
using System.Collections;
using System.Collections.Generic;

namespace DataModel.Models.Positions
{
    /// <summary>
    /// Represents a collection of points that can be accessed by index or via <see cref="IEnumerable"/>.
    /// </summary>
    public abstract class Position<T> : IEnumerable<Point<T>> where T : struct
    {
        public Position()
        {
        }
        public Position(params Point<T>[] points)
        {
            _points = points;
        }

        protected Point<T>[] _points;

        public Point<T> this[int i]
        {
            get { return _points[i]; }
        }

        public IEnumerator<Point<T>> GetEnumerator()
        {
            return ((IEnumerable<Point<T>>)_points).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _points.GetEnumerator();
        }
    }
}
