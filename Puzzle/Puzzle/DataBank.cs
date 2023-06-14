using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    static class DataBank
    {
        public static int Column = 4;
        public static int Row = 4;
        public static string name = "Player1";
        public static Bitmap imgPuzzle = new Bitmap(Properties.Resources.car);
        public static int imgX = 20;
        public static int imgY = 20;
        public static int count = 0;
        public static string time = "00:00:00";
    }
}
