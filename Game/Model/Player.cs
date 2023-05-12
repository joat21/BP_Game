using System.Windows.Input;

namespace Game.Model;

public class Player
{
    private readonly float speed = 15f;
    private readonly float gravity = 35f;
    private bool isOnGround;
    public PointF Position { get; set; }
    public Image Sprite { get; set; }
    public float Speed { get; set; }
    public float JumpForce { get; set; }

    public RectangleF DrawingArea =>
        new(Position.X,
            Position.Y,
            Game.TileSize,
            Game.TileSize);
 
    public Player(Image sprite)
    {
        Sprite = sprite;
    }

    public void Update()
    {
        Gravity();
        var dx = 0;
        if (Keyboard.IsKeyDown(Key.A)) dx = -1;
        if (Keyboard.IsKeyDown(Key.D)) dx = 1;
        Move(dx);
    }

    private void Move(int dx)
    {
        var x = Position.X + dx * speed;

        var targetTile = GetTargetTile(
            dx == 1 ? Position.X + Game.TileSize : Position.X,
            Position.Y);

        if (targetTile is null || !targetTile.IsSolid)
            Position = new PointF(x, Position.Y);
    }

    private void Gravity()
    {
        var y = Position.Y + Game.TileSize;
        var targetTile = GetTargetTile(Position.X, y);
        if (targetTile is null || !targetTile.IsSolid)
            Position = new PointF(Position.X, Position.Y + gravity);
    }

    private static Tile GetTargetTile(float x, float y)
    {
        return Game.State.Level.Tiles[
            (int)x / Game.TileSize,
            (int)y / Game.TileSize];
    }
}