using System;
using System.Drawing;
using System.Windows.Forms;
using static Snake_game.Settings;

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
            picCanvas.BackColor = Color.FromArgb(CellColorR, CellColorG, CellColorB);
            picCanvas.Enabled = false;
            lblScore.Text = 0.ToString();
            lblDirection.Text = Direction.None.ToString();
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e) {
            picCanvas.Enabled = true;
            if (_core?.Snake == null) StartNewGame();
        }
        private void Main_KeyDown(object sender, KeyEventArgs e) => _core?.SetKeyInput(e.KeyCode);
        #endregion

        #region Methods
        private void StartNewGame() {
            _snake = new Snake(new Point(DefaultSnakeLocationX, DefaultSnakeLocationY), DefaultSnakeDirection);
            _core = new SnakeGameManager(picCanvas, _snake, UpdateInterval) {
                ChangeDirectionLabel = UpdateCurrentDirection,
                ChangeScore = UpdateScore
            };
            _core.Start();
        }
        private void UpdateCurrentDirection(Direction dir) => lblDirection.Text = dir.ToString();
        private void UpdateScore(int score) => lblScore.Text = score.ToString();
        #endregion

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (_core?.Snake == null) {
                new Settings().ShowDialog();
                picCanvas.BackColor = Color.FromArgb(CellColorR, CellColorG, CellColorB);
            }
        }
    }
}
