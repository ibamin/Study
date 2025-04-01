namespace Pr0731
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lbScore = new System.Windows.Forms.Label();
            ImageList = new System.Windows.Forms.ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(152, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(372, 290);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lbScore
            // 
            lbScore.AutoSize = true;
            lbScore.Font = new System.Drawing.Font("궁서체", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbScore.ForeColor = System.Drawing.Color.Firebrick;
            lbScore.Location = new System.Drawing.Point(240, 485);
            lbScore.Name = "lbScore";
            lbScore.Size = new System.Drawing.Size(177, 35);
            lbScore.TabIndex = 1;
            lbScore.Text = "Score : 0";
            lbScore.Click += lbScore_Click;
            // 
            // ImageList
            // 
            ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            ImageList.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ImageList.ImageStream");
            ImageList.TransparentColor = System.Drawing.Color.Transparent;
            ImageList.Images.SetKeyName(0, "item(나사).jpg");
            // 
            // Form9
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            ClientSize = new System.Drawing.Size(699, 553);
            Controls.Add(lbScore);
            Controls.Add(pictureBox1);
            Name = "Form9";
            Text = "Form9";
            Load += Form9_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}