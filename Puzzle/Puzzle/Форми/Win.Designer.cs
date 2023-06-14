namespace Puzzle
{
    partial class Win
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Name_txt = new System.Windows.Forms.Label();
            this.Time_txt = new System.Windows.Forms.Label();
            this.Count_txt = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(244)))), ((int)(((byte)(254)))));
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ви перемогли!!!";
            // 
            // Name_txt
            // 
            this.Name_txt.AutoSize = true;
            this.Name_txt.BackColor = System.Drawing.Color.Transparent;
            this.Name_txt.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_txt.ForeColor = System.Drawing.Color.Goldenrod;
            this.Name_txt.Location = new System.Drawing.Point(163, 160);
            this.Name_txt.Name = "Name_txt";
            this.Name_txt.Size = new System.Drawing.Size(58, 24);
            this.Name_txt.TabIndex = 1;
            this.Name_txt.Text = "Імя:  ";
            // 
            // Time_txt
            // 
            this.Time_txt.AutoSize = true;
            this.Time_txt.BackColor = System.Drawing.Color.Transparent;
            this.Time_txt.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Time_txt.ForeColor = System.Drawing.Color.Goldenrod;
            this.Time_txt.Location = new System.Drawing.Point(163, 188);
            this.Time_txt.Name = "Time_txt";
            this.Time_txt.Size = new System.Drawing.Size(91, 24);
            this.Time_txt.TabIndex = 2;
            this.Time_txt.Text = "Час гри:  ";
            // 
            // Count_txt
            // 
            this.Count_txt.AutoSize = true;
            this.Count_txt.BackColor = System.Drawing.Color.Transparent;
            this.Count_txt.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Count_txt.ForeColor = System.Drawing.Color.Goldenrod;
            this.Count_txt.Location = new System.Drawing.Point(3, 0);
            this.Count_txt.Name = "Count_txt";
            this.Count_txt.Size = new System.Drawing.Size(169, 24);
            this.Count_txt.TabIndex = 3;
            this.Count_txt.Text = "Кількість кроків:  ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.Count_txt);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(160, 215);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(214, 62);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::Puzzle.Properties.Resources.перемога;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(386, 327);
            this.Controls.Add(this.Time_txt);
            this.Controls.Add(this.Name_txt);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Премога!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Win_FormClosing);
            this.Load += new System.EventHandler(this.Win_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Name_txt;
        private System.Windows.Forms.Label Time_txt;
        private System.Windows.Forms.Label Count_txt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}