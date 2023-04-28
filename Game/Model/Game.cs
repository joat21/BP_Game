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

        public static void Initialize()
        {
            State = new GameState();
            var path = "";
            State.Level = Level.Load(path);
            State.Player = new Player(new PointF(1, 1));
        }
        // gameState
        // initialization
    }

    //class Coin
    //{
    //    // image
    //}

    //class Trap
    //{
    //    // image
    //}

    //class Enemy
    //{
    //    // image
    //}
}
