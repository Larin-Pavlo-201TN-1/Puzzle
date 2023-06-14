using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Puzzle
{
    public partial class Puzzle : Form
    {
        public Puzzle()
        {
            InitializeComponent();
            Play.EventHandler = new Play.MyEvent(play);
            TimerStop.EventHandler = new TimerStop.MyEvent(timerStop);
        }
        DateTime time;
        private void NewGame_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
            var rezult = MessageBox.Show("Ви дійсно хочете розпочати нову гру?", "Увага", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rezult == System.Windows.Forms.DialogResult.OK)
                {
                    timerStop();
                    ActiveMdiChild.Close();
                }
                else
                    return;
            }
            settings frm = new settings();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.AddSeconds(1);
            timeGame.Text = time.ToString("HH:mm:ss");
        }

        private void Flip_Click(object sender, EventArgs e)
        {
            imgFlip.EventHandler();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GiveUp_Click(object sender, EventArgs e)
        {
            var rezult = MessageBox.Show("Ви впевнені вцьому?", "Здатись?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rezult == System.Windows.Forms.DialogResult.OK)
            {
                ActiveMdiChild.Close();
                timeGame.Text = "00:00:00";
            }
        }

        private void ReStart_Click(object sender, EventArgs e)
        {
            var rezult = MessageBox.Show("Ви впевнені в вцьому?", "Розпочати заново?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rezult == System.Windows.Forms.DialogResult.OK)
            {
                ActiveMdiChild.Close();
                play();
            }
        }

        public void play()
        {
            //Запуск гри
            game puzzleGame = new game();
            puzzleGame.MdiParent = this;
            puzzleGame.Text = DataBank.name;
            puzzleGame.WindowState = FormWindowState.Maximized;
            puzzleGame.Show();
            GiveUp.Enabled = true;
            ReStart.Enabled = true;
            Flip.Enabled = true;

            //Запуск секундоміра
            time = new DateTime(0, 0);
            timer1.Enabled = true;
        }

        public void timerStop()
        {
            timer1.Enabled = false;

            GiveUp.Enabled = false;
            ReStart.Enabled = false;
            Flip.Enabled = false;
            DataBank.time = timeGame.Text;
        }

        private void Rules_Click(object sender, EventArgs e)
        {
            Rules rules = new Rules();
            rules.ShowDialog();
        }
    }
    public static class Play
    {
        public delegate void MyEvent();
        public static MyEvent EventHandler;
    }
    public static class TimerStop
    {
        public delegate void MyEvent();
        public static MyEvent EventHandler;
    }

}
