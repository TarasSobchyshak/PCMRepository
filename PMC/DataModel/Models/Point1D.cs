﻿namespace DataModel
{
    /// <summary>
    /// Represents a single numarical value (x).
    /// </summary>
    /// <typeparam name="T">Value type.</typeparam>
    public class Point1D<T> : Interfaces.IPoint<T>
    {
        public Point1D()
        {
            X = default(T);
        }
        public Point1D(T x)
        {
            X = x;
        }

        public T X
        {
            private set;
            get;
        }
    }
}
