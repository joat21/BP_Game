namespace Game.Model;

public class Coin : Tile
{
    public static new Image Sprite => Resources.Coin;
    public override bool IsSolid { get; }

    public Coin(Image sprite, Point position) : base(sprite, position)
    {
    }
}