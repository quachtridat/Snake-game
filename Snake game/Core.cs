using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_game {
    using static Settings;
    internal class SnakeGameManager : IDisposable {
        #region Delegates
        public delegate void ChangeDirectionLabelDelegate(Direction dir);
        public delegate void ChangeCurrentScoreDelegate(int score);
        #endregion

        #region Fields
        private Color _cellColor, _snakeHeadColor, _snakeBodyColor, _foodColor, _snakeHeadLoseColor;
        private Brush _cellBrush, _snakeHeadBrush, _snakeBodyBrush, _foodBrush, _snakeHeadLoseBrush;
        private int _width, _height;
        private static Keys _keyPressed;
        #endregion

        #region Constructor
        public SnakeGameManager(PictureBox playfield, Snake snake, int updateInterval) {
            Playfield = playfield;
            Snake = snake;
            Timer.Interval = updateInterval;
            Timer.Tick += delegate { SetSnakeDirection(); };

            Initialize();
        }
        #endregion

        #region Properties
        public PictureBox Playfield { get; }
        private bool[,] Map { get; set; }
        public Snake Snake { get; private set; }
        private Timer Timer { get; } = new Timer();
        public Point CurrentFoodPoint { get; private set; }
        public int CurrentScore { get; private set; }
        internal ChangeDirectionLabelDelegate ChangeDirectionLabel { get; set; }
        internal ChangeCurrentScoreDelegate ChangeScore { get; set; }
        #endregion

        #region Initialization
        private void Initialize() {
            _width = Playfield.Width;
            _height = Playfield.Height;
            _keyPressed = Keys.None;
            CurrentScore = 0;

            SetLocalColors();
            SetLocalBrushes();
            GenerateMap();
        }
        private void SetLocalColors() {
            _cellColor = Color.FromArgb(CellColorR, CellColorG, CellColorB);
            _snakeHeadColor = Color.FromArgb(SnakeHeadColorR, SnakeHeadColorG, SnakeBodyColorB);
            _snakeBodyColor = Color.FromArgb(SnakeBodyColorR, SnakeBodyColorG, SnakeBodyColorB);
            _foodColor = Color.FromArgb(FoodColorR, FoodColorG, FoodColorB);
            _snakeHeadLoseColor = Color.FromArgb(SnakeHeadLoseColorR, SnakeHeadLoseColorG, SnakeHeadLoseColorB);
        }
        private void SetLocalBrushes() {
            _cellBrush = new SolidBrush(_cellColor);
            _snakeHeadBrush = new SolidBrush(_snakeHeadColor);
            _snakeBodyBrush = new SolidBrush(_snakeBodyColor);
            _foodBrush = new SolidBrush(_foodColor);
            _snakeHeadLoseBrush = new SolidBrush(_snakeHeadLoseColor);
        }
        private void GenerateMap() {
            Map = new bool[_width / CellSize, _height / CellSize];
        }
        #endregion

        #region Methods
        public void Start() {
            // Add canvas updater
            Playfield.Paint += Update;
            // Start timer
            Timer.Start();
            // Generate food
            GenerateFood();
        }
        public void Update(object sender, PaintEventArgs e) {
            // Update snake
            Snake.UpdateSnake(Map);

            // Fix out of range (when the snake's head is out of play-field)
            FixOutOfRange();

            // Set & set color for body points
            foreach (Point bodyPoint in Snake.BodyPoints)
                e.Graphics.FillRectangle(_snakeBodyBrush, bodyPoint.X, bodyPoint.Y, CellSize, CellSize);

            // Set & set color for head point
            Point head = Snake.HeadPoint;
            e.Graphics.FillRectangle(_snakeHeadBrush, head.X, head.Y, CellSize, CellSize);

            // Check self-bitten (lose condition)
            if (IsSnakeBody(Snake.HeadPoint)) {
                e.Graphics.FillRectangle(_snakeHeadLoseBrush, head.X, head.Y, CellSize, CellSize);
                GameOver(@"GAME OVER!");
                ClearScreen(e.Graphics);
                return;
            }

            // Set true to head's point on the map
            Map[Snake.HeadTile.X, Snake.HeadTile.Y] = true;

            // Set & set color for food point
            e.Graphics.FillRectangle(_foodBrush, CurrentFoodPoint.X, CurrentFoodPoint.Y, CellSize, CellSize);

            // Check if food has been eaten
            if (head == CurrentFoodPoint) {
                Snake.LengthenBody(1);
                
                FixOutOfRange();
                e.Graphics.FillRectangle(_cellBrush, CurrentFoodPoint.X, CurrentFoodPoint.Y, CellSize, CellSize);

                GenerateFood();
                e.Graphics.FillRectangle(_foodBrush, CurrentFoodPoint.X, CurrentFoodPoint.Y, CellSize, CellSize);

                CurrentScore += FoodScore;
                ChangeScore?.Invoke(CurrentScore);
            }

            if (MaxScore > 0 && CurrentScore >= MaxScore) {
                GameOver(@"YOU WIN!");
                ClearScreen(e.Graphics);
                return;
            }
            if (Snake.BodyPoints.Length + 1 == (_width/CellSize)*(_height/CellSize)) GameOver(@"YOU WIN!");
        }
        private void GameOver(string msg) {
            // Stop timer
            Timer.Stop();
            // Show message
            if (MessageBox.Show(msg) == DialogResult.OK) {}
            // Disable canvas updater
            Playfield.Paint -= Update;
            // Disable canvas
            Playfield.Enabled = false;
            // Destroy the snake
            Snake.Dispose();
            // Delete the snake
            Snake = null;
            // Reset score
            CurrentScore = 0;
            // Reset region
            _width = _height = 0;
            // Reset score label (main form)
            ChangeScore(0);
            // Reset direction label (main form)
            ChangeDirectionLabel(Direction.None);
        }
        private void SetSnakeDirection() {
            switch (_keyPressed) {
                case Keys.Left:
                    if (Snake.MovingDirection != Direction.Right) Snake.MovingDirection = Direction.Left;
                    break;
                case Keys.Right:
                    if (Snake.MovingDirection != Direction.Left) Snake.MovingDirection = Direction.Right;
                    break;
                case Keys.Up:
                    if (Snake.MovingDirection != Direction.Down) Snake.MovingDirection = Direction.Up;
                    break;
                case Keys.Down:
                    if (Snake.MovingDirection != Direction.Up) Snake.MovingDirection = Direction.Down;
                    break;
            }
            ChangeDirectionLabel?.Invoke(Snake.MovingDirection);
            _keyPressed = Keys.None;
            Playfield.Invalidate();
        }
        /// <summary>
        /// Relocate the snake when it goes out of the play-field.
        /// </summary>
        private void FixOutOfRange() {
            Point fix = new Point(Snake.HeadPoint.X, Snake.HeadPoint.Y);
            if (fix.X < 0 || fix.Y < 0 || fix.X >= _width || fix.Y >= _height) {
                if (fix.X < 0) // Go beyond the left wall
                    fix.X = _width - CellSize * Math.Abs(fix.X / CellSize);
                else if (fix.Y < 0) // Go beyond the top wall
                    fix.Y = _height - CellSize * Math.Abs(fix.Y / CellSize);
                else if (fix.X >= _width) // Go beyond the right wall
                    fix.X = (Math.Abs((fix.X - _width) / CellSize) - 1) * CellSize;
                else if (fix.Y >= _height) // Go beyond the bottom wall
                    fix.Y = (Math.Abs((fix.Y - _height) / CellSize) - 1) * CellSize;
                Snake.HeadPoint = fix;
                Snake.UpdateSnake(Map);
            }
        }
        private void GenerateFood() {
            Random rnd = new Random();
            int x, y;

            do {
                x = rnd.Next(_width/CellSize);
                y = rnd.Next(_height/CellSize);

                CurrentFoodPoint = new Point(x*CellSize, y*CellSize);
            } while (IsSnakeBody(new Point(x, y))); 
        }
        private bool IsSnakeBody(Point point) => Map[point.X / CellSize, point.Y / CellSize];
        public void SetKeyInput(Keys key) {
            if (_keyPressed == Keys.None) _keyPressed = key;
        }

        public void ClearScreen(Graphics g) => g?.FillRectangle(_cellBrush, Playfield.DisplayRectangle);
        public void Dispose() {
            _cellColor = _snakeHeadColor = _snakeBodyColor = _foodColor = _snakeHeadLoseColor = Color.Empty;

            _cellBrush?.Dispose();
            _snakeHeadBrush?.Dispose();
            _snakeBodyBrush?.Dispose();
            _foodBrush?.Dispose();
            _snakeHeadLoseBrush?.Dispose();

            _keyPressed = Keys.None;

            Map = null;
            Snake?.Dispose();
            Timer?.Dispose();
            CurrentFoodPoint = Point.Empty;
            ChangeDirectionLabel = null;
            ChangeScore = null;
        }
        #endregion
    }
}

