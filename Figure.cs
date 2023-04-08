using System.Collections.Generic;
using System.Drawing;

namespace InfDetector
{
    public class Figure
    {
        public Point[] Points { get => _points; }
        private Point[] _points;
        private List<Point> _pointsList;
        public Figure()
        {
            _pointsList = new List<Point>();
        }

        public void AddPoint(Point point)
        {
            _pointsList.Add(point);
        }

        public void Cap()
        {
            _points = _pointsList.ToArray();
            _pointsList = new List<Point>();
        }
    }
}
