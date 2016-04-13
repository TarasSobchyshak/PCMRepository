using DataModel.Models.Points;
using System.Collections;
using System.Collections.Generic;

namespace DataModel.Models.Positions
{
    /// <summary>
    /// Represents a strongly typed collection of points that can be accessed by index or via <see cref="IEnumerable"/>.
    /// </summary>
    public abstract class Position<PointT, T> : IEnumerable<PointT> where PointT : IPoint<T>
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Position{PointT, T}"/>
        /// </summary>
        public Position()
        {
            // position can contain 0 points
            _points = new PointT[0];
        }
        /// <summary>
        /// Initializes a new instance of <see cref="Position{PointT, T}"/>
        /// </summary>
        /// <param name="points">A list whose elements are copied to new collection</param>
        public Position(PointT[] points)
        {
            _points = points;
        }

        private PointT[] _points { set; get; }

        /// <summary>
        /// Accessor for accessing data by index.
        /// </summary>
        public IPoint<T> this[int i]
        {
            get { return _points[i]; }
        }

        /// <summary>
        /// Accessor for accessing data via IEnumerable.
        /// </summary>
        public IEnumerator<PointT> GetEnumerator()
        {
            return ((IEnumerable<PointT>)_points).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<PointT>)_points).GetEnumerator();
        }

    }
}
