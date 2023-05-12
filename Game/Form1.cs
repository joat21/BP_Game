using System.Drawing.Drawing2D;
using Game.Model;

namespace Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer
                | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.UserPaint, true);

            DoubleBuffered = true;
            Model.Game.Initialize();

            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 25;
            timer.Tick += new EventHandler(Update);
            timer.Start();
        }

        private void Update(object sender, EventArgs e)
        {
            Model.Game.State.Player.Update();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var graphics = e.Graphics;
            graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            graphics.PixelOffsetMode = PixelOffsetMode.Half;

            foreach (var tile in Model.Game.State.Level.Tiles)
                if (tile != null)
                    graphics.DrawImage(tile.Sprite, tile.DrawingArea);

            graphics.DrawImage(Model.Game.State.Player.Sprite, Model.Game.State.Player.DrawingArea);
        }
    }
}