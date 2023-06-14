namespace Puzzle
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.RB_Size16 = new System.Windows.Forms.RadioButton();
            this.RB_Size48 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.RB_Size100 = new System.Windows.Forms.RadioButton();
            this.RB_SizeXY = new System.Windows.Forms.RadioButton();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.X = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStandard = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть ім\'я користувача";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(25, 44);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(118, 23);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Виберіть зображення";
            // 
            // Open
            // 
            this.Open.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Open.Location = new System.Drawing.Point(25, 93);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(118, 33);
            this.Open.TabIndex = 3;
            this.Open.Text = "Завантажити";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // RB_Size16
            // 
            this.RB_Size16.AutoSize = true;
            this.RB_Size16.Checked = true;
            this.RB_Size16.Location = new System.Drawing.Point(25, 202);
            this.RB_Size16.Name = "RB_Size16";
            this.RB_Size16.Size = new System.Drawing.Size(47, 20);
            this.RB_Size16.TabIndex = 5;
            this.RB_Size16.TabStop = true;
            this.RB_Size16.Text = "4*4";
            this.RB_Size16.UseVisualStyleBackColor = true;
            this.RB_Size16.CheckedChanged += new System.EventHandler(this.RB_Size_CheckedChanged);
            // 
            // RB_Size48
            // 
            this.RB_Size48.AutoSize = true;
            this.RB_Size48.Location = new System.Drawing.Point(25, 228);
            this.RB_Size48.Name = "RB_Size48";
            this.RB_Size48.Size = new System.Drawing.Size(47, 20);
            this.RB_Size48.TabIndex = 6;
            this.RB_Size48.Text = "6*8";
            this.RB_Size48.UseVisualStyleBackColor = true;
            this.RB_Size48.CheckedChanged += new System.EventHandler(this.RB_Size_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кількість частинок (x*y)";
            // 
            // RB_Size100
            // 
            this.RB_Size100.AutoSize = true;
            this.RB_Size100.Location = new System.Drawing.Point(25, 254);
            this.RB_Size100.Name = "RB_Size100";
            this.RB_Size100.Size = new System.Drawing.Size(61, 20);
            this.RB_Size100.TabIndex = 8;
            this.RB_Size100.Text = "10*10";
            this.RB_Size100.UseVisualStyleBackColor = true;
            this.RB_Size100.CheckedChanged += new System.EventHandler(this.RB_Size_CheckedChanged);
            // 
            // RB_SizeXY
            // 
            this.RB_SizeXY.AutoSize = true;
            this.RB_SizeXY.Location = new System.Drawing.Point(124, 202);
            this.RB_SizeXY.Name = "RB_SizeXY";
            this.RB_SizeXY.Size = new System.Drawing.Size(119, 20);
            this.RB_SizeXY.TabIndex = 9;
            this.RB_SizeXY.Text = "Своя кількість";
            this.RB_SizeXY.UseVisualStyleBackColor = true;
            this.RB_SizeXY.CheckedChanged += new System.EventHandler(this.RB_Size_CheckedChanged);
            // 
            // txtX
            // 
            this.txtX.Enabled = false;
            this.txtX.Location = new System.Drawing.Point(149, 224);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(39, 22);
            this.txtX.TabIndex = 10;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSize_KeyPress);
            // 
            // txtY
            // 
            this.txtY.Enabled = false;
            this.txtY.Location = new System.Drawing.Point(149, 254);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(39, 22);
            this.txtY.TabIndex = 11;
            this.txtY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSize_KeyPress);
            // 
            // X
            // 
            this.X.AutoSize = true;
            this.X.Enabled = false;
            this.X.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.X.Location = new System.Drawing.Point(120, 224);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(23, 20);
            this.X.TabIndex = 12;
            this.X.Text = "x:";
            // 
            // Y
            // 
            this.Y.AutoSize = true;
            this.Y.Enabled = false;
            this.Y.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Y.Location = new System.Drawing.Point(121, 254);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(22, 20);
            this.Y.TabIndex = 13;
            this.Y.Text = "y:";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Wheat;
            this.btnPlay.Location = new System.Drawing.Point(301, 228);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(96, 48);
            this.btnPlay.TabIndex = 14;
            this.btnPlay.Text = "Розпочати\r\nгру";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStandard
            // 
            this.btnStandard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStandard.Location = new System.Drawing.Point(25, 132);
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.Size = new System.Drawing.Size(118, 44);
            this.btnStandard.TabIndex = 4;
            this.btnStandard.Text = "Без завантаження";
            this.btnStandard.UseVisualStyleBackColor = true;
            this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
            // 
            // Picture
            // 
            this.Picture.Image = global::Puzzle.Properties.Resources.car;
            this.Picture.Location = new System.Drawing.Point(221, 12);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(199, 164);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 15;
            this.Picture.TabStop = false;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(432, 289);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.RB_SizeXY);
            this.Controls.Add(this.RB_Size100);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RB_Size48);
            this.Controls.Add(this.RB_Size16);
            this.Controls.Add(this.btnStandard);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Налаштування";
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.RadioButton RB_Size16;
        private System.Windows.Forms.RadioButton RB_Size48;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton RB_Size100;
        private System.Windows.Forms.RadioButton RB_SizeXY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label X;
        private System.Windows.Forms.Label Y;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button btnStandard;
    }
}