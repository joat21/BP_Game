namespace Game.Model;

public class Game
{
    public static GameState State { get; set; }
    public static int TileSize { get => 96; }

    public static void Initialize()
    {
        State = new GameState();
        var path = "D:\\CSharpProjects\\Game\\Game\\Levels\\Level1.txt";
        State.Player = new Player(Resources.reaper);
        State.Level = Level.Load(path);
    }
}

//class Trap
//{
//    // image
//}

//class Enemy
//{
//    // image
//}