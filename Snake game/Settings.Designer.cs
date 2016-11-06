using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Snake_game {
    partial class Settings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.grpSnakeSize = new System.Windows.Forms.GroupBox();
            this.radUltraBigSize = new System.Windows.Forms.RadioButton();
            this.radVeryBigSize = new System.Windows.Forms.RadioButton();
            this.radBigSize = new System.Windows.Forms.RadioButton();
            this.radNormalSize = new System.Windows.Forms.RadioButton();
            this.radSmallSize = new System.Windows.Forms.RadioButton();
            this.radTinySize = new System.Windows.Forms.RadioButton();
            this.radImpossibleSize = new System.Windows.Forms.RadioButton();
            this.grpColor = new System.Windows.Forms.GroupBox();
            this.lblBackColor = new System.Windows.Forms.Label();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.btnSnakeHeadLoseColor = new System.Windows.Forms.Button();
            this.btnFoodColor = new System.Windows.Forms.Button();
            this.btnSnakeBodyColor = new System.Windows.Forms.Button();
            this.lblSnakeHeadLoseColor = new System.Windows.Forms.Label();
            this.btnSnakeHeadColor = new System.Windows.Forms.Button();
            this.lblFoodColor = new System.Windows.Forms.Label();
            this.lblSnakeBodyColor = new System.Windows.Forms.Label();
            this.lblSnakeHeadColor = new System.Windows.Forms.Label();
            this.colorDiag = new System.Windows.Forms.ColorDialog();
            this.grpSnakeSpeed = new System.Windows.Forms.GroupBox();
            this.numSnakeSpeed = new System.Windows.Forms.NumericUpDown();
            this.radCustomSpeed = new System.Windows.Forms.RadioButton();
            this.radFastestSpeed = new System.Windows.Forms.RadioButton();
            this.radFasterSpeed = new System.Windows.Forms.RadioButton();
            this.radFastSpeed = new System.Windows.Forms.RadioButton();
            this.radNormalSpeed = new System.Windows.Forms.RadioButton();
            this.radSlowSpeed = new System.Windows.Forms.RadioButton();
            this.radSlowerSpeed = new System.Windows.Forms.RadioButton();
            this.radSlowestSpeed = new System.Windows.Forms.RadioButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.numFoodScore = new System.Windows.Forms.NumericUpDown();
            this.numMaxScore = new System.Windows.Forms.NumericUpDown();
            this.grpScore = new System.Windows.Forms.GroupBox();
            this.lblMaxScore = new System.Windows.Forms.Label();
            this.lblFoodScore = new System.Windows.Forms.Label();
            this.grpDefault = new System.Windows.Forms.GroupBox();
            this.cboxDefSnakeDir = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numDefSpawnY = new System.Windows.Forms.NumericUpDown();
            this.numDefSpawnX = new System.Windows.Forms.NumericUpDown();
            this.numDefSnakeLength = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpSnakeSize.SuspendLayout();
            this.grpColor.SuspendLayout();
            this.grpSnakeSpeed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSnakeSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFoodScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxScore)).BeginInit();
            this.grpScore.SuspendLayout();
            this.grpDefault.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDefSpawnY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefSpawnX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefSnakeLength)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSnakeSize
            // 
            this.grpSnakeSize.Controls.Add(this.radUltraBigSize);
            this.grpSnakeSize.Controls.Add(this.radVeryBigSize);
            this.grpSnakeSize.Controls.Add(this.radBigSize);
            this.grpSnakeSize.Controls.Add(this.radNormalSize);
            this.grpSnakeSize.Controls.Add(this.radSmallSize);
            this.grpSnakeSize.Controls.Add(this.radTinySize);
            this.grpSnakeSize.Controls.Add(this.radImpossibleSize);
            this.grpSnakeSize.Location = new System.Drawing.Point(13, 13);
            this.grpSnakeSize.Name = "grpSnakeSize";
            this.grpSnakeSize.Size = new System.Drawing.Size(200, 212);
            this.grpSnakeSize.TabIndex = 0;
            this.grpSnakeSize.TabStop = false;
            this.grpSnakeSize.Text = "Snake size";
            // 
            // radUltraBigSize
            // 
            this.radUltraBigSize.AutoSize = true;
            this.radUltraBigSize.Location = new System.Drawing.Point(7, 185);
            this.radUltraBigSize.Name = "radUltraBigSize";
            this.radUltraBigSize.Size = new System.Drawing.Size(79, 21);
            this.radUltraBigSize.TabIndex = 0;
            this.radUltraBigSize.Text = "Ultra big";
            this.radUltraBigSize.UseVisualStyleBackColor = true;
            // 
            // radVeryBigSize
            // 
            this.radVeryBigSize.AutoSize = true;
            this.radVeryBigSize.Location = new System.Drawing.Point(7, 158);
            this.radVeryBigSize.Name = "radVeryBigSize";
            this.radVeryBigSize.Size = new System.Drawing.Size(78, 21);
            this.radVeryBigSize.TabIndex = 0;
            this.radVeryBigSize.Text = "Very big";
            this.radVeryBigSize.UseVisualStyleBackColor = true;
            // 
            // radBigSize
            // 
            this.radBigSize.AutoSize = true;
            this.radBigSize.Location = new System.Drawing.Point(7, 131);
            this.radBigSize.Name = "radBigSize";
            this.radBigSize.Size = new System.Drawing.Size(46, 21);
            this.radBigSize.TabIndex = 0;
            this.radBigSize.Text = "Big";
            this.radBigSize.UseVisualStyleBackColor = true;
            // 
            // radNormalSize
            // 
            this.radNormalSize.AutoSize = true;
            this.radNormalSize.Checked = true;
            this.radNormalSize.Location = new System.Drawing.Point(7, 104);
            this.radNormalSize.Name = "radNormalSize";
            this.radNormalSize.Size = new System.Drawing.Size(71, 21);
            this.radNormalSize.TabIndex = 0;
            this.radNormalSize.TabStop = true;
            this.radNormalSize.Text = "Normal";
            this.radNormalSize.UseVisualStyleBackColor = true;
            // 
            // radSmallSize
            // 
            this.radSmallSize.AutoSize = true;
            this.radSmallSize.Location = new System.Drawing.Point(7, 77);
            this.radSmallSize.Name = "radSmallSize";
            this.radSmallSize.Size = new System.Drawing.Size(60, 21);
            this.radSmallSize.TabIndex = 0;
            this.radSmallSize.Text = "Small";
            this.radSmallSize.UseVisualStyleBackColor = true;
            // 
            // radTinySize
            // 
            this.radTinySize.AutoSize = true;
            this.radTinySize.Location = new System.Drawing.Point(7, 50);
            this.radTinySize.Name = "radTinySize";
            this.radTinySize.Size = new System.Drawing.Size(53, 21);
            this.radTinySize.TabIndex = 0;
            this.radTinySize.Text = "Tiny";
            this.radTinySize.UseVisualStyleBackColor = true;
            // 
            // radImpossibleSize
            // 
            this.radImpossibleSize.AutoSize = true;
            this.radImpossibleSize.Location = new System.Drawing.Point(7, 23);
            this.radImpossibleSize.Name = "radImpossibleSize";
            this.radImpossibleSize.Size = new System.Drawing.Size(92, 21);
            this.radImpossibleSize.TabIndex = 0;
            this.radImpossibleSize.Text = "Impossible";
            this.radImpossibleSize.UseVisualStyleBackColor = true;
            // 
            // grpColor
            // 
            this.grpColor.Controls.Add(this.lblBackColor);
            this.grpColor.Controls.Add(this.btnBackColor);
            this.grpColor.Controls.Add(this.btnSnakeHeadLoseColor);
            this.grpColor.Controls.Add(this.btnFoodColor);
            this.grpColor.Controls.Add(this.btnSnakeBodyColor);
            this.grpColor.Controls.Add(this.lblSnakeHeadLoseColor);
            this.grpColor.Controls.Add(this.btnSnakeHeadColor);
            this.grpColor.Controls.Add(this.lblFoodColor);
            this.grpColor.Controls.Add(this.lblSnakeBodyColor);
            this.grpColor.Controls.Add(this.lblSnakeHeadColor);
            this.grpColor.Location = new System.Drawing.Point(220, 13);
            this.grpColor.Name = "grpColor";
            this.grpColor.Size = new System.Drawing.Size(252, 212);
            this.grpColor.TabIndex = 1;
            this.grpColor.TabStop = false;
            this.grpColor.Text = "Color";
            // 
            // lblBackColor
            // 
            this.lblBackColor.AutoSize = true;
            this.lblBackColor.Location = new System.Drawing.Point(7, 187);
            this.lblBackColor.Name = "lblBackColor";
            this.lblBackColor.Size = new System.Drawing.Size(140, 17);
            this.lblBackColor.TabIndex = 2;
            this.lblBackColor.Text = "Playfield background";
            // 
            // btnBackColor
            // 
            this.btnBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackColor.Location = new System.Drawing.Point(157, 184);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(89, 23);
            this.btnBackColor.TabIndex = 1;
            this.btnBackColor.UseVisualStyleBackColor = true;
            this.btnBackColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // btnSnakeHeadLoseColor
            // 
            this.btnSnakeHeadLoseColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSnakeHeadLoseColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnakeHeadLoseColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnakeHeadLoseColor.Location = new System.Drawing.Point(157, 103);
            this.btnSnakeHeadLoseColor.Name = "btnSnakeHeadLoseColor";
            this.btnSnakeHeadLoseColor.Size = new System.Drawing.Size(89, 23);
            this.btnSnakeHeadLoseColor.TabIndex = 1;
            this.btnSnakeHeadLoseColor.UseVisualStyleBackColor = true;
            this.btnSnakeHeadLoseColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // btnFoodColor
            // 
            this.btnFoodColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoodColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoodColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodColor.Location = new System.Drawing.Point(157, 76);
            this.btnFoodColor.Name = "btnFoodColor";
            this.btnFoodColor.Size = new System.Drawing.Size(89, 23);
            this.btnFoodColor.TabIndex = 1;
            this.btnFoodColor.UseVisualStyleBackColor = true;
            this.btnFoodColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // btnSnakeBodyColor
            // 
            this.btnSnakeBodyColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSnakeBodyColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnakeBodyColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnakeBodyColor.Location = new System.Drawing.Point(157, 49);
            this.btnSnakeBodyColor.Name = "btnSnakeBodyColor";
            this.btnSnakeBodyColor.Size = new System.Drawing.Size(89, 23);
            this.btnSnakeBodyColor.TabIndex = 1;
            this.btnSnakeBodyColor.UseVisualStyleBackColor = true;
            this.btnSnakeBodyColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // lblSnakeHeadLoseColor
            // 
            this.lblSnakeHeadLoseColor.AutoSize = true;
            this.lblSnakeHeadLoseColor.Location = new System.Drawing.Point(7, 106);
            this.lblSnakeHeadLoseColor.Name = "lblSnakeHeadLoseColor";
            this.lblSnakeHeadLoseColor.Size = new System.Drawing.Size(144, 17);
            this.lblSnakeHeadLoseColor.TabIndex = 0;
            this.lblSnakeHeadLoseColor.Text = "Snake\'s head on lose";
            // 
            // btnSnakeHeadColor
            // 
            this.btnSnakeHeadColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSnakeHeadColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSnakeHeadColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSnakeHeadColor.Location = new System.Drawing.Point(157, 22);
            this.btnSnakeHeadColor.Name = "btnSnakeHeadColor";
            this.btnSnakeHeadColor.Size = new System.Drawing.Size(89, 23);
            this.btnSnakeHeadColor.TabIndex = 1;
            this.btnSnakeHeadColor.UseVisualStyleBackColor = true;
            this.btnSnakeHeadColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // lblFoodColor
            // 
            this.lblFoodColor.AutoSize = true;
            this.lblFoodColor.Location = new System.Drawing.Point(7, 79);
            this.lblFoodColor.Name = "lblFoodColor";
            this.lblFoodColor.Size = new System.Drawing.Size(40, 17);
            this.lblFoodColor.TabIndex = 0;
            this.lblFoodColor.Text = "Food";
            // 
            // lblSnakeBodyColor
            // 
            this.lblSnakeBodyColor.AutoSize = true;
            this.lblSnakeBodyColor.Location = new System.Drawing.Point(7, 52);
            this.lblSnakeBodyColor.Name = "lblSnakeBodyColor";
            this.lblSnakeBodyColor.Size = new System.Drawing.Size(93, 17);
            this.lblSnakeBodyColor.TabIndex = 0;
            this.lblSnakeBodyColor.Text = "Snake\'s body";
            // 
            // lblSnakeHeadColor
            // 
            this.lblSnakeHeadColor.AutoSize = true;
            this.lblSnakeHeadColor.Location = new System.Drawing.Point(7, 25);
            this.lblSnakeHeadColor.Name = "lblSnakeHeadColor";
            this.lblSnakeHeadColor.Size = new System.Drawing.Size(94, 17);
            this.lblSnakeHeadColor.TabIndex = 0;
            this.lblSnakeHeadColor.Text = "Snake\'s head";
            // 
            // grpSnakeSpeed
            // 
            this.grpSnakeSpeed.Controls.Add(this.numSnakeSpeed);
            this.grpSnakeSpeed.Controls.Add(this.radCustomSpeed);
            this.grpSnakeSpeed.Controls.Add(this.radFastestSpeed);
            this.grpSnakeSpeed.Controls.Add(this.radFasterSpeed);
            this.grpSnakeSpeed.Controls.Add(this.radFastSpeed);
            this.grpSnakeSpeed.Controls.Add(this.radNormalSpeed);
            this.grpSnakeSpeed.Controls.Add(this.radSlowSpeed);
            this.grpSnakeSpeed.Controls.Add(this.radSlowerSpeed);
            this.grpSnakeSpeed.Controls.Add(this.radSlowestSpeed);
            this.grpSnakeSpeed.Location = new System.Drawing.Point(13, 242);
            this.grpSnakeSpeed.Name = "grpSnakeSpeed";
            this.grpSnakeSpeed.Size = new System.Drawing.Size(200, 212);
            this.grpSnakeSpeed.TabIndex = 0;
            this.grpSnakeSpeed.TabStop = false;
            this.grpSnakeSpeed.Text = "Snake speed";
            // 
            // numSnakeSpeed
            // 
            this.numSnakeSpeed.Enabled = false;
            this.numSnakeSpeed.Location = new System.Drawing.Point(87, 50);
            this.numSnakeSpeed.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numSnakeSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSnakeSpeed.Name = "numSnakeSpeed";
            this.numSnakeSpeed.Size = new System.Drawing.Size(107, 23);
            this.numSnakeSpeed.TabIndex = 2;
            this.toolTip.SetToolTip(this.numSnakeSpeed, "The bigger the value is, the slower the snake moves.");
            this.numSnakeSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSnakeSpeed.Visible = false;
            // 
            // radCustomSpeed
            // 
            this.radCustomSpeed.AutoSize = true;
            this.radCustomSpeed.Location = new System.Drawing.Point(87, 23);
            this.radCustomSpeed.Name = "radCustomSpeed";
            this.radCustomSpeed.Size = new System.Drawing.Size(73, 21);
            this.radCustomSpeed.TabIndex = 1;
            this.radCustomSpeed.Text = "Custom";
            this.radCustomSpeed.UseVisualStyleBackColor = true;
            this.radCustomSpeed.CheckedChanged += new System.EventHandler(this.radCustomSpeed_CheckedChanged);
            // 
            // radFastestSpeed
            // 
            this.radFastestSpeed.AutoSize = true;
            this.radFastestSpeed.Location = new System.Drawing.Point(7, 185);
            this.radFastestSpeed.Name = "radFastestSpeed";
            this.radFastestSpeed.Size = new System.Drawing.Size(72, 21);
            this.radFastestSpeed.TabIndex = 0;
            this.radFastestSpeed.Text = "Fastest";
            this.radFastestSpeed.UseVisualStyleBackColor = true;
            // 
            // radFasterSpeed
            // 
            this.radFasterSpeed.AutoSize = true;
            this.radFasterSpeed.Location = new System.Drawing.Point(7, 158);
            this.radFasterSpeed.Name = "radFasterSpeed";
            this.radFasterSpeed.Size = new System.Drawing.Size(66, 21);
            this.radFasterSpeed.TabIndex = 0;
            this.radFasterSpeed.Text = "Faster";
            this.radFasterSpeed.UseVisualStyleBackColor = true;
            // 
            // radFastSpeed
            // 
            this.radFastSpeed.AutoSize = true;
            this.radFastSpeed.Location = new System.Drawing.Point(7, 131);
            this.radFastSpeed.Name = "radFastSpeed";
            this.radFastSpeed.Size = new System.Drawing.Size(53, 21);
            this.radFastSpeed.TabIndex = 0;
            this.radFastSpeed.Text = "Fast";
            this.radFastSpeed.UseVisualStyleBackColor = true;
            // 
            // radNormalSpeed
            // 
            this.radNormalSpeed.AutoSize = true;
            this.radNormalSpeed.Checked = true;
            this.radNormalSpeed.Location = new System.Drawing.Point(7, 104);
            this.radNormalSpeed.Name = "radNormalSpeed";
            this.radNormalSpeed.Size = new System.Drawing.Size(71, 21);
            this.radNormalSpeed.TabIndex = 0;
            this.radNormalSpeed.TabStop = true;
            this.radNormalSpeed.Text = "Normal";
            this.radNormalSpeed.UseVisualStyleBackColor = true;
            // 
            // radSlowSpeed
            // 
            this.radSlowSpeed.AutoSize = true;
            this.radSlowSpeed.Location = new System.Drawing.Point(7, 77);
            this.radSlowSpeed.Name = "radSlowSpeed";
            this.radSlowSpeed.Size = new System.Drawing.Size(55, 21);
            this.radSlowSpeed.TabIndex = 0;
            this.radSlowSpeed.Text = "Slow";
            this.radSlowSpeed.UseVisualStyleBackColor = true;
            // 
            // radSlowerSpeed
            // 
            this.radSlowerSpeed.AutoSize = true;
            this.radSlowerSpeed.Location = new System.Drawing.Point(7, 50);
            this.radSlowerSpeed.Name = "radSlowerSpeed";
            this.radSlowerSpeed.Size = new System.Drawing.Size(68, 21);
            this.radSlowerSpeed.TabIndex = 0;
            this.radSlowerSpeed.Text = "Slower";
            this.radSlowerSpeed.UseVisualStyleBackColor = true;
            // 
            // radSlowestSpeed
            // 
            this.radSlowestSpeed.AutoSize = true;
            this.radSlowestSpeed.Location = new System.Drawing.Point(7, 23);
            this.radSlowestSpeed.Name = "radSlowestSpeed";
            this.radSlowestSpeed.Size = new System.Drawing.Size(74, 21);
            this.radSlowestSpeed.TabIndex = 0;
            this.radSlowestSpeed.Text = "Slowest";
            this.radSlowestSpeed.UseVisualStyleBackColor = true;
            // 
            // numFoodScore
            // 
            this.numFoodScore.Location = new System.Drawing.Point(92, 21);
            this.numFoodScore.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numFoodScore.Name = "numFoodScore";
            this.numFoodScore.Size = new System.Drawing.Size(154, 23);
            this.numFoodScore.TabIndex = 1;
            this.toolTip.SetToolTip(this.numFoodScore, "Score received from eating each food.");
            // 
            // numMaxScore
            // 
            this.numMaxScore.Location = new System.Drawing.Point(92, 52);
            this.numMaxScore.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numMaxScore.Name = "numMaxScore";
            this.numMaxScore.Size = new System.Drawing.Size(154, 23);
            this.numMaxScore.TabIndex = 1;
            this.toolTip.SetToolTip(this.numMaxScore, "If the score reaches this value, you win. 0 means no score limit.");
            // 
            // grpScore
            // 
            this.grpScore.Controls.Add(this.numMaxScore);
            this.grpScore.Controls.Add(this.lblMaxScore);
            this.grpScore.Controls.Add(this.numFoodScore);
            this.grpScore.Controls.Add(this.lblFoodScore);
            this.grpScore.Location = new System.Drawing.Point(220, 240);
            this.grpScore.Name = "grpScore";
            this.grpScore.Size = new System.Drawing.Size(252, 81);
            this.grpScore.TabIndex = 2;
            this.grpScore.TabStop = false;
            this.grpScore.Text = "Score";
            // 
            // lblMaxScore
            // 
            this.lblMaxScore.AutoSize = true;
            this.lblMaxScore.Location = new System.Drawing.Point(7, 52);
            this.lblMaxScore.Name = "lblMaxScore";
            this.lblMaxScore.Size = new System.Drawing.Size(72, 17);
            this.lblMaxScore.TabIndex = 0;
            this.lblMaxScore.Text = "Max score";
            // 
            // lblFoodScore
            // 
            this.lblFoodScore.AutoSize = true;
            this.lblFoodScore.Location = new System.Drawing.Point(7, 23);
            this.lblFoodScore.Name = "lblFoodScore";
            this.lblFoodScore.Size = new System.Drawing.Size(79, 17);
            this.lblFoodScore.TabIndex = 0;
            this.lblFoodScore.Text = "Food score";
            // 
            // grpDefault
            // 
            this.grpDefault.Controls.Add(this.cboxDefSnakeDir);
            this.grpDefault.Controls.Add(this.label2);
            this.grpDefault.Controls.Add(this.numDefSpawnY);
            this.grpDefault.Controls.Add(this.numDefSpawnX);
            this.grpDefault.Controls.Add(this.numDefSnakeLength);
            this.grpDefault.Controls.Add(this.label3);
            this.grpDefault.Controls.Add(this.label1);
            this.grpDefault.Location = new System.Drawing.Point(220, 327);
            this.grpDefault.Name = "grpDefault";
            this.grpDefault.Size = new System.Drawing.Size(246, 127);
            this.grpDefault.TabIndex = 3;
            this.grpDefault.TabStop = false;
            this.grpDefault.Text = "Default";
            // 
            // cboxDefSnakeDir
            // 
            this.cboxDefSnakeDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDefSnakeDir.FormattingEnabled = true;
            this.cboxDefSnakeDir.Items.AddRange(new object[] {
            "Up",
            "Down",
            "Left",
            "Right"});
            this.cboxDefSnakeDir.Location = new System.Drawing.Point(166, 45);
            this.cboxDefSnakeDir.MaxDropDownItems = 4;
            this.cboxDefSnakeDir.Name = "cboxDefSnakeDir";
            this.cboxDefSnakeDir.Size = new System.Drawing.Size(74, 24);
            this.cboxDefSnakeDir.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Default snake direction";
            // 
            // numDefSpawnY
            // 
            this.numDefSpawnY.Location = new System.Drawing.Point(79, 95);
            this.numDefSpawnY.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numDefSpawnY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDefSpawnY.Name = "numDefSpawnY";
            this.numDefSpawnY.Size = new System.Drawing.Size(60, 23);
            this.numDefSpawnY.TabIndex = 1;
            this.numDefSpawnY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDefSpawnX
            // 
            this.numDefSpawnX.Location = new System.Drawing.Point(10, 95);
            this.numDefSpawnX.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numDefSpawnX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDefSpawnX.Name = "numDefSpawnX";
            this.numDefSpawnX.Size = new System.Drawing.Size(60, 23);
            this.numDefSpawnX.TabIndex = 1;
            this.numDefSpawnX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numDefSnakeLength
            // 
            this.numDefSnakeLength.Location = new System.Drawing.Point(166, 17);
            this.numDefSnakeLength.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numDefSnakeLength.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numDefSnakeLength.Name = "numDefSnakeLength";
            this.numDefSnakeLength.Size = new System.Drawing.Size(74, 23);
            this.numDefSnakeLength.TabIndex = 1;
            this.numDefSnakeLength.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Default spawn point";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Default snake length";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(13, 460);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(220, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(246, 460);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(220, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(484, 489);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpDefault);
            this.Controls.Add(this.grpScore);
            this.Controls.Add(this.grpColor);
            this.Controls.Add(this.grpSnakeSpeed);
            this.Controls.Add(this.grpSnakeSize);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Settings_Load);
            this.grpSnakeSize.ResumeLayout(false);
            this.grpSnakeSize.PerformLayout();
            this.grpColor.ResumeLayout(false);
            this.grpColor.PerformLayout();
            this.grpSnakeSpeed.ResumeLayout(false);
            this.grpSnakeSpeed.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSnakeSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFoodScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxScore)).EndInit();
            this.grpScore.ResumeLayout(false);
            this.grpScore.PerformLayout();
            this.grpDefault.ResumeLayout(false);
            this.grpDefault.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDefSpawnY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefSpawnX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDefSnakeLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpSnakeSize;
        private RadioButton radUltraBigSize;
        private RadioButton radVeryBigSize;
        private RadioButton radBigSize;
        private RadioButton radNormalSize;
        private RadioButton radSmallSize;
        private RadioButton radTinySize;
        private RadioButton radImpossibleSize;
        private GroupBox grpColor;
        private Button btnSnakeHeadLoseColor;
        private Button btnFoodColor;
        private Button btnSnakeBodyColor;
        private Label lblSnakeHeadLoseColor;
        private Button btnSnakeHeadColor;
        private Label lblFoodColor;
        private Label lblSnakeBodyColor;
        private Label lblSnakeHeadColor;
        private ColorDialog colorDiag;
        private GroupBox grpSnakeSpeed;
        private NumericUpDown numSnakeSpeed;
        private ToolTip toolTip;
        private RadioButton radCustomSpeed;
        private RadioButton radFastestSpeed;
        private RadioButton radFasterSpeed;
        private RadioButton radFastSpeed;
        private RadioButton radNormalSpeed;
        private RadioButton radSlowSpeed;
        private RadioButton radSlowerSpeed;
        private RadioButton radSlowestSpeed;
        private GroupBox grpScore;
        private Label lblFoodScore;
        private NumericUpDown numMaxScore;
        private Label lblMaxScore;
        private NumericUpDown numFoodScore;
        private Label lblBackColor;
        private Button btnBackColor;
        private GroupBox grpDefault;
        private NumericUpDown numDefSnakeLength;
        private Label label1;
        private ComboBox cboxDefSnakeDir;
        private Label label2;
        private NumericUpDown numDefSpawnY;
        private NumericUpDown numDefSpawnX;
        private Label label3;
        private Button btnCancel;
        private Button btnSave;
    }
}