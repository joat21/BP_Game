namespace Game.Model;

public class Tile
{
    public virtual Image Sprite { get; set; }
    public virtual bool IsSolid => true;
    public Point Position { get; set; }
    public Rectangle DrawingArea =>
        new(Position.X * Game.TileSize,
            Position.Y * Game.TileSize,
            Game.TileSize,
            Game.TileSize);

    public Tile(Image sprite, Point position)
    {
        Sprite = sprite;
        Position = position;
    }
}