using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PhotoEditorAlg.SetPhoto(BasicImg);
            PhotoEditorAlg.MakePhotoGray(BasicImg,pictureBox2);
            PhotoEditorAlg.MakePhotoСontrast(pictureBox2, pictureBox3, minBar.Value / 100f, maxBar.Value / 100f);
            PhotoEditorAlg.MakePhotoGray(BasicImg, pictureBox4);
        }

        private void MinBar_Scroll(object sender, EventArgs e)
        {
            if (minBar.Value > maxBar.Value)
            {
                maxBar.Value = minBar.Value + 1;
                MaxBar_Scroll(sender, e);
            }
            minBarText.Text = minBar.Value.ToString();
        }

        private void MaxBar_Scroll(object sender, EventArgs e)
        {
            if (minBar.Value > maxBar.Value)
            {
                minBar.Value = maxBar.Value - 1;
                MinBar_Scroll(sender, e);
            }
            maxBarText.Text = maxBar.Value.ToString();
        }

        private void minBar_MouseUp(object sender, MouseEventArgs e)
        {
           
            PhotoEditorAlg.MakePhotoСontrast(pictureBox2, pictureBox3, minBar.Value / 100f, maxBar.Value / 100f);
        }

        private void maxBar_MouseUp(object sender, MouseEventArgs e)
        {
           
            PhotoEditorAlg.MakePhotoСontrast(pictureBox2, pictureBox3, minBar.Value / 100f, maxBar.Value / 100f);
        }

        private void OpenHough_Click(object sender, EventArgs e)
        {
            if (this.Width != 1350)
                this.Width = 1350;
            else
                this.Width = 900;
            if(HoughBasic.Image == null) 
            {
                
            }
        }
    }
}
