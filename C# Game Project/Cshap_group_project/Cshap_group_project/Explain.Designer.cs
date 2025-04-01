namespace Cshap_group_project
{
    partial class Explain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Explain));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            imageList1 = new System.Windows.Forms.ImageList(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("궁서체", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Firebrick;
            label1.Location = new System.Drawing.Point(317, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 32);
            label1.TabIndex = 0;
            label1.Text = "설명서";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("궁서체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Firebrick;
            label2.Location = new System.Drawing.Point(317, 159);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 21);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Location = new System.Drawing.Point(36, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(256, 256);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "ladder_image_256.png");
            imageList1.Images.SetKeyName(1, "key2_256.jpg");
            imageList1.Images.SetKeyName(2, "서류봉투_256.jpg");
            imageList1.Images.SetKeyName(3, "key_256.jpg");
            imageList1.Images.SetKeyName(4, "item(밧줄)_256.png");
            imageList1.Images.SetKeyName(5, "item(나사)_256.jpg");
            imageList1.Images.SetKeyName(6, "밀대1_256.jpg");
            imageList1.Images.SetKeyName(7, "쪽지2_256.png");
            imageList1.Images.SetKeyName(8, "깨진거울_256.jpg");
            imageList1.Images.SetKeyName(9, "녹슨칼.jpg");
            imageList1.Images.SetKeyName(10, "서재키_256.png");
            imageList1.Images.SetKeyName(11, "Lvr_Key_UnderGround_256.png");
            imageList1.Images.SetKeyName(12, "쪽지_256.jpg");
            imageList1.Images.SetKeyName(13, "쪽지_256.jpg");
            imageList1.Images.SetKeyName(14, "쪽지_256.jpg");
            // 
            // Explain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Explain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Explain";
            Load += Explain_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}