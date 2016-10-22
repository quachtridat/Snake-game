namespace Snake_game {
    public static class Constants {
        public enum Direction { None, Up, Down, Left, Right }

        public const int UPDATE_INTERVAL = 50; // milliseconds

        #region Playfield
        public const int PLAYFIELD_WIDTH = 600;
        public const int PLAYFIELD_HEIGHT = 600;

        public const int CELL_WIDTH = 15;
        public const int CELL_HEIGHT = 15;

        public const int CELL_COLOR_R = 255;
        public const int CELL_COLOR_G = 255;
        public const int CELL_COLOR_B = 255;
        #endregion

        #region Snake
        public const int DEFAULT_SNAKE_LENGTH = 3; // Must be greater than 1
        public const Direction DEFAULT_SNAKE_DIRECTION = Direction.Right;
        public const int DEFAULT_SNAKE_LOCATION_X = 0;
        public const int DEFAULT_SNAKE_LOCATION_Y = 0;

        public const int SNAKE_HEAD_COLOR_R = 0;
        public const int SNAKE_HEAD_COLOR_G = 255;
        public const int SNAKE_HEAD_COLOR_B = 0;

        public const int SNAKE_BODY_COLOR_R = 0;
        public const int SNAKE_BODY_COLOR_G = 128;
        public const int SNAKE_BODY_COLOR_B = 0;
        #endregion

        #region Food

        public const int FOOD_COLOR_R = 255;
        public const int FOOD_COLOR_G = 0;
        public const int FOOD_COLOR_B = 0;

        #endregion
    }
}
