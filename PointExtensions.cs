using System;
using System.Drawing;

namespace InfDetector
{
    internal static class PointExtensions
    {
        public static double Distance(this Point point, Point endPoint)
        {
            int dX = endPoint.X - point.X;
            int dY = endPoint.Y - point.Y;
            double distance = (dX * dX) + (dY * dY);
            return Math.Sqrt(distance);
        }

        public static double Module(this Point point)
        {
            return Math.Sqrt(point.X * point.X + point.Y * point.Y);
        }

        public static float ScalarAmplify(this Point point, Point targetPoint)
        {
            float x = Math.Abs(point.X * point.X + targetPoint.X * targetPoint.X);
            float y = Math.Abs(point.Y * point.Y + targetPoint.Y * targetPoint.Y);
            return x * y;
        }

        public static float VectorAmplify(this Point point, Point targetPoint)
        {
            return point.X * point.Y + targetPoint.X * targetPoint.Y;
        }
    }
}
