using DataModel.Models.Matrices;
using DataModel.Models.Positions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataModel.Models
{
    /// <summary>
    /// Represents a strongly typed collection of containers that can be accessed by index or via <see cref="IEnumerable"/>.
    /// </summary>
    public class ContainersCollection<T> : IEnumerable<Container<T>>
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="containers">A list whose elements are copied to new collection</param>
        public ContainersCollection(params Container<T>[] containers)
        {
            if (!numericTypes.Contains(typeof(T)))
            {
                throw new Exception("Data point must be of numeric type.");
            }

            if (containers != null && containers.Any())
            {
                if (!IsPointsNumberValid(containers))
                {
                    throw new ArgumentException("All XYZ positions in all containers must have the same number of points.");
                }
                if (!IsPositionsNumberValid(containers))
                {
                    throw new ArgumentException("All NOT XYZ matrices in all containers must have the same number of positions.");
                }
            }
            _containers = containers;
        }

        private Container<T>[] _containers { set; get; }
        private Type[] numericTypes = new Type[] { typeof(int), typeof(decimal), typeof(float) };

        private bool IsPointsNumberValid(Container<T>[] containers)
        {
            if (!containers.Any()) return true;

            var matrixXYZ = containers.First()
                    .FirstOrDefault(m => m.GetType() == typeof(MatrixXYZ<T>));

            if (matrixXYZ == null || !matrixXYZ.Any()) return true;

            return containers.All(c => c.All(m => m.Where(p => p.GetType() == typeof(PositionXYZ<T>))
                        .All(t => t.Count() == matrixXYZ.First().Count())));
        }

        private bool IsPositionsNumberValid(Container<T>[] containers)
        {
            int? count =
                containers
                    .FirstOrDefault()
                    .FirstOrDefault(m => m.GetType() != typeof(MatrixXYZ<T>))
                    .Count();

            return
                count == null
                            ? false
                            : containers.All(c =>
                                c.Where(m => m.GetType() != typeof(MatrixXYZ<T>))
                                .All(p => p.Count() == count));
        }

        /// <summary>
        /// Accessor for accessing data via IEnumerable.
        /// </summary>
        public IEnumerator<Container<T>> GetEnumerator()
        {
            return ((IEnumerable<Container<T>>)_containers).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Container<T>>)_containers).GetEnumerator();
        }

        /// <summary>
        /// Accessor for accessing data by index.
        /// </summary>
        public Container<T> this[int i]
        {
            get { return _containers[i]; }
        }

        /// <summary>
        /// Represents a containers collection in a string format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Containers collection:");
            foreach(var c in _containers)
            {
                sb.Append("\r\n\r\n\r\n").Append(c.ToString());
            }
            return sb.ToString();
        }
    }
}
