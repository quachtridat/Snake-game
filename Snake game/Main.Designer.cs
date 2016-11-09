namespace Snake_game {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.panelGame = new System.Windows.Forms.Panel();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.panelStats = new System.Windows.Forms.Panel();
            this.tableStats = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelScore = new System.Windows.Forms.Panel();
            this.lblScoreTitle = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.panelBestScore = new System.Windows.Forms.Panel();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.lblBestScoreTitle = new System.Windows.Forms.Label();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.panelStats.SuspendLayout();
            this.tableStats.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelScore.SuspendLayout();
            this.panelBestScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.Controls.Add(this.picCanvas);
            this.panelGame.Location = new System.Drawing.Point(12, 36);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(600, 600);
            this.panelGame.TabIndex = 0;
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.Control;
            this.picCanvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCanvas.Location = new System.Drawing.Point(0, 0);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(600, 600);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // panelStats
            // 
            this.panelStats.Controls.Add(this.tableStats);
            this.panelStats.Location = new System.Drawing.Point(618, 36);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(215, 600);
            this.panelStats.TabIndex = 1;
            // 
            // tableStats
            // 
            this.tableStats.ColumnCount = 1;
            this.tableStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableStats.Controls.Add(this.panelBestScore, 0, 1);
            this.tableStats.Controls.Add(this.panelScore, 0, 0);
            this.tableStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableStats.Location = new System.Drawing.Point(0, 0);
            this.tableStats.Name = "tableStats";
            this.tableStats.RowCount = 2;
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableStats.Size = new System.Drawing.Size(215, 600);
            this.tableStats.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.newGameToolStripMenuItem.Text = "New game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // panelScore
            // 
            this.panelScore.Controls.Add(this.lblScore);
            this.panelScore.Controls.Add(this.lblScoreTitle);
            this.panelScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScore.Location = new System.Drawing.Point(3, 3);
            this.panelScore.Name = "panelScore";
            this.panelScore.Size = new System.Drawing.Size(209, 294);
            this.panelScore.TabIndex = 0;
            // 
            // lblScoreTitle
            // 
            this.lblScoreTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreTitle.Location = new System.Drawing.Point(0, 0);
            this.lblScoreTitle.Name = "lblScoreTitle";
            this.lblScoreTitle.Size = new System.Drawing.Size(209, 46);
            this.lblScoreTitle.TabIndex = 1;
            this.lblScoreTitle.Text = "Score";
            this.lblScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Green;
            this.lblScore.Location = new System.Drawing.Point(0, 46);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(209, 248);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBestScore
            // 
            this.panelBestScore.Controls.Add(this.lblBestScore);
            this.panelBestScore.Controls.Add(this.lblBestScoreTitle);
            this.panelBestScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBestScore.Location = new System.Drawing.Point(3, 303);
            this.panelBestScore.Name = "panelBestScore";
            this.panelBestScore.Size = new System.Drawing.Size(209, 294);
            this.panelBestScore.TabIndex = 1;
            // 
            // lblBestScore
            // 
            this.lblBestScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBestScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestScore.ForeColor = System.Drawing.Color.Red;
            this.lblBestScore.Location = new System.Drawing.Point(0, 46);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(209, 248);
            this.lblBestScore.TabIndex = 2;
            this.lblBestScore.Text = "0";
            this.lblBestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBestScoreTitle
            // 
            this.lblBestScoreTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBestScoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestScoreTitle.Location = new System.Drawing.Point(0, 0);
            this.lblBestScoreTitle.Name = "lblBestScoreTitle";
            this.lblBestScoreTitle.Size = new System.Drawing.Size(209, 46);
            this.lblBestScoreTitle.TabIndex = 1;
            this.lblBestScoreTitle.Text = "Best";
            this.lblBestScoreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 648);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Basic snake game";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.panelGame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.panelStats.ResumeLayout(false);
            this.tableStats.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelScore.ResumeLayout(false);
            this.panelBestScore.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.TableLayoutPanel tableStats;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Panel panelBestScore;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.Label lblBestScoreTitle;
        private System.Windows.Forms.Panel panelScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreTitle;
    }
}

