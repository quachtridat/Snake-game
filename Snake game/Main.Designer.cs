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
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.panelStats.SuspendLayout();
            this.tableStats.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.tableStats.Controls.Add(this.lblDirection, 0, 1);
            this.tableStats.Controls.Add(this.lblScore, 0, 0);
            this.tableStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableStats.Location = new System.Drawing.Point(0, 0);
            this.tableStats.Name = "tableStats";
            this.tableStats.RowCount = 2;
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableStats.Size = new System.Drawing.Size(215, 600);
            this.tableStats.TabIndex = 0;
            // 
            // lblDirection
            // 
            this.lblDirection.AutoEllipsis = true;
            this.lblDirection.AutoSize = true;
            this.lblDirection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDirection.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirection.Location = new System.Drawing.Point(3, 300);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(209, 300);
            this.lblDirection.TabIndex = 1;
            this.lblDirection.Text = "Dir";
            this.lblDirection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.AutoEllipsis = true;
            this.lblScore.AutoSize = true;
            this.lblScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(3, 0);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(209, 300);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem});
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
            this.tableStats.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.TableLayoutPanel tableStats;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.PictureBox picCanvas;
    }
}

