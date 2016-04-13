using System.Collections;
using System.Collections.Generic;

namespace DataModel
{
    /// <summary>
    /// Represents a strongly typed collection of positions that can be accessed by index or via <see cref="IEnumerable"/>.
    /// </summary>
    public class Matrix<IPoint> : IEnumerable<Position<IPoint>>
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Matrix{IPoint}"/>
        /// </summary>
        /// <param name="positions">A list whose elements are copied to new collection</param>
        public Matrix(List<Position<IPoint>> positions)
        {
            _positions = positions;
        }

        private List<Position<IPoint>> _positions { set; get; }

        /// <summary>
        /// Accessor for accessing data by index.
        /// </summary>
        public Position<IPoint> this[int i]
        {
            get { return _positions[i]; }
        }

        /// <summary>
        /// Accessor for accessing data via IEnumerable.
        /// </summary>
        public IEnumerator<Position<IPoint>> GetEnumerator()
        {
            return _positions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _positions.GetEnumerator();
        }
    }
}
