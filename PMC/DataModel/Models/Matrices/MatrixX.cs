﻿using DataModel.Models.Positions;
using System.Text;

namespace DataModel.Models.Matrices
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MatrixX<T> : Matrix<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="positions"></param>
        public MatrixX(params PositionX<T>[] positions) : base(positions)
        {
        }

        /// <summary>
        /// Represents a matrix in a string format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Matrix:\r\n");
            if (_positions.Length > 0)
            {
                foreach (var c in _positions)
                {
                    sb.Append("\r\n").Append(c.ToString());
                }
            }
            else sb.Append("\tNo positions");
            return sb.ToString();
        }
    }
}
