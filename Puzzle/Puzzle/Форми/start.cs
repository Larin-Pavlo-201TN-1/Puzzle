using Puzzle.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Puzzle
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
            DataBank.Column = 4;
            DataBank.Row = 4;
            DataBank.imgPuzzle = new Bitmap(Properties.Resources.car);
        }
        public string filter = "Зображення(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|Усі файли(*.*)|*.*";

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                return;
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                return;
            }
            e.Handled = true;
            return;
        }

        private void RB_Size_CheckedChanged(object sender, EventArgs e)
        {
            X.Enabled = false;
            Y.Enabled = false;
            txtX.Enabled = false;
            txtY.Enabled = false;

            if (RB_Size16.Checked)
            {
                DataBank.Column = 4;
                DataBank.Row = 4;
            }
            else if (RB_Size48.Checked)
            {
                DataBank.Column = 6;
                DataBank.Row = 8;
            }
            else if (RB_Size100.Checked)
            {
                DataBank.Column = 10;
                DataBank.Row = 10;
            }
            else if (RB_SizeXY.Checked)
            {
                X.Enabled = true;
                Y.Enabled = true;
                txtX.Enabled = true;
                txtY.Enabled = true;
            }
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = filter;
            if (open.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap img = new Bitmap(open.FileName);
                    if (img.Width > 150 || img.Height > 150)
                    {
                        DataBank.imgPuzzle = new Bitmap(open.FileName);
                        Picture.Image = DataBank.imgPuzzle;
                    }
                    else
                        MessageBox.Show("Будь ласка! Виберіть файл з більшим розміром", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show("Неможливо відкрити вибраний файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            DataBank.imgPuzzle = new Bitmap(Properties.Resources.car);
            Picture.Image = DataBank.imgPuzzle;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (RB_SizeXY.Checked)
            {
                try
                {
                    DataBank.Column = Convert.ToInt32(txtX.Text);
                    DataBank.Row = Convert.ToInt32(txtY.Text);
                }
                catch
                {
                    MessageBox.Show("Будь ласка заповніть поля розмірів", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(txtX.Text == "0" || txtY.Text == "0")
                {
                    MessageBox.Show("Неможливо розділити пазл на 0 частин!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (txtName.Text == "")
                DataBank.name = "Player";
            else
                DataBank.name = txtName.Text;
            DataBank.imgX = DataBank.imgPuzzle.Width;
            DataBank.imgY = DataBank.imgPuzzle.Height;
            DataBank.count = 0;
            Close();
            Play.EventHandler();
        }
    }
}
