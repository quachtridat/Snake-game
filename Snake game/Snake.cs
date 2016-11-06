namespace Snake_game {
    using System.Collections.Generic;
    using System.Drawing;
    public class Snake : System.IDisposable {
        #region Variables
        private Point _head;
        private readonly List<Point> _body;
        #endregion

        #region Constructor
        public Snake(Point headPoint, Settings.Direction direction) {
            HeadPoint = headPoint;
            _body = new List<Point>();
            GenerateBody(direction);
        }
        #endregion

        #region Methods
        private void GenerateBody(Settings.Direction direction) {
            switch (direction) {
                    case Settings.Direction.Left:
                    // Generate body to the right
                    for (int i = 0; i < Settings.DefaultSnakeLength - 1; ++i)
                        _body.Add(new Point(HeadPoint.X + (i + 1), HeadPoint.Y));
                    break;
                case Settings.Direction.Right:
                    // Generate body to the left
                    for (int i = 0; i < Settings.DefaultSnakeLength - 1; ++i)
                        _body.Add(new Point(HeadPoint.X - (i + 1), HeadPoint.Y));
                    break;
                case Settings.Direction.Up:
                    // Generate body down
                    for (int i = 0; i < Settings.DefaultSnakeLength - 1; ++i)
                        _body.Add(new Point(HeadPoint.X, HeadPoint.Y + (i + 1)));
                    break;
                case Settings.Direction.Down:
                    // Generate body up
                    for (int i = 0; i < Settings.DefaultSnakeLength - 1; ++i)
                        _body.Add(new Point(HeadPoint.X, HeadPoint.Y - (i + 1)));
                    break;
            }
        }
        public void UpdateSnake(bool[,] map = null) {
            if (map != null)
                try { map[TailTile.X, TailTile.Y] = false; } 
                catch { /* ignored */}

            Point tmp1 = HeadPoint;
            switch (MovingDirection) {
                    case Settings.Direction.Left:
                    // Shift the snake to the left
                    _head.X -= Settings.CellSize;
                    break;
                case Settings.Direction.Right:
                    // Shift the snake to the right
                    _head.X += Settings.CellSize;
                    break;
                case Settings.Direction.Up:
                    // Shift the snake up
                    _head.Y -= Settings.CellSize;
                    break;
                case Settings.Direction.Down:
                    // Shift the snake down
                    _head.Y += Settings.CellSize;
                    break;
            }
            for (int i = 0; i < BodyPoints.Length; ++i) {
                Point tmp2 = BodyPoints[i];
                _body[i] = tmp1;
                tmp1 = tmp2;
            }
        }
        public void LengthenBody(int value) {
            while (value-- > 0)
                switch (MovingDirection) {
                    case Settings.Direction.Left:
                        _body.Add(new Point(TailPoint.X + 1 * Settings.CellSize, TailPoint.Y));
                        break;

                    case Settings.Direction.Right:
                        _body.Add(new Point(TailPoint.X - 1 * Settings.CellSize, TailPoint.Y));
                        break;

                    case Settings.Direction.Up:
                        _body.Add(new Point(TailPoint.X, 1 * Settings.CellSize + TailPoint.Y));
                        break;

                    case Settings.Direction.Down:
                        _body.Add(new Point(TailPoint.X, - 1 * Settings.CellSize + TailPoint.Y));
                        break;
                }
        }
        public void Dispose() {
            _body.Clear();
        }
        #endregion

        #region Properties
        public Point HeadPoint {
            get { return _head; }
            set { _head = value; }
        }
        public Point HeadTile {
            get { return new Point(HeadPoint.X / Settings.CellSize, HeadPoint.Y / Settings.CellSize);}
            set { HeadPoint = new Point(value.X * Settings.CellSize, value.Y * Settings.CellSize);}
        }
        public Point[] BodyPoints {
            get { return _body.ToArray(); }
            set {
                _body.Clear();
                _body.AddRange(value);
            }
        }
        public Point[] BodyTiles {
            get {
                Point[] body = BodyPoints;
                System.Array.ForEach(body, point => {
                                               point.X /= Settings.CellSize;
                                               point.Y /= Settings.CellSize;
                                           });
                return body;
            }
            set {
                Point[] body = value;
                System.Array.ForEach(body, point => {
                                               point.X *= Settings.CellSize;
                                               point.Y *= Settings.CellSize;
                                           });
                BodyPoints = body;
            }
        }
        public Point TailPoint {
            get { return BodyPoints.Length > 0 ? BodyPoints[BodyPoints.Length - 1] : HeadPoint; }
            set {
                if (BodyPoints.Length > 0) _body[BodyPoints.Length - 1] = value;
                else HeadPoint = value;
            }
        }
        public Point TailTile {
            get { return new Point(TailPoint.X / Settings.CellSize, TailPoint.Y / Settings.CellSize); }
            set { TailPoint = new Point(value.X * Settings.CellSize, value.Y * Settings.CellSize); }
        }
        public Settings.Direction MovingDirection { get; set; } = Settings.DefaultSnakeDirection;
        #endregion
    }
}
