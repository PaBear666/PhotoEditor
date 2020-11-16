namespace PhotoEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BasicImg = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.minBarText = new System.Windows.Forms.Label();
            this.maxBarText = new System.Windows.Forms.Label();
            this.minBar = new System.Windows.Forms.TrackBar();
            this.maxBar = new System.Windows.Forms.TrackBar();
            this.OpenHough = new System.Windows.Forms.Button();
            this.HoughBasic = new System.Windows.Forms.PictureBox();
            this.HoughResult = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BasicImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoughBasic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoughResult)).BeginInit();
            this.SuspendLayout();
            // 
            // BasicImg
            // 
            this.BasicImg.Location = new System.Drawing.Point(12, 12);
            this.BasicImg.Name = "BasicImg";
            this.BasicImg.Size = new System.Drawing.Size(370, 366);
            this.BasicImg.TabIndex = 0;
            this.BasicImg.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(478, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(370, 366);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(12, 397);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(370, 366);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(478, 397);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(370, 366);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // minBarText
            // 
            this.minBarText.AutoSize = true;
            this.minBarText.Location = new System.Drawing.Point(88, 799);
            this.minBarText.Name = "minBarText";
            this.minBarText.Size = new System.Drawing.Size(19, 15);
            this.minBarText.TabIndex = 2;
            this.minBarText.Text = "20";
            // 
            // maxBarText
            // 
            this.maxBarText.AutoSize = true;
            this.maxBarText.Location = new System.Drawing.Point(288, 799);
            this.maxBarText.Name = "maxBarText";
            this.maxBarText.Size = new System.Drawing.Size(19, 15);
            this.maxBarText.TabIndex = 2;
            this.maxBarText.Text = "60";
            // 
            // minBar
            // 
            this.minBar.Location = new System.Drawing.Point(12, 769);
            this.minBar.Maximum = 100;
            this.minBar.Minimum = 1;
            this.minBar.Name = "minBar";
            this.minBar.Size = new System.Drawing.Size(183, 45);
            this.minBar.TabIndex = 1;
            this.minBar.Value = 20;
            this.minBar.Scroll += new System.EventHandler(this.MinBar_Scroll);
            this.minBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.minBar_MouseUp);
            // 
            // maxBar
            // 
            this.maxBar.Location = new System.Drawing.Point(201, 769);
            this.maxBar.Maximum = 100;
            this.maxBar.Minimum = 1;
            this.maxBar.Name = "maxBar";
            this.maxBar.Size = new System.Drawing.Size(181, 45);
            this.maxBar.TabIndex = 1;
            this.maxBar.Value = 60;
            this.maxBar.Scroll += new System.EventHandler(this.MaxBar_Scroll);
            this.maxBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.maxBar_MouseUp);
            // 
            // OpenHough
            // 
            this.OpenHough.Location = new System.Drawing.Point(513, 780);
            this.OpenHough.Name = "OpenHough";
            this.OpenHough.Size = new System.Drawing.Size(303, 53);
            this.OpenHough.TabIndex = 3;
            this.OpenHough.Text = "Открыть преобразование хафа";
            this.OpenHough.UseVisualStyleBackColor = true;
            this.OpenHough.Click += new System.EventHandler(this.OpenHough_Click);
            // 
            // HoughBasic
            // 
            this.HoughBasic.Location = new System.Drawing.Point(918, 12);
            this.HoughBasic.Name = "HoughBasic";
            this.HoughBasic.Size = new System.Drawing.Size(370, 366);
            this.HoughBasic.TabIndex = 0;
            this.HoughBasic.TabStop = false;
            // 
            // HoughResult
            // 
            this.HoughResult.Location = new System.Drawing.Point(918, 397);
            this.HoughResult.Name = "HoughResult";
            this.HoughResult.Size = new System.Drawing.Size(370, 366);
            this.HoughResult.TabIndex = 0;
            this.HoughResult.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 855);
            this.Controls.Add(this.HoughResult);
            this.Controls.Add(this.HoughBasic);
            this.Controls.Add(this.OpenHough);
            this.Controls.Add(this.maxBarText);
            this.Controls.Add(this.minBarText);
            this.Controls.Add(this.maxBar);
            this.Controls.Add(this.minBar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BasicImg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BasicImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoughBasic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoughResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BasicImg;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label minBarText;
        private System.Windows.Forms.Label maxBarText;
        private System.Windows.Forms.TrackBar minBar;
        private System.Windows.Forms.TrackBar maxBar;
        private System.Windows.Forms.Button OpenHough;
        private System.Windows.Forms.PictureBox HoughBasic;
        private System.Windows.Forms.PictureBox HoughResult;
    }
}

