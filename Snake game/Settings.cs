using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_game {
    public partial class Settings : Form {
        #region Fields

        public enum Direction { None, Up, Down, Left, Right }

        public static int UpdateInterval = 200;
        public static int MaxScore = 0;

        #region Playfield

        public const int PLAYFIELD_WIDTH = 600;
        public const int PLAYFIELD_HEIGHT = 600;

        public static int CellSize = 15;

        public static int CellColorR = 255;
        public static int CellColorG = 255;
        public static int CellColorB = 255;

        #endregion

        #region Snake

        public static int DefaultSnakeLength = 3; // Must be greater than 1
        public static Direction DefaultSnakeDirection = Direction.Right;
        public static int DefaultSnakeLocationX = 0;
        public static int DefaultSnakeLocationY = 0;

        public static int SnakeHeadColorR = 0;
        public static int SnakeHeadColorG = 255;
        public static int SnakeHeadColorB = 0;

        public static int SnakeBodyColorR = 0;
        public static int SnakeBodyColorG = 128;
        public static int SnakeBodyColorB = 0;

        public static int SnakeHeadLoseColorR = 128;
        public static int SnakeHeadLoseColorG = 0;
        public static int SnakeHeadLoseColorB = 128;
        #endregion

        #region Food

        public static int FoodColorR = 255;
        public static int FoodColorG = 0;
        public static int FoodColorB = 0;

        public static int FoodScore = 1;

        #endregion
        #endregion

        #region Constructor
        public Settings() {
            InitializeComponent();
        }
        #endregion

        #region Event handlers
        private void Settings_Load(object sender, EventArgs e) {
            LoadGameSettings();
            numDefSpawnX.Maximum = PLAYFIELD_WIDTH / (decimal) CellSize;
            numDefSpawnY.Maximum = PLAYFIELD_HEIGHT / (decimal) CellSize;
        }
        private void radCustomSpeed_CheckedChanged(object sender, EventArgs e) {
            numSnakeSpeed.Visible = numSnakeSpeed.Enabled = ((RadioButton)sender).Checked;
        }
        private void btnChangeColor_Click(object sender, EventArgs e) {
            colorDiag.Reset();
            if (colorDiag.ShowDialog() == DialogResult.OK) {
                ((Button)sender).BackColor = colorDiag.Color;
                ((Button)sender).FlatAppearance.MouseDownBackColor
                    = ((Button)sender).FlatAppearance.MouseOverBackColor
                    = ((Button)sender).BackColor;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e) => Close();
        private void btnSave_Click(object sender, EventArgs e) {
            Save();
            Close();
        }
        #endregion

        #region Methods
        private void LoadGameSettings() {
            int size = CellSize;
            int speed = UpdateInterval;
            int score = FoodScore;
            int max = MaxScore;

            Color backColor = Color.FromArgb(CellColorR, CellColorG, CellColorB);
            Color headColor = Color.FromArgb(SnakeHeadColorR, SnakeHeadColorG, SnakeHeadColorB);
            Color bodyColor = Color.FromArgb(SnakeBodyColorR, SnakeBodyColorG, SnakeBodyColorB);
            Color foodColor = Color.FromArgb(FoodColorR, FoodColorG, FoodColorB);
            Color headLoseColor = Color.FromArgb(SnakeHeadLoseColorR, SnakeHeadLoseColorG, SnakeHeadLoseColorB);

            int defaultLength = DefaultSnakeLength;
            Direction defaultDirection = DefaultSnakeDirection;
            Point defaultSpawnPoint = new Point(DefaultSnakeLocationX, DefaultSnakeLocationY);

            LoadSizeSetting(size);
            LoadSpeedSetting(speed);
            LoadFoodScoreSetting(score);
            LoadMaxScoreSetting(max);
            LoadColorSettings(backColor, headColor, bodyColor, foodColor, headLoseColor);
            LoadDefaultSettings(defaultLength, defaultDirection, defaultSpawnPoint);
        }
        private void LoadSizeSetting(int size) {
            switch (size) {
                case 1:
                    radImpossibleSize.Checked = true;
                    break;
                case 5:
                    radTinySize.Checked = true;
                    break;
                case 10:
                    radSmallSize.Checked = true;
                    break;
                case 15:
                    radNormalSpeed.Checked = true;
                    break;
                case 20:
                    radBigSize.Checked = true;
                    break;
                case 30:
                    radVeryBigSize.Checked = true;
                    break;
                case 60:
                    radUltraBigSize.Checked = true;
                    break;
            }
        }
        private void LoadSpeedSetting(int speed) {
            switch (speed) {
                case 10:
                    radFastestSpeed.Checked = true;
                    break;
                case 50:
                    radFasterSpeed.Checked = true;
                    break;
                case 100:
                    radFastSpeed.Checked = true;
                    break;
                case 200:
                    radNormalSpeed.Checked = true;
                    break;
                case 500:
                    radSlowSpeed.Checked = true;
                    break;
                case 1000:
                    radSlowerSpeed.Checked = true;
                    break;
                case 3000:
                    radSlowestSpeed.Checked = true;
                    break;
                default:
                    radCustomSpeed.Checked = true;
                    numSnakeSpeed.Value = numSnakeSpeed.Minimum;
                    if (speed/100f < 0) numSnakeSpeed.Value = (decimal)speed/100;
                    if (speed/100f > (float)numSnakeSpeed.Maximum) numSnakeSpeed.Value = numSnakeSpeed.Maximum;
                    break;
            }
        }
        private void LoadFoodScoreSetting(int score) => numFoodScore.Value = score;
        private void LoadMaxScoreSetting(int score) => numMaxScore.Value = score;
        private void LoadColorSettings(Color background, Color head, Color body, Color food, Color headLose) {
            btnBackColor.BackColor = background;
            btnBackColor.FlatAppearance.MouseDownBackColor
                = btnBackColor.FlatAppearance.MouseOverBackColor 
                = btnBackColor.BackColor;

            btnSnakeHeadColor.BackColor = head;
            btnSnakeHeadColor.FlatAppearance.MouseDownBackColor
                = btnSnakeHeadColor.FlatAppearance.MouseOverBackColor
                = btnSnakeHeadColor.BackColor;

            btnSnakeBodyColor.BackColor = body;
            btnSnakeBodyColor.FlatAppearance.MouseDownBackColor
                = btnSnakeBodyColor.FlatAppearance.MouseOverBackColor
                = btnSnakeBodyColor.BackColor;

            btnFoodColor.BackColor = food;
            btnFoodColor.FlatAppearance.MouseDownBackColor
                = btnFoodColor.FlatAppearance.MouseOverBackColor
                = btnFoodColor.BackColor;

            btnSnakeHeadLoseColor.BackColor = headLose;
            btnSnakeHeadLoseColor.FlatAppearance.MouseDownBackColor
                = btnSnakeHeadLoseColor.FlatAppearance.MouseOverBackColor
                = btnSnakeHeadLoseColor.BackColor;
        }
        private void LoadDefaultSettings(int snakeLength, Direction snakeDirection, Point spawnPoint) {
            numDefSnakeLength.Value = snakeLength;
            numDefSpawnX.Value = (decimal)spawnPoint.X / CellSize + 1;
            numDefSpawnY.Value = (decimal)spawnPoint.Y / CellSize + 1;

            switch (snakeDirection) {
                case Direction.None:
                    throw new ArgumentException(@"Default snake direction cannot be none!");
                case Direction.Up:
                case Direction.Down:
                case Direction.Left:
                case Direction.Right:
                    cboxDefSnakeDir.SelectedItem = snakeDirection.ToString();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(snakeDirection), snakeDirection, null);
            }
        }
        private void Save() {
            SetSizeSetting();
            SetSpeedSetting();
            SetFoodScoreSetting();
            SetMaxScoreSetting();
            SetColorSettings();
            SetDefaultSettings();
        }
        private void SetSizeSetting() {
            if (radImpossibleSize.Checked) CellSize = 1;
            else if (radTinySize.Checked) CellSize = 5;
            else if (radSmallSize.Checked) CellSize = 10;
            else if (radNormalSpeed.Checked) CellSize = 15;
            else if (radBigSize.Checked) CellSize = 20;
            else if (radVeryBigSize.Checked) CellSize = 30;
            else if (radUltraBigSize.Checked) CellSize = 60;
        }
        private void SetSpeedSetting() {
            if (radFastestSpeed.Checked) UpdateInterval = 10;
            else if (radFasterSpeed.Checked) UpdateInterval = 50;
            else if (radFasterSpeed.Checked) UpdateInterval = 100;
            else if (radFasterSpeed.Checked) UpdateInterval = 200;
            else if (radFasterSpeed.Checked) UpdateInterval = 500;
            else if (radFasterSpeed.Checked) UpdateInterval = 1000;
            else if (radFasterSpeed.Checked) UpdateInterval = 3000;
            else if (radFasterSpeed.Checked) UpdateInterval = (int)numSnakeSpeed.Value * 100;
        }
        private void SetFoodScoreSetting() => FoodScore = (int)numFoodScore.Value;
        private void SetMaxScoreSetting() => MaxScore = (int)numMaxScore.Value;
        private void SetColorSettings() {
            CellColorR = btnBackColor.BackColor.R;
            CellColorG = btnBackColor.BackColor.G;
            CellColorB = btnBackColor.BackColor.B;

            SnakeHeadColorR = btnSnakeHeadColor.BackColor.R;
            SnakeHeadColorG = btnSnakeHeadColor.BackColor.G;
            SnakeHeadColorB = btnSnakeHeadColor.BackColor.B;

            SnakeBodyColorR = btnSnakeBodyColor.BackColor.R;
            SnakeBodyColorG = btnSnakeBodyColor.BackColor.G;
            SnakeBodyColorB = btnSnakeBodyColor.BackColor.B;

            FoodColorR = btnFoodColor.BackColor.R;
            FoodColorG = btnFoodColor.BackColor.G;
            FoodColorB = btnFoodColor.BackColor.B;

            SnakeHeadLoseColorR = btnSnakeHeadLoseColor.BackColor.R;
            SnakeHeadLoseColorG = btnSnakeHeadLoseColor.BackColor.G;
            SnakeHeadLoseColorB = btnSnakeHeadLoseColor.BackColor.B;
        }
        private void SetDefaultSettings() {
            DefaultSnakeLength = (int)numDefSnakeLength.Value;
            DefaultSnakeLocationX = ((int) numDefSpawnX.Value - 1) * CellSize;
            DefaultSnakeLocationY = ((int) numDefSpawnY.Value - 1) * CellSize;

            switch ((string)cboxDefSnakeDir.SelectedItem) {
                case @"Up": DefaultSnakeDirection = Direction.Up; break;
                case @"Down": DefaultSnakeDirection = Direction.Down; break;
                case @"Left": DefaultSnakeDirection = Direction.Left; break;
                case @"Right": DefaultSnakeDirection = Direction.Right; break;
            }
        }
        #endregion
    }
}