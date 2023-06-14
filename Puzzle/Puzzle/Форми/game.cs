using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using PuzzleDLL;

namespace Puzzle
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
            imgFlip.EventHandler = new imgFlip.MyEvent(flip);
            CloseFRM.EventHandler = new CloseFRM.MyEvent(Cls);
        }
        int column = DataBank.Column > 16 ? 15 : DataBank.Column;
        int row = DataBank.Row > 16 ? 15 : DataBank.Row; 
        Bitmap rearrangeIMG;
        public bool clck = false;
        int posX = 0, posY = 0;
        Bitmap[,] arrPuzzleWin;

        private void game_Load(object sender, EventArgs e)
        {
            arrPuzzleWin = new Bitmap[row, column];
            puzzleDLL.createPuzzleBox(DataBank.imgPuzzle, arrPuzzleWin, field, this, row, column);
        }

        //Переміщення пазлів
        private void field_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (clck)
            {
                clck = false;
                DataBank.count++;
                bool w = puzzleDLL.movingPuzzle(field, arrPuzzleWin, rearrangeIMG, posX, posY, row, column);
                if (w)
                {
                    TimerStop.EventHandler();
                    Win win = new Win();
                    win.ShowDialog();
                }
            }
            else
            {
                rearrangeIMG = (Bitmap)field.CurrentCell.Value;
                posX = field.CurrentCell.ColumnIndex;
                posY = field.CurrentCell.RowIndex;
                clck = true;
            }
        }

        private void game_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimerStop.EventHandler();
        }

        //Перевернення зображення
        public void flip()
        {
            if(clck)
            {
                DataBank.count++;
                clck = false;
                bool w = puzzleDLL.flipPuzzle(rearrangeIMG, field, arrPuzzleWin, posX, posY, row, column);
                if (w)
                {
                    TimerStop.EventHandler();
                    Win win = new Win();
                    win.ShowDialog();
                }
            }
            else
                MessageBox.Show("Спочатку виберіть пазл для перевернення", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Cls()
        {
            Close();
        }

    }

    public static class imgFlip
    {
        public delegate void MyEvent();
        public static MyEvent EventHandler;
    }
    public static class CloseFRM
    {
        public delegate void MyEvent();
        public static MyEvent EventHandler;
    }
}
