namespace Puzzle
{
    partial class Puzzle
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Puzzle));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.Rules = new System.Windows.Forms.ToolStripMenuItem();
            this.GiveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.ReStart = new System.Windows.Forms.ToolStripMenuItem();
            this.Flip = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.timeGame = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowMerge = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(163)))), ((int)(((byte)(186)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGame,
            this.Rules,
            this.GiveUp,
            this.ReStart,
            this.Flip,
            this.Exit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 52);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // NewGame
            // 
            this.NewGame.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.NewGame.Font = new System.Drawing.Font("Myriad Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame.Margin = new System.Windows.Forms.Padding(5);
            this.NewGame.Name = "NewGame";
            this.NewGame.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.NewGame.Size = new System.Drawing.Size(92, 38);
            this.NewGame.Text = "Нова гра";
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // Rules
            // 
            this.Rules.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Rules.Font = new System.Drawing.Font("Myriad Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rules.Margin = new System.Windows.Forms.Padding(5);
            this.Rules.Name = "Rules";
            this.Rules.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Rules.Size = new System.Drawing.Size(91, 38);
            this.Rules.Text = "Правила";
            this.Rules.Click += new System.EventHandler(this.Rules_Click);
            // 
            // GiveUp
            // 
            this.GiveUp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.GiveUp.Enabled = false;
            this.GiveUp.Font = new System.Drawing.Font("Myriad Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GiveUp.Margin = new System.Windows.Forms.Padding(5);
            this.GiveUp.Name = "GiveUp";
            this.GiveUp.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.GiveUp.Size = new System.Drawing.Size(89, 38);
            this.GiveUp.Text = "Здатись";
            this.GiveUp.Click += new System.EventHandler(this.GiveUp_Click);
            // 
            // ReStart
            // 
            this.ReStart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ReStart.Enabled = false;
            this.ReStart.Font = new System.Drawing.Font("Myriad Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReStart.Margin = new System.Windows.Forms.Padding(5);
            this.ReStart.Name = "ReStart";
            this.ReStart.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ReStart.Size = new System.Drawing.Size(167, 38);
            this.ReStart.Text = "Розпочати заново";
            this.ReStart.Click += new System.EventHandler(this.ReStart_Click);
            // 
            // Flip
            // 
            this.Flip.BackgroundImage = global::Puzzle.Properties.Resources._180;
            this.Flip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Flip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Flip.Enabled = false;
            this.Flip.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Flip.Name = "Flip";
            this.Flip.RightToLeftAutoMirrorImage = true;
            this.Flip.Size = new System.Drawing.Size(39, 48);
            this.Flip.Text = "    ";
            this.Flip.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.Flip.Click += new System.EventHandler(this.Flip_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Exit.Font = new System.Drawing.Font("Myriad Arabic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Margin = new System.Windows.Forms.Padding(5);
            this.Exit.Name = "Exit";
            this.Exit.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Exit.Size = new System.Drawing.Size(66, 38);
            this.Exit.Text = "Вихід";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // timeGame
            // 
            this.timeGame.AutoSize = true;
            this.timeGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeGame.Location = new System.Drawing.Point(892, 22);
            this.timeGame.Name = "timeGame";
            this.timeGame.Size = new System.Drawing.Size(64, 17);
            this.timeGame.TabIndex = 1;
            this.timeGame.Text = "00:00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(853, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Час";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Puzzle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Puzzle.Properties.Resources.backGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 460);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeGame);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Puzzle";
            this.Text = "Puzzle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NewGame;
        private System.Windows.Forms.ToolStripMenuItem GiveUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem ReStart;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem Rules;
        private System.Windows.Forms.ToolStripMenuItem Flip;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label timeGame;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

