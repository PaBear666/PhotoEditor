using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PhotoEditor
{
    static class PhotoEditorAlg
    {
        /// <summary>
        /// Устанавливает изоображение
        /// </summary>
        /// <param name="pictureBox">Форма для установления</param>
        static public void SetPhoto(PictureBox pictureBox) 
        {
            pictureBox.Image = Image.FromFile("C:\\Users\\NIKITA\\OneDrive\\Рабочий стол\\PhotoForPhotoEdit.jpg");
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        /// <summary>
        /// Делает изоображение черно-белым
        /// </summary>
        /// <param name="fromPictureBox">Откуда берем изоображение</param>
        /// <param name="intoPictureBox">Форма для установления</param>
        static public void MakePhotoGray(PictureBox fromPictureBox,PictureBox intoPictureBox) 
        {
            Image imageBasicPhoto = fromPictureBox.Image;
            Bitmap bitmap = new Bitmap(imageBasicPhoto);

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    Color color = bitmap.GetPixel(x,y);
                    float r = color.R * 0.2126f;
                    float g = color.G * 0.7152f;
                    float b = color.B * 0.0722f;
                    byte res = (byte)(r + g + b);
                    Color colorResult = Color.FromArgb(255,res,res,res);
                    bitmap.SetPixel(x, y, colorResult);
                }
            }
            intoPictureBox.Image = bitmap;
            intoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        
        static public void MakePhotoСontrast(PictureBox fromPictureBox, PictureBox intoPictureBox,float min,float max) 
        {
            Bitmap bitmap = new Bitmap(fromPictureBox.Image);

            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    if(bitmap.GetPixel(x,y).GetBrightness() >= min && bitmap.GetPixel(x, y).GetBrightness() <= max) 
                        bitmap.SetPixel(x, y, Color.White);
                    else
                        bitmap.SetPixel(x, y, Color.Black);
                }
            }
            intoPictureBox.Image = bitmap;
            intoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        static public void MaskFilter(PictureBox fromPictureBox, PictureBox intoPictureBox) 
        {
            byte N = 1;
            
            Bitmap bitmap = new Bitmap(fromPictureBox.Image);
            byte[,] matr = new byte[,] { { 1,2,1 }, 
                                         { 2,4,2 }, 
                                         { 1,2,1 } };

            for (int n = 1; n < bitmap.Width; n++)
            {
                for (int m = 1; m < bitmap.Height; m++)
                {
                    float light = 0;
                    for (int i = -1; i < N; i++)
                    {
                        for (int j = -1; j < N; j++)
                        {
                            light += bitmap.GetPixel(n + i,m + j).GetBrightness()*matr[i + 1,j + 1] ;
                        }
                    }
                    light = light * 1 / 16;

                    bitmap.SetPixel(n, m, Color.FromArgb(1, (int)light, (int)light, (int)light));
                }
            }
            intoPictureBox.Image = bitmap;
            intoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        static public void MakeHough(PictureBox fromPictureBox, PictureBox intoPictureBox) 
        {
            Hough hough = new Hough(fromPictureBox, intoPictureBox);
        }

    }
}
