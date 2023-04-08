using System;
using System.Drawing;

namespace InfDetector
{
    public struct Vector
    {
        public float x;
        public float y;
        public Vector(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public Vector(Point point)
        {
            this.x = point.X;
            this.y = point.Y;
        }

        public static float Distance(Vector start, Vector end)
        {
            return (float)Math.Sqrt(((end.x - start.x) * (end.x - start.x)) + ((end.y - start.y) * (end.y - start.y)));
        }

        public static Point ToPoint(Vector vector)
        {
            return new Point((int)vector.x, (int)vector.y);
        }
    }
}
