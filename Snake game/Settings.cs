using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;
using IniParser.Model.Configuration;

namespace Snake_game {
    public partial class Settings : Form {
        #region Fields
        public const string CONFIG_FILE_NAME = @"config.ini";

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

        #region Keys
        private const string CELL_SIZE_KEY = @"CellSize";
        private const string UPDATE_INTERVAL_KEY = @"UpdateInterval";
        private const string HEAD_COLOR_KEY = @"HeadColorRGB";
        private const string BODY_COLOR_KEY = @"BodyColorRGB";
        private const string FOOD_COLOR_KEY = @"FoodColorRGB";
        private const string HEAD_LOSE_COLOR_KEY = @"HeadLoseColorRGB";
        private const string BACKCOLOR_KEY = @"BackgroundColorRGB";
        private const string FOOD_SCORE_KEY = @"FoodScore";
        private const string MAX_SCORE_KEY = @"MaxScore";
        private const string DEF_LENGTH_KEY = @"DefaultLength";
        private const string DEF_DIR_KEY = @"DefaultDirection";
        private const string DEF_SPAWN_POINT_KEY = @"DefaultSpawnPoint";
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
        public static void LoadIniConfig() {
            if (!File.Exists(CONFIG_FILE_NAME) || string.IsNullOrEmpty(File.ReadAllText(CONFIG_FILE_NAME))) {
                File.CreateText(CONFIG_FILE_NAME).Close();
                SetIniConfig(CONFIG_FILE_NAME);
            }

            FileIniDataParser fileIniDataParser = new FileIniDataParser();
            fileIniDataParser.Parser.Configuration.CommentString = @"// ";
            fileIniDataParser.Parser.Configuration.NewLineStr = Environment.NewLine;
            fileIniDataParser.Parser.Configuration.SkipInvalidLines = true;

            IniData iniData = fileIniDataParser.ReadFile(CONFIG_FILE_NAME, Encoding.UTF8);
            SectionDataCollection sectionDataCollection = iniData.Sections;

            SectionData playfieldSectionData = sectionDataCollection.GetSectionData(@"PLAYFIELD");
            SectionData snakeSectionData = sectionDataCollection.GetSectionData(@"SNAKE");
            SectionData foodSectionData = sectionDataCollection.GetSectionData(@"FOOD");
            SectionData scoreSectionData = sectionDataCollection.GetSectionData(@"SCORE");

            if (playfieldSectionData != null) {
                KeyDataCollection playfieldKeys = playfieldSectionData.Keys;

                KeyData cellSize = playfieldKeys.GetKeyData(CELL_SIZE_KEY);
                KeyData backColor = playfieldKeys.GetKeyData(BACKCOLOR_KEY);
                KeyData updateInterval = playfieldKeys.GetKeyData(UPDATE_INTERVAL_KEY);

                if (!string.IsNullOrEmpty(cellSize?.Value))
                    try {
                        CellSize = Convert.ToInt32(cellSize.Value);
                    }
                    catch (Exception e) {
                         throw new Exception($"An error occurred while reading {cellSize.KeyName} value!", e);
                    }
                if (!string.IsNullOrEmpty(backColor?.Value))
                    try {
                        Color value = Helpers.GetColorFromRgbString(backColor.Value, ',');
                        CellColorR = value.R;
                        CellColorG = value.G;
                        CellColorB = value.B;
                    }
                    catch (Exception e) {
                        throw new Exception($"An error occurred while reading {backColor.KeyName} value!", e);
                    }
                if (!string.IsNullOrEmpty(updateInterval?.Value))
                    try {
                        UpdateInterval = Convert.ToInt32(updateInterval.Value);
                    }
                    catch (Exception e) {
                        throw new Exception($"An error occurred while reading {updateInterval.KeyName} value!", e);
                    }
            }

            if (snakeSectionData != null) {
                KeyDataCollection snakeKeys = snakeSectionData.Keys;

                KeyData headColor = snakeKeys.GetKeyData(HEAD_COLOR_KEY);
                KeyData headLoseColor = snakeKeys.GetKeyData(HEAD_LOSE_COLOR_KEY);
                KeyData bodyColor = snakeKeys.GetKeyData(BODY_COLOR_KEY);
                KeyData defaultLength = snakeKeys.GetKeyData(DEF_LENGTH_KEY);
                KeyData defaultDirection = snakeKeys.GetKeyData(DEF_DIR_KEY);
                KeyData defaultSpawnPoint = snakeKeys.GetKeyData(DEF_SPAWN_POINT_KEY);

                if (!string.IsNullOrEmpty(headColor?.Value))
                    try {
                        Color value = Helpers.GetColorFromRgbString(headColor.Value, ',');
                        SnakeHeadColorR = value.R;
                        SnakeHeadColorG = value.G;
                        SnakeHeadColorB = value.B;
                    }
                    catch (Exception e) {
                        throw new Exception($"An error occurred while reading {headColor.KeyName} value!", e);
                    }
                if (!string.IsNullOrEmpty(headLoseColor?.Value))
                    try {
                        Color value = Helpers.GetColorFromRgbString(headLoseColor.Value, ',');
                        SnakeHeadLoseColorR = value.R;
                        SnakeHeadLoseColorG = value.G;
                        SnakeHeadLoseColorR = value.B;
                    } catch (Exception e) {
                        throw new Exception($"An error occurred while reading {headLoseColor.KeyName} value!", e);
                    }
                if (!string.IsNullOrEmpty(bodyColor?.Value))
                    try {
                        Color value = Helpers.GetColorFromRgbString(bodyColor.Value, ',');
                        SnakeBodyColorR = value.R;
                        SnakeBodyColorG = value.G;
                        SnakeBodyColorB = value.B;
                    } catch (Exception e) {
                        throw new Exception($"An error occurred while reading {bodyColor.KeyName} value!", e);
                    }
                if (!string.IsNullOrEmpty(defaultLength?.Value))
                    try {
                        DefaultSnakeLength = Convert.ToInt32(defaultLength.Value);
                    }
                    catch (Exception e) {
                        throw new Exception($"An error occurred while reading {defaultLength.KeyName} value!", e);
                    }
                if (!string.IsNullOrEmpty(defaultDirection?.Value))
                    switch (defaultDirection.Value) {
                        case @"Up": DefaultSnakeDirection = Direction.Up; break;
                        case @"Down": DefaultSnakeDirection = Direction.Down; break;
                        case @"Left": DefaultSnakeDirection = Direction.Left; break;
                        case @"Right": DefaultSnakeDirection = Direction.Right; break;
                        default: throw new FormatException($"An error occurred while reading {defaultDirection.KeyName} value!");
                    }
                if (!string.IsNullOrEmpty(defaultSpawnPoint?.Value))
                    try {
                        Point value = Helpers.GetPointFromXyString(defaultSpawnPoint.Value, ',');
                        DefaultSnakeLocationX = value.X;
                        DefaultSnakeLocationY = value.Y;
                    }
                    catch (Exception e) {
                        throw new Exception($"An error occurred while reading {defaultSpawnPoint.KeyName} value!", e);
                    }
            }

            if (foodSectionData != null) {
                KeyDataCollection foodKeys = foodSectionData.Keys;

                KeyData foodColor = foodKeys.GetKeyData(FOOD_COLOR_KEY);
                KeyData foodScore = foodKeys.GetKeyData(FOOD_SCORE_KEY);

                if (!string.IsNullOrEmpty(foodColor?.Value))
                    try {
                        Color value = Helpers.GetColorFromRgbString(foodColor.Value, ',');
                        FoodColorR = value.R;
                        FoodColorG = value.G;
                        FoodColorB = value.B;
                    }
                    catch (Exception e) {
                        throw new Exception($"An error occurred while reading {foodColor.KeyName} value!", e);
                    }
                if (!string.IsNullOrEmpty(foodScore?.Value))
                    try {
                        FoodScore = Convert.ToInt32(foodScore.Value);
                    }
                    catch (Exception e) {
                        throw new Exception($"An error occurred while reading {foodScore.KeyName} value!", e);
                    }
            }

            if (scoreSectionData != null) {
                KeyDataCollection scoreKeys = scoreSectionData.Keys;

                KeyData maxScore = scoreKeys.GetKeyData(MAX_SCORE_KEY);

                if (!string.IsNullOrEmpty(maxScore?.Value))
                    try {
                        MaxScore = Convert.ToInt32(maxScore.Value);
                    }
                    catch (Exception e) {
                        throw new Exception($"An error occurred while reading {maxScore.KeyName} value!", e);
                    }
            }
        }
        private void LoadGameSettings() {
            int size = CellSize;
            int speed = UpdateInterval;
            int score = FoodScore;
            int max = MaxScore;

            int defaultLength = DefaultSnakeLength;
            Direction defaultDirection = DefaultSnakeDirection;
            Point defaultSpawnPoint = new Point(DefaultSnakeLocationX, DefaultSnakeLocationY);

            LoadSizeSetting(size);
            LoadSpeedSetting(speed);
            LoadFoodScoreSetting(score);
            LoadMaxScoreSetting(max);
            LoadColorSettings(CellColor, SnakeHeadColor, SnakeBodyColor, FoodColor, SnakeHeadLoseColor);
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
                default:
                    radNormalSpeed.Checked = true;
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
            SetIniConfig(CONFIG_FILE_NAME);
        }
        private static void SetIniConfig(string path) {
            if (!File.Exists(path)) File.CreateText(path).Close();
            FileIniDataParser iniDataParser = new FileIniDataParser();
            SectionDataCollection sectionDataCollection = new SectionDataCollection();
            
            SectionData playfieldSectionData = new SectionData(@"PLAYFIELD");
            KeyData cellSize = new KeyData(CELL_SIZE_KEY) {
                Value = CellSize.ToString(),
                Comments = new List<string> {
                    @"Size of a cell.",
                    $"Must be divisible by {PLAYFIELD_WIDTH} (width) and {PLAYFIELD_HEIGHT} (height)."
                }
            };
            KeyData backColor = new KeyData(BACKCOLOR_KEY) {
                Value = Helpers.ToRgbString(CellColor, @", "),
                Comments = new List<string> {
                    @"Background color in RGB format."
                }
            };
            KeyData updateInterval = new KeyData(UPDATE_INTERVAL_KEY) {
                Value = UpdateInterval.ToString(),
                Comments = new List<string> {
                    @"The time (in milliseconds) between each time the snake moves.",
                    @"The smaller the interval is, the faster the snake moves."
                }
            };
            Helpers.AddKeysToSection(playfieldSectionData, cellSize, backColor, updateInterval);

            SectionData snakeSectionData = new SectionData(@"SNAKE");
            KeyData headColor = new KeyData(HEAD_COLOR_KEY) {
                Value = Helpers.ToRgbString(SnakeHeadColor, @", "),
                Comments = new List<string> {
                    @"Color of snake's head in RGB format."
                }
            };
            KeyData headLoseColor = new KeyData(HEAD_LOSE_COLOR_KEY) {
                Value = Helpers.ToRgbString(SnakeHeadLoseColor, @", "),
                Comments = new List<string> {
                    @"Color of snake's head when lose in RGB format."
                }
            };
            KeyData bodyColor = new KeyData(BODY_COLOR_KEY) {
                Value = Helpers.ToRgbString(SnakeBodyColor, @", "),
                Comments = new List<string> {
                    @"Color of snake's body in RGB format."
                }
            };
            KeyData defaultLength = new KeyData(DEF_LENGTH_KEY) {
                Value = DefaultSnakeLength.ToString(),
                Comments = new List<string> {
                    @"Default length of the snake when a new game starts.",
                    @"The value must be greater than 1."
                }
            };
            KeyData defaultDirection = new KeyData(DEF_DIR_KEY) {
                Value = DefaultSnakeDirection.ToString(),
                Comments = new List<string> {
                    @"Default moving direction of the snake when a new game starts.",
                    @"The value can only be Up, Down, Left or Right."
                }
            };
            KeyData defaultSpawnPoint = new KeyData(DEF_SPAWN_POINT_KEY) {
                Value = $"{DefaultSnakeLocationX}, {DefaultSnakeLocationY}",
                Comments = new List<string> {
                    @"Default spawn point (X, Y) of the snake when a new game starts.",
                    $"The value must be between 1 and {PLAYFIELD_WIDTH/CellSize}."
                }
            };
            Helpers.AddKeysToSection(snakeSectionData, headColor, headLoseColor, bodyColor, defaultLength, defaultDirection, defaultSpawnPoint);

            SectionData foodSectionData = new SectionData(@"FOOD");
            KeyData foodColor = new KeyData(FOOD_COLOR_KEY) {
                Value = Helpers.ToRgbString(FoodColor, @", "),
                Comments = new List<string> {
                    @"Color of food in RGB format."
                }
            };
            KeyData foodScore = new KeyData(FOOD_SCORE_KEY) {
                Value = FoodScore.ToString(),
                Comments = new List<string> {
                    @"Score to be received after eating food"
                }
            };
            Helpers.AddKeysToSection(foodSectionData, foodColor, foodScore);

            SectionData scoreSectionData = new SectionData(@"SCORE");
            
            KeyData maxScore = new KeyData(MAX_SCORE_KEY) {
                Value = MaxScore.ToString(),
                Comments = new List<string> {
                    @"Maximum score of the game.",
                    @"When the maximum score is reached, you win the game.",
                    @"The value must be a positive integer number. 0 means unlimited."
                }
            };
            Helpers.AddKeysToSection(scoreSectionData, maxScore);

            sectionDataCollection.Add(playfieldSectionData);
            sectionDataCollection.Add(snakeSectionData);
            sectionDataCollection.Add(foodSectionData);
            sectionDataCollection.Add(scoreSectionData);

            IniData iniData = new IniData(sectionDataCollection) {Configuration = new IniParserConfiguration {CommentString = @"// ", NewLineStr = Environment.NewLine} };
            iniDataParser.WriteFile(path, iniData, Encoding.UTF8);
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

        #region Properties
        public static Color CellColor => Color.FromArgb(CellColorR, CellColorG, CellColorB);
        public static Color SnakeHeadColor => Color.FromArgb(SnakeHeadColorR, SnakeHeadColorG, SnakeHeadColorB);
        public static Color SnakeBodyColor => Color.FromArgb(SnakeBodyColorR, SnakeBodyColorG, SnakeBodyColorB);
        public static Color SnakeHeadLoseColor => Color.FromArgb(SnakeHeadLoseColorR, SnakeHeadLoseColorG, SnakeHeadLoseColorB);
        public static Color FoodColor => Color.FromArgb(FoodColorR, FoodColorG, FoodColorB);
        #endregion
    }
}