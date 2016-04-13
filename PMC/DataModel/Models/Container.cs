using DataModel.Models.Matrices;
using DataModel.Models.Points;
using System.Collections;
using System.Collections.Generic;
using System;

namespace DataModel.Models
{
    /// <summary>
    /// Represents a strongly typed collection of matrices that can be accessed by index or via <see cref="IEnumerable"/>.
    /// </summary>
    /// <typeparam name="T">Type of point's coordinates.</typeparam>
    /// <typeparam name="PointT"></typeparam>
    public class Container<PointT, T> : IEnumerable<Matrix<PointT, T>> where PointT : class, IPoint<T>
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Container{PointT, T}"/>
        /// </summary>
        /// <param name="matrices">A list whose elements are copied to new collection</param>
        public Container(Matrix<PointT, T>[] matrices)
        {
            _matrices = matrices;
        }

        private Matrix<PointT, T>[] _matrices { set; get; }

        /// <summary>
        /// Accessor for accessing data by index.
        /// </summary>
        public Matrix<PointT, T> this[int i]
        {
            get { return _matrices[i]; }
        }

        /// <summary>
        /// Accessor for accessing data via IEnumerable.
        /// </summary>
        public IEnumerator<Matrix<PointT, T>> GetEnumerator()
        {
            return ((IEnumerable<Matrix<PointT, T>>)_matrices).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Matrix<PointT, T>>)_matrices).GetEnumerator();
        }
    }
}
