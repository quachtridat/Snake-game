using System;
using System.Drawing;
using System.Windows.Forms;
using static Snake_game.Constants;

namespace Snake_game {
    internal class SnakeGameManager {
        #region Delegates
        public delegate void ChangeDirectionLabelDelegate(Direction dir);
        public delegate void ChangeCurrentScoreDelegate(int score);
        #endregion

        #region Fields
        private Color _cellColor, _snakeHeadColor, _snakeBodyColor, _foodColor;
        private Brush _cellBrush, _snakeHeadBrush, _snakeBodyBrush, _foodBrush;
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
        }
        private void SetLocalColors() {
            _cellColor = Color.FromArgb(CELL_COLOR_R, CELL_COLOR_G, CELL_COLOR_B);
            _snakeHeadColor = Color.FromArgb(SNAKE_HEAD_COLOR_R, SNAKE_HEAD_COLOR_G, SNAKE_BODY_COLOR_B);
            _snakeBodyColor = Color.FromArgb(SNAKE_BODY_COLOR_R, SNAKE_BODY_COLOR_G, SNAKE_BODY_COLOR_B);
            _foodColor = Color.FromArgb(FOOD_COLOR_R, FOOD_COLOR_G, FOOD_COLOR_B);
        }
        private void SetLocalBrushes() {
            _cellBrush = new SolidBrush(_cellColor);
            _snakeHeadBrush = new SolidBrush(_snakeHeadColor);
            _snakeBodyBrush = new SolidBrush(_snakeBodyColor);
            _foodBrush = new SolidBrush(_foodColor);
        }
        #endregion

        #region Methods
        public void Start() {
            Playfield.Paint += Update;
            Timer.Start();
            GenerateFood();   
        }

        public void Update(object sender, PaintEventArgs e) {
            // Delete tail point          
            Point tail = Snake.TailPoint;
            e.Graphics.FillRectangle(_cellBrush, tail.X, tail.Y, CELL_WIDTH, CELL_HEIGHT);

            Snake.UpdateSnake();

            // Fix out of range (when the snake is out of canvas)
            FixOutOfRange();

            // Check self-bitten (lose condition)
            if (IsSelfBitten()) {
                e.Graphics.FillRectangle(_cellBrush, Playfield.DisplayRectangle);
                Lose();
                return;
            }

            // Set & set color for head point
            Point head = Snake.HeadPoint;
            e.Graphics.FillRectangle(_snakeHeadBrush, head.X, head.Y, CELL_WIDTH, CELL_HEIGHT);

            // Set & set color for body points
            foreach (Point bodyPoint in Snake.BodyPoints)
                e.Graphics.FillRectangle(_snakeBodyBrush, bodyPoint.X, bodyPoint.Y, CELL_WIDTH, CELL_HEIGHT);

            // Set & set color for food point
            e.Graphics.FillRectangle(_foodBrush, CurrentFoodPoint.X, CurrentFoodPoint.Y, CELL_WIDTH, CELL_HEIGHT);

            // Check if food has been eaten
            if (head == CurrentFoodPoint) {
                Snake.LengthenBody(1);
                
                FixOutOfRange();
                e.Graphics.FillRectangle(_cellBrush, CurrentFoodPoint.X, CurrentFoodPoint.Y, CELL_WIDTH, CELL_HEIGHT);

                GenerateFood();
                e.Graphics.FillRectangle(_foodBrush, CurrentFoodPoint.X, CurrentFoodPoint.Y, CELL_WIDTH, CELL_HEIGHT);

                CurrentScore++;
                ChangeScore?.Invoke(CurrentScore);
            }
        }

        private void Lose() {
            Timer.Stop();
            if (MessageBox.Show(@"GAME OVER!") == DialogResult.OK) {}
            Playfield.Paint -= Update;
            Snake.Dispose();
            Snake = null;
            CurrentScore = 0;
            _width = _height = 0;
            ChangeScore(0);
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

        private void FixOutOfRange() {
            Point head = Snake.HeadPoint;
            
            if (head.X < 0 || head.Y < 0 || head.X >= _width || head.Y >= _height) {
                Point fix = new Point(head.X, head.Y);
                if (fix.X < 0) fix.X = _width - CELL_WIDTH * Math.Abs(fix.X / CELL_WIDTH);
                else if (fix.Y < 0) fix.Y = _height - CELL_HEIGHT * Math.Abs(fix.Y / CELL_HEIGHT);
                else if (fix.X >= _width) fix.X = (Math.Abs((fix.X - _width) / CELL_WIDTH) - 1) * CELL_WIDTH;
                else if (fix.Y >= _height) fix.Y = (Math.Abs((fix.Y - _height) / CELL_HEIGHT) - 1) * CELL_HEIGHT;

                Snake.HeadPoint = fix;
                Snake.UpdateSnake();
            }
        }

        private void GenerateFood() {
            Random rnd = new Random();

            int x = rnd.Next(_width / CELL_WIDTH);
            int y = rnd.Next(_height/CELL_HEIGHT);

            CurrentFoodPoint = new Point(x*CELL_WIDTH, y*CELL_HEIGHT);
        }

        private bool IsSelfBitten() {
            if (Snake.BodyPoints.Length < 4) return false;
            foreach (Point bodyPoint in Snake.BodyPoints)
                if (bodyPoint == Snake.HeadPoint) return true;
            return false;
        }

        public void SetKeyInput(Keys key) {
            if (_keyPressed == Keys.None) _keyPressed = key;
        }
        #endregion
    }
}

