using DataModel.Models.Points;
using System.Collections.Generic;
using System;
using System.Collections;

namespace DataModel.Models.Positions
{
    public class PositionX<T> : Position<Point1D<T>, T>
    {
        public PositionX(Point1D<T>[] points) : base(points)
        {
        }
    }
}
