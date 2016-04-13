using DataModel.Models.Points;
using DataModel.Models.Positions;
using System.Collections;
using System.Collections.Generic;
using System;

namespace DataModel.Models.Matrices
{
    /// <summary>
    /// Represents a strongly typed collection of positions that can be accessed by index or via <see cref="IEnumerable"/>.
    /// </summary>
    public abstract class Matrix<PointT, T> : IEnumerable<Position<PointT, T>> where PointT : IPoint<T>
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Matrix{PointT, T}"/>
        /// </summary>
        /// <param name="positions">A list whose elements are copied to new collection</param>
        public Matrix(Position<PointT, T>[] positions)
        {
            _positions = positions;
        }

        protected Position<PointT, T>[] _positions { set; get; }

        /// <summary>
        /// Accessor for accessing data by index.
        /// </summary>
        public Position<PointT, T> this[int i]
        {
            get { return _positions[i]; }
        }

        /// <summary>
        /// Accessor for accessing data via IEnumerable.
        /// </summary>
        public IEnumerator<Position<PointT, T>> GetEnumerator()
        {
            return ((IEnumerable<Position<PointT, T>>)_positions).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Position<PointT, T>>)_positions).GetEnumerator();
        }

        public static implicit operator Matrix<PointT, T>(MatrixXYZ<double> v)
        {
            throw new NotImplementedException();
        }
    }
}
