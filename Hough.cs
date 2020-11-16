using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PhotoEditor
{
    
    class Hough
    {
        public PictureBox BitMapBasic { get; }

        public PictureBox BitMapResult { get; }

        public Hough(PictureBox bitmapBasic, PictureBox bitmapResult)
        {
            BitMapBasic = bitmapBasic;
            BitMapResult = bitmapResult;
        }
        public void MakeHough() 
        {
            
        }
    }
}
