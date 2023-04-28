namespace Game.Model
{
    class Player
    {
        public PointF Position { get; set; }
        public Image Sprite { get; set; }
        public float Speed { get; set; }
        public float JumpForce { get; set; }

        public Player(PointF position)
        {
            Position = position;
        }
    }
}
