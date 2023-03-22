namespace Cike.DrawGraph.Basic
{
    public class BPoint
    {
        public BPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; protected set; }
        public int Y { get; protected set; }

        public static bool operator ==(BPoint source, BPoint target)
        {
            return source.X == target.X && source.Y == target.Y;
        }
        public static bool operator !=(BPoint source, BPoint target)
        {
            return !(source == target);
        }
    }
}
