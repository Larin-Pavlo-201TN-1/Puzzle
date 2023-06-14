using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle
{
    public partial class Win : Form
    {
        public Win()
        {
            InitializeComponent();
        }

        private void Win_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseFRM.EventHandler();
        }

        private void Win_Load(object sender, EventArgs e)
        {
            Name_txt.Text += DataBank.name;
            Time_txt.Text += DataBank.time;
            Count_txt.Text += DataBank.count.ToString();
        }
    }
}
