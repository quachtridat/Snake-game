using System.Collections.Generic;
using System.Drawing;

namespace Snake_game {
    public class Snake {
        #region Variables
        private Point _head;
        private readonly List<Point> _body;
        #endregion

        #region Constructor
        public Snake(Point headPoint, Constants.Direction direction) {
            HeadPoint = headPoint;
            _body = new List<Point>();
            GenerateBody(direction);
        }
        #endregion

        #region Methods
        private void GenerateBody(Constants.Direction direction) {
            switch (direction) {
                    case Constants.Direction.Left:
                    // Generate body to the right
                    for (int i = 0; i < Constants.DEFAULT_SNAKE_LENGTH - 1; ++i)
                        _body.Add(new Point(HeadPoint.X + (i + 1), HeadPoint.Y));
                    break;
                case Constants.Direction.Right:
                    // Generate body to the left
                    for (int i = 0; i < Constants.DEFAULT_SNAKE_LENGTH - 1; ++i)
                        _body.Add(new Point(HeadPoint.X - (i + 1), HeadPoint.Y));
                    break;
                case Constants.Direction.Up:
                    // Generate body down
                    for (int i = 0; i < Constants.DEFAULT_SNAKE_LENGTH - 1; ++i)
                        _body.Add(new Point(HeadPoint.X, HeadPoint.Y + (i + 1)));
                    break;
                case Constants.Direction.Down:
                    // Generate body up
                    for (int i = 0; i < Constants.DEFAULT_SNAKE_LENGTH - 1; ++i)
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
                    case Constants.Direction.Left:
                    // Shift the snake to the left
                    _head.X -= Constants.CELL_WIDTH;
                    break;
                case Constants.Direction.Right:
                    // Shift the snake to the right
                    _head.X += Constants.CELL_WIDTH;
                    break;
                case Constants.Direction.Up:
                    // Shift the snake up
                    _head.Y -= Constants.CELL_HEIGHT;
                    break;
                case Constants.Direction.Down:
                    // Shift the snake down
                    _head.Y += Constants.CELL_HEIGHT;
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
                    case Constants.Direction.Left:
                        _body.Add(new Point(TailPoint.X + 1 * Constants.CELL_WIDTH, TailPoint.Y));
                        break;

                    case Constants.Direction.Right:
                        _body.Add(new Point(TailPoint.X - 1 * Constants.CELL_WIDTH, TailPoint.Y));
                        break;

                    case Constants.Direction.Up:
                        _body.Add(new Point(TailPoint.X, 1 * Constants.CELL_HEIGHT + TailPoint.Y));
                        break;

                    case Constants.Direction.Down:
                        _body.Add(new Point(TailPoint.X, - 1 * Constants.CELL_HEIGHT + TailPoint.Y));
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
            get { return new Point(HeadPoint.X / Constants.CELL_WIDTH, HeadPoint.Y / Constants.CELL_HEIGHT);}
            set { HeadPoint = new Point(value.X * Constants.CELL_WIDTH, value.Y * Constants.CELL_HEIGHT);}
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
                                               point.X /= Constants.CELL_WIDTH;
                                               point.Y /= Constants.CELL_HEIGHT;
                                           });
                return body;
            }
            set {
                Point[] body = value;
                System.Array.ForEach(body, point => {
                    point.X *= Constants.CELL_WIDTH;
                    point.Y *= Constants.CELL_HEIGHT;
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
            get { return new Point(TailPoint.X / Constants.CELL_WIDTH, TailPoint.Y / Constants.CELL_HEIGHT); }
            set { TailPoint = new Point(value.X * Constants.CELL_WIDTH, value.Y * Constants.CELL_HEIGHT); }
        }
        public Constants.Direction MovingDirection { get; set; } = Constants.DEFAULT_SNAKE_DIRECTION;
        #endregion
    }
}
