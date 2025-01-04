using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Point
    {
        #region Properties
        public double X { get; set; }
        public double Y { get; set; }
        #endregion

        #region Costructors
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        #endregion

        #region Methods
        public static double CalcDistance(Point P01, Point P02)
        {
            return Math.Sqrt(Math.Pow(P01.X - P02.X,2) + Math.Pow(P01.Y - P02.Y,2));
        }
        #endregion
    }
}
