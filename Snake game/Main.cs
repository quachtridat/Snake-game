using System;
using System.Drawing;
using System.Windows.Forms;
using static Snake_game.Constants;

namespace Snake_game {
    public partial class Main : Form {
        #region Object instances
        private Snake _snake;
        private SnakeGameManager _core;
        #endregion

        #region Constructor
        public Main() {
            InitializeComponent();
        }
        #endregion

        #region Event handlers
        private void Main_Load(object sender, EventArgs e) {
            picCanvas.BackColor = Color.FromArgb(CELL_COLOR_R, CELL_COLOR_G, CELL_COLOR_B);
            picCanvas.Enabled = false;
            lblScore.Text = 0.ToString();
            lblDirection.Text = Direction.None.ToString();
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e) {
            picCanvas.Enabled = true;
            if (lblDirection.Text.Equals(Direction.None.ToString())) StartNewGame();
        }
        private void Main_KeyDown(object sender, KeyEventArgs e) => _core.SetKeyInput(e.KeyCode);
        #endregion

        #region Methods
        private void StartNewGame() {
            _snake = new Snake(new Point(DEFAULT_SNAKE_LOCATION_X, DEFAULT_SNAKE_LOCATION_Y), DEFAULT_SNAKE_DIRECTION);
            _core = new SnakeGameManager(picCanvas, _snake, UPDATE_INTERVAL) {
                ChangeDirectionLabel = UpdateCurrentDirection,
                ChangeScore = UpdateScore
            };
            _core.Start();
        }
        private void UpdateCurrentDirection(Direction dir) => lblDirection.Text = dir.ToString();
        private void UpdateScore(int score) => lblScore.Text = score.ToString();
        #endregion
    }
}
