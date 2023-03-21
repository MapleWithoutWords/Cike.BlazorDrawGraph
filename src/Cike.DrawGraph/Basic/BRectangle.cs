namespace Cike.DrawGraph.Basic
{
    public class BRectangle : BPoint
    {
        public BRectangle(int x, int y, int width, int height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; set; }
        public int Height { get; set; }
    }
}
