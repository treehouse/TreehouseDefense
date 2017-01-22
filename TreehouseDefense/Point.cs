using System;

namespace TreehouseDefense
{
    public class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point point)
        {
            return Math.Sqrt(Math.Pow(X - point.X, 2.0) + Math.Pow(Y - point.Y, 2.0));
        }

        public override bool Equals(object obj)
        {
            Point that = obj as Point;
            return that != null && this.X == that.X && this.Y == that.Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() * 31 + Y.GetHashCode();
        }
    }
}
