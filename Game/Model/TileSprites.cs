namespace Game.Model;

public class TileSprites
{
    public static readonly Dictionary<char, Image> Sprites = new()
    {
        { '1', Resources.grassLeft },
        { '2', Resources.grassMiddle },
        { '3', Resources.grassRight },
        { '4', Resources.middleLeft },
        { '5', Resources.middleMiddle },
        { '6', Resources.middleRight },
        { '7', Resources.bottomLeft },
        { '8', Resources.bottomMiddle },
        { '9', Resources.bottomRight },
        { '+', Resources.grassDownLeft },
        { '-', Resources.grassDownMiddle },
        { '=', Resources.grassDownRight },
        { '*', Resources.downRight },
        { ':', Resources.upRight },
        { ';', Resources.upLeft },
        { '/', Resources.downLeft },
        { 'C', Resources.Coin }
    };
}
