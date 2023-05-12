namespace Game.Model;

public class Level
{
    public int Width { get; set; }
    public int Height { get; set; }
    public Tile[,] Tiles { get; set; }

    public static Level Load(string path)
    {
        var level = new Level();
        var lines = File.ReadAllLines(path);
        level.Width = lines[0].Length;
        level.Height = lines.Length;

        level.Tiles = new Tile[level.Width, level.Height];

        for (var y = 0; y < level.Height; y++)
            for (var x = 0; x < level.Width; x++)
            {
                if (TileSprites.Sprites.ContainsKey(lines[y][x]))
                    level.Tiles[x, y] = new Tile(TileSprites.Sprites[lines[y][x]], new Point(x, y));

                switch (lines[y][x])
                {
                    case 'C':
                        level.Tiles[x, y] = new Coin(Coin.Sprite, new Point(x, y));
                        break;
                    case 'P':
                        Game.State.Player.Position = new Point(x * Game.TileSize, y * Game.TileSize);
                        break;
                        //
                }
            }

        return level;
    }
}