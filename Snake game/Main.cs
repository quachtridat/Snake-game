using System;
using System.Drawing;
using System.Windows.Forms;
using static Snake_game.Settings;

namespace Snake_game {
    public partial class Main : Form {
        #region Fields
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
            try {
                LoadIniConfig();
            }
            catch (Exception exception) {
                MessageBox.Show(this, exception.Message);
            }
            picCanvas.BackColor = Color.FromArgb(CellColorR, CellColorG, CellColorB);
            picCanvas.Enabled = false;
            BestScore = 0;
            lblScore.Text = 0.ToString();
            lblBestScore.Text = BestScore.ToString();
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e) {
            picCanvas.Enabled = true;
            if (_core?.Snake == null) StartNewGame();
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e) {
            if (_core?.Snake == null) {
                new Settings().ShowDialog();
                picCanvas.BackColor = Color.FromArgb(CellColorR, CellColorG, CellColorB);
            }
        }
        private void Main_KeyDown(object sender, KeyEventArgs e) => _core?.SetKeyInput(e.KeyCode);
        #endregion

        #region Methods
        private void StartNewGame() {
            lblScore.Text = 0.ToString();
            _snake = new Snake(new Point(DefaultSnakeLocationX, DefaultSnakeLocationY), DefaultSnakeDirection);
            _core = new SnakeGameManager(picCanvas, _snake, UpdateInterval) {
                UpdateScore = delegate(int score) { lblScore.Text = score.ToString(); },
                UpdateBestScore = delegate(int score) {
                                      BestScore = score;
                                      lblBestScore.Text = BestScore.ToString();
                                  }
            };
            _core.Start();
        }
        #endregion

        #region Properties
        public static int BestScore { get; protected set; }
        #endregion
    }
}
