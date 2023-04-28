namespace Game.Model
{
    class Tile
    {
        public static Size Size;
        public Image Sprite { get; set; }
        public Point Position { get; set; }
        public Rectangle DrawingArea
        {
            get => new(
                Position.X * Size.Width,
                Position.Y * Size.Height,
                Size.Width,
                Size.Height);
        }

        public Tile(Image sprite, Point position)
        {
            Sprite = sprite;
            Position = position;
        }
    }
}
