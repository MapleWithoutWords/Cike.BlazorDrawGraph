namespace Cike.DrawGraph.Basic
{
    public class BRectangle : BPoint
    {
        public BRectangle(int x, int y, int width, int height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public int Width { get; protected set; }

        public int Height { get; protected set; }

        public BPoint? TargetPoint { get; set; }
        public BPoint? SourcePoint { get; set; }

        public BPoint GetCenterPoint()
        {
            return new BPoint(GetCenterX(), GetCenteY());
        }

        public int GetCenterX()
        {
            return X + (Width / 2);
        }

        public int GetCenteY()
        {
            return Y + (Height / 2);
        }

        public void Rotate90()
        {
            var t = (this.Width - this.Height) / 2;
            this.X += t;
            this.Y -= t;
            var tmp = this.Width;
            this.Width = this.Height;
            this.Height = tmp;
        }

        public BRectangle Grow(int amount)
        {
            this.X -= amount;
            this.Y -= amount;
            this.Width += 2 * amount;
            this.Height += 2 * amount;

            return this;
        }
    }
}
