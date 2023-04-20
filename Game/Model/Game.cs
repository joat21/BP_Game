using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model
{
    class Game
    {
        public static GameState State { get; set; }
        // gameState
    }

    class Player
    {
        public float Speed { get; set; }
        public float JumpForce { get; set; }
        // image
        // speed
        // jumpForce
    }

    class Tile
    {
        public Point Position { get; set; }
        // image
        // position
    }

    class Level
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Tile[,] Tiles { get; set; }
        // size
        // tiles
        // interactive objects: coin, trap # возможно стоит все объекты внести в tiles
        // enemies
    }

    class Coin
    {
        // image
    }

    class Trap
    {
        // image
    }

    class Enemy
    {
        // image
    }

    class GameState
    {
        public Level Level { get; set; }
        public Player Player { get; set; }
        // level
        // player
    }
}
