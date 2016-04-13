using DataModel.Models.Points;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataModel.Models
{

    //[AttributeUsage(AttributeTargets.All)]
    //public class ValidTypeAttribute : ValidationAttribute
    //{
    //    public ValidTypeAttribute(string str, params Type[] type)
    //    {
    //        _type = type;
    //    }

    //    private Type[] _type;

    //    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    //    {

    //        return ValidationResult.Success;
    //    }
    //}
    /// <summary>
    /// Represents a strongly typed collection of containers that can be accessed by index or via <see cref="IEnumerable"/>.
    /// </summary>
    /// <typeparam name="T">Type of point's coordinates.</typeparam>
    public class ContainersCollection<PointT, T> : IEnumerable<Container<PointT, T>> where PointT : class, IPoint<T>
    {
        //static string qwe = typeof(T).ToString();

        /// <summary>
        /// Initializes a new instance of <see cref="ContainersCollection{T}"/>
        /// </summary>
        /// <param name="containers">A list whose elements are copied to new collection</param>
        //[ValidType(qwe, new Type[] { typeof(double), typeof(float), typeof(short), typeof(int), typeof(long), typeof(decimal) })]
        public ContainersCollection(Container<PointT, T>[] containers)
        {
            if (!IsValidType()) throw new ArrayTypeMismatchException("Attempt to store element of not numeric type.");
            if (!IsPositionsNumberValid(containers)) throw new ArgumentException("All X and XY matrices in all containers must have the same number of positions.");
        }

        private static Type[] validTypes = { typeof(double), typeof(int), typeof(decimal) };
        private Container<PointT, T>[] _containers { set; get; }

        public static bool IsPositionsNumberValid(Container<PointT, T>[] containers)
        {
            return
                typeof(PointT) != typeof(Point3D<T>)
                ? containers.Any()
                    && containers[0].Any() // matrices
                    && containers[0][0].Any() // positions
                    && containers.All(c => c.All(m => m.Count() == containers[0][0][0].Count()))
                : true;
        }
        public static bool IsValidType()
        {
            return validTypes.Contains(typeof(T));
        }

        /// <summary>
        /// Accessor for accessing data via IEnumerable.
        /// </summary>
        public IEnumerator<Container<PointT, T>> GetEnumerator()
        {
            return ((IEnumerable<Container<PointT, T>>)_containers).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Container<PointT, T>>)_containers).GetEnumerator();
        }

        /// <summary>
        /// Accessor for accessing data by index.
        /// </summary>
        public Container<PointT, T> this[int i]
        {
            get { return _containers[i]; }
        }
    }
}
