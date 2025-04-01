namespace Pr0731
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            item1 = new System.Windows.Forms.Label();
            item2 = new System.Windows.Forms.Label();
            item3 = new System.Windows.Forms.Label();
            item4 = new System.Windows.Forms.Label();
            item5 = new System.Windows.Forms.Label();
            item6 = new System.Windows.Forms.Label();
            lbtext = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Moon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Moon).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(1334, 699);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // item1
            // 
            item1.AutoSize = true;
            item1.BackColor = System.Drawing.Color.Transparent;
            item1.Location = new System.Drawing.Point(647, 438);
            item1.Name = "item1";
            item1.Size = new System.Drawing.Size(27, 15);
            item1.TabIndex = 1;
            item1.Text = "     ";
            item1.Click += item1_Click;
            // 
            // item2
            // 
            item2.AutoSize = true;
            item2.BackColor = System.Drawing.Color.Transparent;
            item2.ForeColor = System.Drawing.Color.Black;
            item2.Location = new System.Drawing.Point(414, 199);
            item2.Name = "item2";
            item2.Size = new System.Drawing.Size(71, 45);
            item2.TabIndex = 2;
            item2.Text = "         \r\n                \r\n         ";
            item2.Click += item2_Click;
            // 
            // item3
            // 
            item3.AutoSize = true;
            item3.BackColor = System.Drawing.Color.Transparent;
            item3.Location = new System.Drawing.Point(465, 326);
            item3.Name = "item3";
            item3.Size = new System.Drawing.Size(43, 30);
            item3.TabIndex = 3;
            item3.Text = "       \r\n         ";
            item3.Click += item3_Click;
            // 
            // item4
            // 
            item4.AutoSize = true;
            item4.BackColor = System.Drawing.Color.Transparent;
            item4.ForeColor = System.Drawing.Color.Black;
            item4.Location = new System.Drawing.Point(292, 480);
            item4.Name = "item4";
            item4.Size = new System.Drawing.Size(31, 15);
            item4.TabIndex = 4;
            item4.Text = "      ";
            item4.Click += item4_Click;
            // 
            // item5
            // 
            item5.AutoSize = true;
            item5.BackColor = System.Drawing.Color.Transparent;
            item5.Location = new System.Drawing.Point(813, 278);
            item5.Name = "item5";
            item5.Size = new System.Drawing.Size(123, 45);
            item5.TabIndex = 5;
            item5.Text = "                   \r\n               \r\n                             ";
            item5.Click += item5_Click;
            // 
            // item6
            // 
            item6.AutoSize = true;
            item6.Location = new System.Drawing.Point(726, 199);
            item6.Name = "item6";
            item6.Size = new System.Drawing.Size(39, 15);
            item6.TabIndex = 6;
            item6.Text = "        ";
            item6.Click += item6_Click;
            // 
            // lbtext
            // 
            lbtext.AutoSize = true;
            lbtext.BackColor = System.Drawing.Color.Black;
            lbtext.Font = new System.Drawing.Font("궁서체", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbtext.ForeColor = System.Drawing.Color.White;
            lbtext.Location = new System.Drawing.Point(717, 614);
            lbtext.Name = "lbtext";
            lbtext.Size = new System.Drawing.Size(94, 24);
            lbtext.TabIndex = 7;
            lbtext.Text = ". . . .";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Moon
            // 
            Moon.Image = (System.Drawing.Image)resources.GetObject("Moon.Image");
            Moon.Location = new System.Drawing.Point(57, 513);
            Moon.Name = "Moon";
            Moon.Size = new System.Drawing.Size(108, 142);
            Moon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Moon.TabIndex = 8;
            Moon.TabStop = false;
            Moon.Click += Moon_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1333, 699);
            Controls.Add(Moon);
            Controls.Add(lbtext);
            Controls.Add(item6);
            Controls.Add(item5);
            Controls.Add(item4);
            Controls.Add(item3);
            Controls.Add(item2);
            Controls.Add(item1);
            Controls.Add(pictureBox1);
            KeyPreview = true;
            Name = "Form2";
            Text = "Form2";
            KeyDown += Form2_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Moon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label item1;
        private System.Windows.Forms.Label item2;
        private System.Windows.Forms.Label item3;
        private System.Windows.Forms.Label item4;
        private System.Windows.Forms.Label item5;
        private System.Windows.Forms.Label item6;
        private System.Windows.Forms.Label lbtext;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox Moon;
    }
}