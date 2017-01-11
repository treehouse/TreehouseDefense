namespace TreehouseDefense
{
    public class Map
    {
        public readonly int Width;
        public readonly int Height;

        public Map(int width, int height)
        {
            if (width < 1 || height < 1)
            {
                throw new System.ArgumentOutOfRangeException(
                    "Map must be at least 1x1");
            }

            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            return point.X >= 0 && point.X < Width &&
                   point.Y >= 0 && point.Y < Height;
        }
    }
}
