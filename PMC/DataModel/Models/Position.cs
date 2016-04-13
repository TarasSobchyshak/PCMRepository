using System.Collections;
using System.Collections.Generic;

namespace DataModel
{
    /// <summary>
    /// Represents a strongly typed collection of points that can be accessed by index or via <see cref="IEnumerable"/>.
    /// </summary>
    public class Position<IPoint> : IEnumerable<IPoint>
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Position{IPoint}"/>
        /// </summary>
        /// <param name="points">A list whose elements are copied to new collection</param>
        public Position(List<IPoint> points)
        {
            _points = points;
        }

        private List<IPoint> _points { set; get; }

        /// <summary>
        /// Accessor for accessing data by index.
        /// </summary>
        public IPoint this[int i]
        {
            get { return _points[i]; }
        }

        /// <summary>
        /// Accessor for accessing data via IEnumerable.
        /// </summary>
        public IEnumerator GetEnumerator()
        {
            return _points.GetEnumerator();
        }

        IEnumerator<IPoint> IEnumerable<IPoint>.GetEnumerator()
        {
            return _points.GetEnumerator();
        }
    }
}
