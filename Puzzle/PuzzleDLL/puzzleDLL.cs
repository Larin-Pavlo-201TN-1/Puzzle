using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace PuzzleDLL
{
    public class puzzleDLL
    {
        //створення поля гри
        public static void createPuzzleBox(Bitmap IMG, Bitmap[,] arrPuzzleWin, DataGridView field, Form form, int row, int column)
        {
            Bitmap[,] arrPuzzle = new Bitmap[row, column];
            int imgPuzzleWidth, imgPuzzleHeight;

            //Налаштування DataGridView
            field.AllowUserToAddRows = false;
            field.ColumnHeadersVisible = false;
            field.RowHeadersVisible = false;
            field.AllowUserToResizeColumns = false;
            field.AllowUserToResizeRows = false;

            //Створення поля пазлів
            DataTable table = new DataTable();
            for (int i = 0; i < column; i++)
            {
                table.Columns.Add(i.ToString(), typeof(Image));
            }
            for (int i = 0; i < row; i++)
            {
                table.Rows.Add(new string[] { });
            }
            field.DataSource = table;

            //Розміри елементу DataGridView
            elmSize(out imgPuzzleWidth, out imgPuzzleHeight, IMG.Size.Width, IMG.Size.Height, form.Width, form.Height, column, row);

            //Задання ширини і висоти
            for (int i = 0; i < field.ColumnCount; i++)
            {
                ((DataGridViewImageColumn)field.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                //ширина
                field.Columns[i].Width = imgPuzzleWidth;
            }
            //Висота
            field.RowTemplate.Height = imgPuzzleHeight;

            //Поділ на частини
            cutIMG(IMG, IMG.Size.Width, IMG.Size.Height, arrPuzzle, arrPuzzleWin, imgPuzzleWidth, imgPuzzleHeight, row, column);

            //Рандомайзер
            rndPuzzle(arrPuzzle);

            //Перевернення пазлів
            rndFlip(arrPuzzle);

            for (int j = 0; j < row; j++)
            {
                for (int i = 0; i < column; i++)
                {
                    field[i, j].Value = arrPuzzle[j, i];
                }
            }
        }

        //Знаходження розміру елементу
        static void elmSize(out int imgPuzzleWidth, out int imgPuzzleHeight, int IMGWidth, int IMGHeight, int Width, int Height, int column, int row)
        {
            double ySize = (double)Height / IMGHeight;
            double xSize = (double)Width / IMGWidth;
            if (IMGWidth < Width && IMGHeight < Height)
            {
                imgPuzzleWidth = Convert.ToInt32(IMGWidth / column);
                imgPuzzleHeight = Convert.ToInt32(IMGHeight / row);
            }
            else
            {
                if (ySize <= xSize)
                {
                    imgPuzzleWidth = Convert.ToInt32(IMGWidth * ySize / column * 0.945);
                    imgPuzzleHeight = Convert.ToInt32(IMGHeight * ySize / row * 0.945);
                }
                else
                {
                    imgPuzzleWidth = Convert.ToInt32(IMGWidth * xSize / column * 0.945);
                    imgPuzzleHeight = Convert.ToInt32(IMGHeight * xSize / row * 0.945);
                }
            }
        }


        //Поділ зображення на частини
        static void cutIMG(Bitmap IMG, int IMGWidth, int IMGHeight, Bitmap[,] arrPuzzle, Bitmap[,] arrPuzzleWin, int IMGPuzzleWidth, int IMGPuzzleHeight, int row, int column)
        {
            Bitmap pasteIMG;
            Graphics paintIMG;
            int sizeIMGY, sizeIMGX;
            for (int j = 0; j < row; j++)
            {
                if (j * IMGHeight / row + IMGPuzzleHeight > IMGHeight)
                    sizeIMGY = IMGHeight - j * IMGHeight / row;
                else sizeIMGY = IMGHeight / row;
                for (int i = 0; i < column; i++)
                {
                    if (i * IMGHeight / column + IMGPuzzleWidth > IMGHeight)
                        sizeIMGX = IMGWidth - i * IMGWidth / column;
                    else sizeIMGX = IMGWidth / column;
                    pasteIMG = new Bitmap(sizeIMGX, sizeIMGY);
                    paintIMG = Graphics.FromImage(pasteIMG);
                    paintIMG.DrawImage(IMG, new Rectangle(new Point(0, 0), pasteIMG.Size), i * IMGWidth / column, j * IMGHeight / row, sizeIMGX, sizeIMGY, GraphicsUnit.Pixel);
                    arrPuzzle[j, i] = pasteIMG;
                    arrPuzzleWin[j, i] = pasteIMG;
                }
            }

        }

        //Перемішування пазлів
        static void rndPuzzle(Bitmap[,] arrPuzzle)
        {
            Random rnd = new Random();
            for (int i = 0; i < arrPuzzle.Length * 10; i++)
            {
                int x1 = rnd.Next(0, arrPuzzle.GetLength(0)),
                    x2 = rnd.Next(0, arrPuzzle.GetLength(0)),
                    y1 = rnd.Next(0, arrPuzzle.GetLength(1)),
                    y2 = rnd.Next(0, arrPuzzle.GetLength(1));
                Bitmap temp = arrPuzzle[x1, y1];
                arrPuzzle[x1, y1] = arrPuzzle[x2, y2];
                arrPuzzle[x2, y2] = temp;
            }
        }

        //Перевернення пазлу з імовірністю 1/2
        static void rndFlip(Bitmap[,] arrPuzzle)
        {
            Random rnd = new Random();
            for (int i = 0; i < arrPuzzle.GetLength(0); i++)
            {
                for (int k = 0; k < arrPuzzle.GetLength(1); k++)
                {
                    if (Convert.ToBoolean(rnd.Next(0, 2)))
                    {
                        Bitmap bmp = new Bitmap(arrPuzzle[i, k]);
                        bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        arrPuzzle[i, k] = bmp;
                    }
                }
            }
        }

        //Переміщення пазлів
        public static bool movingPuzzle(DataGridView field, Bitmap[,] arrPuzzleWin, Bitmap rearrangeIMG, int posX,int posY, int row, int column)
        {
            field[posX, posY].Value = (Bitmap)field.CurrentCell.Value;
            field.CurrentCell.Value = rearrangeIMG;

            return Win(field, arrPuzzleWin, row, column);
        }

        //Перевертання пазлів
        public static bool flipPuzzle(Bitmap rearrangeIMG, DataGridView field, Bitmap[,] arrPuzzleWin, int posX, int posY, int row, int column)
        {
            Bitmap bmp = new Bitmap(rearrangeIMG);
            bmp.RotateFlip(RotateFlipType.Rotate180FlipNone);
            field[posX, posY].Value = bmp;

            return Win(field, arrPuzzleWin, row, column);
        }

        //Перевірка на перемогу
        public static bool Win(DataGridView field, Bitmap[,] arrPuzzleWin, int row, int column)
        {
            
            bool result = true;
            for (int i = 0; i < row; i++)
            {
                for (int k = 0; k < column; k++)
                {
                    Bitmap bmp1 = new Bitmap((Bitmap)field[k, i].Value);
                    Bitmap bmp2 = arrPuzzleWin[i, k];
                    if (bmp1 == null || bmp2 == null)
                        return false;
                    if (!bmp1.Size.Equals(bmp2.Size) || !bmp1.PixelFormat.Equals(bmp2.PixelFormat))
                        return false;
                    int bytes = bmp1.Width * bmp1.Height * (Image.GetPixelFormatSize(bmp1.PixelFormat) / 8);
                    byte[] b1bytes = new byte[bytes];
                    byte[] b2bytes = new byte[bytes];
                    try
                    {
                        BitmapData bitmapData1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadOnly, bmp1.PixelFormat);
                        BitmapData bitmapData2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadOnly, bmp2.PixelFormat);
                        Marshal.Copy(bitmapData1.Scan0, b1bytes, 0, bytes);
                        Marshal.Copy(bitmapData2.Scan0, b2bytes, 0, bytes);
                        for (int n = 0; n <= bytes - 1; n++)
                        {
                            if (b1bytes[n] != b2bytes[n])
                            {
                                bmp1.UnlockBits(bitmapData1);
                                bmp2.UnlockBits(bitmapData2);
                                return false;
                            }
                        }
                        bmp1.UnlockBits(bitmapData1);
                        bmp2.UnlockBits(bitmapData2);
                    }
                    catch { }
                }
            }
            return result;
        }
    }
}
