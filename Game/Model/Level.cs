namespace Game.Model
{
    class Level
    {
        private static readonly Dictionary<char, Image> tileSprites = new()
        {
            { '#', Resources.tile },
            { '/', Resources.tile }
        };

        public int Width { get; set; }
        public int Height { get; set; }
        public List<Tile> Tiles { get; set; }

        public static Level Load(string path)
        {
            var level = new Level();
            var lines = File.ReadAllLines(path);

            level.Width = lines[0].Length;
            level.Height = lines.Length;
            //level.Tiles = new Tile[level.Width, level.Height];

            for (var y = 0; y < level.Height; y++)
                for (var x = 0; x < level.Width; x++)
                    level.Tiles.Add(new Tile(tileSprites[lines[x][y]], new Point(x, y)));

            return level;
        }
        // size
        // tiles
        // interactive objects: coin, trap # возможно стоит все объекты внести в tiles
        // enemies
    }
}
