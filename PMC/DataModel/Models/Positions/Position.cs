using DataModel.Models.Points;
using System.Collections;
using System.Collections.Generic;

namespace DataModel.Models.Positions
{
    /// <summary>
    /// Represents a collection of points that can be accessed by index or via <see cref="IEnumerable"/>.
    /// </summary>
    public abstract class Position<T> : IEnumerable<Point<T>> 
    {
        /// <summary>
        /// 
        /// </summary>
        public Position()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="points"></param>
        public Position(params Point<T>[] points)
        {
            _points = points;
        }

        /// <summary>
        /// 
        /// </summary>
        protected Point<T>[] _points;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Point<T> this[int i]
        {
            get { return _points[i]; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
