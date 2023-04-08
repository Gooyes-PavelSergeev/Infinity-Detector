using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace InfDetector
{
    internal static class ShapeDetector
    {
        private const float ROTATION_MAX_ANGLE = 20;
        private const float CROSS_MAX_DISTANCE = 40;
        public static bool ProcessFigure(Figure figure)
        {
            Point[] points = figure.Points;
            Point[] crosses = GetCrosses(points);

            Debug.WriteLine($"Step crosses. There are {crosses.Length} crosses");
            if (!CheckOneCrossCondition(crosses)) return false;
            Debug.WriteLine("Passed crosses");

            Point[] edges = GetEdgesHor(points);
            Point center = crosses[0];

            if (!CheckRotationCondition(edges[0], center)) return false;
            if (!CheckRotationCondition(center, edges[1])) return false;
            Debug.WriteLine("Passed rotation");

            Point leftCircleCenter = GetCenterPoint(edges[0], center);
            Point rightCircleCenter = GetCenterPoint(center, edges[1]);

            Point[] leftCircle = CutFigureLeft(center.X, points);
            Point[] rightCircle = CutFigureRight(center.X, points);

            double avgDevLeft = GetAvgDeviation(leftCircleCenter, leftCircle);
            double avgDevRight = GetAvgDeviation(rightCircleCenter, rightCircle);

            Debug.WriteLine($"LeftDeviation is {avgDevLeft}");
            Debug.WriteLine($"RightDeviation is {avgDevRight}");

            return true;
        }

        private static Point GetEdgeHor(Point[] points, bool left)
        {
            return GetEdgesHor(points)[left ? 0 : 1];
        }

        public static Point[] GetEdgesHor(Point[] points)
        {
            Point min = points[0];
            Point max = points[0];
            foreach (Point point in points)
            {
                if (point.X < min.X) min = point;
                if (point.X > max.X) max = point;
            }
            return new Point[] { min, max };
        }

        public static Point[] GetEdgesVer(Point[] points)
        {
            Point min = points[0];
            Point max = points[0];
            foreach (Point point in points)
            {
                if (point.Y < min.Y) min = point;
                if (point.Y > max.Y) max = point;
            }
            return new Point[] { min, max };
        }

        private static Point[] GetCrosses(Point[] points)
        {
            List<Point> crosses = new List<Point>();
            for (int i = 0; i < points.Length; i++)
            {
                Point current = points[i];
                for (int j = 0; j < points.Length; j++)
                {
                    Point comparing = points[j];
                    if (Math.Abs(current.X - comparing.X) < 10 && Math.Abs(current.Y - comparing.Y) < 10)
                    {
                        if (Math.Abs(i - j) > 30)
                        {
                            if(!crosses.Contains(current)) crosses.Add(current);
                        }
                    }
                }
            }
            return crosses.ToArray();
        }

        private static bool CheckOneCrossCondition(Point[] crosses)
        {
            if (crosses.Length == 0) return false;

            Point[] horEdges = GetEdgesHor(crosses);
            Point[] verEdges = GetEdgesVer(crosses);

            double horDist = horEdges[0].Distance(horEdges[1]);
            Debug.WriteLine($"Hor dist between crosses is {horDist}");
            if (horDist > CROSS_MAX_DISTANCE) return false;

            double verDist = verEdges[0].Distance(verEdges[1]);
            Debug.WriteLine($"Ver dist between crosses is {verDist}");
            if (verDist > CROSS_MAX_DISTANCE) return false;

            return true;
        }

        private static Point GetCenterPoint(Point leftEdge, Point rightEdge)
        {
            int avgX = (rightEdge.X + leftEdge.X) / 2;
            int avgY = (rightEdge.Y + leftEdge.Y) / 2;
            Point center = new Point(avgX, avgY);
            return center;
        }

        private static bool CheckRotationCondition(Point leftEdge, Point rightEdge)
        {
            float xDiff = rightEdge.X - leftEdge.X;
            float yDiff = rightEdge.Y - leftEdge.Y;
            double angle = Math.Atan2(yDiff, xDiff) * (float)(180 / Math.PI);
            return Math.Abs(angle) <= ROTATION_MAX_ANGLE;
        }

        private static double GetAvgDeviation(Point center, Point[] figure)
        {
            double avgDistance = GetAvgDistance(center, figure);
            //Debug.WriteLine($"Avg dist is {avgDistance}");
            double sum = 0;
            for (int i = 0; i < figure.Length; i++)
            {
                double distance = center.Distance(figure[i]);
                double diff = distance - avgDistance;
                double dev = diff * diff;
                sum += dev;
            }
            return Math.Abs(sum / (figure.Length - 1));
        }

        private static double GetAvgDistance(Point center, Point[] figure)
        {
            double sum = 0;
            for (int i = 0; i < figure.Length; i++)
            {
                double d = center.Distance(figure[i]);
                sum += d;
            }
            return sum / figure.Length;
        }

        private static Point[] CutFigureLeft(int cutFrom, Point[] points)
        {
            List<Point> result = new List<Point>();
            for (int i = 0; i < points.Length; i++)
                if (points[i].X < cutFrom)
                    result.Add(points[i]);
            return result.ToArray();
        }

        private static Point[] CutFigureRight(int cutFrom, Point[] points)
        {
            List<Point> result = new List<Point>();
            for (int i = 0; i < points.Length; i++)
                if (points[i].X > cutFrom)
                    result.Add(points[i]);
            return result.ToArray();
        }

        private static bool CheckDeviation(Point center, Point[] figure)
        {
            return true;
        }

        public static Rectangle ToRect(Figure figure)
        {
            Point[] points = figure.Points;
            Point[] horEdges = GetEdgesHor(points);
            Point[] verEdges = GetEdgesVer(points);
            Point topLeft = new Point(horEdges[0].X, verEdges[0].Y);
            Rectangle rect = new Rectangle(topLeft.X, topLeft.Y, horEdges[1].X - horEdges[0].X, verEdges[1].Y - verEdges[0].Y);
            return rect;
        }
    }
}
