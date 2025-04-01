namespace hello0731
{
    partial class fridge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fridge));
            btn_frg = new System.Windows.Forms.Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lb_fg1 = new System.Windows.Forms.Label();
            timer2 = new System.Windows.Forms.Timer(components);
            label1 = new System.Windows.Forms.Label();
            btn_frg2 = new System.Windows.Forms.Button();
            btn_frg1 = new System.Windows.Forms.Button();
            lb_fg2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_frg
            // 
            btn_frg.BackColor = System.Drawing.Color.Transparent;
            btn_frg.FlatAppearance.BorderSize = 0;
            btn_frg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_frg.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_frg.ForeColor = System.Drawing.Color.Crimson;
            btn_frg.Location = new System.Drawing.Point(184, 186);
            btn_frg.Name = "btn_frg";
            btn_frg.Size = new System.Drawing.Size(31, 33);
            btn_frg.TabIndex = 0;
            btn_frg.Text = "★";
            btn_frg.UseVisualStyleBackColor = false;
            btn_frg.Click += button1_Click;
            btn_frg.MouseLeave += btn_frg_MouseLeave;
            btn_frg.MouseHover += btn_frg_MouseHover_1;
            // 
            // timer1
            // 
            timer1.Interval = 200;
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(141, 216);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(60, 26);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lb_fg1
            // 
            lb_fg1.AutoSize = true;
            lb_fg1.BackColor = System.Drawing.Color.Transparent;
            lb_fg1.Font = new System.Drawing.Font("궁서", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_fg1.ForeColor = System.Drawing.Color.Red;
            lb_fg1.Location = new System.Drawing.Point(184, 34);
            lb_fg1.Name = "lb_fg1";
            lb_fg1.Size = new System.Drawing.Size(0, 24);
            lb_fg1.TabIndex = 2;
            // 
            // timer2
            // 
            timer2.Interval = 200;
            timer2.Tick += timer2_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(279, 209);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(0, 15);
            label1.TabIndex = 3;
            // 
            // btn_frg2
            // 
            btn_frg2.BackColor = System.Drawing.Color.Red;
            btn_frg2.FlatAppearance.BorderSize = 0;
            btn_frg2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_frg2.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_frg2.ForeColor = System.Drawing.Color.White;
            btn_frg2.Location = new System.Drawing.Point(601, 259);
            btn_frg2.Name = "btn_frg2";
            btn_frg2.Size = new System.Drawing.Size(75, 23);
            btn_frg2.TabIndex = 5;
            btn_frg2.Text = " 나가기";
            btn_frg2.UseVisualStyleBackColor = false;
            btn_frg2.Click += btn_frg2_Click;
            // 
            // btn_frg1
            // 
            btn_frg1.BackColor = System.Drawing.Color.Blue;
            btn_frg1.FlatAppearance.BorderSize = 0;
            btn_frg1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_frg1.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_frg1.ForeColor = System.Drawing.Color.White;
            btn_frg1.Location = new System.Drawing.Point(601, 219);
            btn_frg1.Name = "btn_frg1";
            btn_frg1.Size = new System.Drawing.Size(75, 23);
            btn_frg1.TabIndex = 4;
            btn_frg1.Text = "도전";
            btn_frg1.UseVisualStyleBackColor = false;
            btn_frg1.Click += btn_frg1_Click;
            // 
            // lb_fg2
            // 
            lb_fg2.AutoSize = true;
            lb_fg2.BackColor = System.Drawing.Color.Transparent;
            lb_fg2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_fg2.ForeColor = System.Drawing.Color.White;
            lb_fg2.Location = new System.Drawing.Point(201, 257);
            lb_fg2.Name = "lb_fg2";
            lb_fg2.Size = new System.Drawing.Size(0, 21);
            lb_fg2.TabIndex = 6;
            // 
            // fridge
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Cshap_group_project.Properties.Resources.Lvr_Image16;
            ClientSize = new System.Drawing.Size(540, 304);
            Controls.Add(lb_fg2);
            Controls.Add(btn_frg2);
            Controls.Add(btn_frg1);
            Controls.Add(label1);
            Controls.Add(lb_fg1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_frg);
            Name = "fridge";
            Text = "fridge";
            Load += lb_frg2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btn_frg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_fg1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_frg2;
        private System.Windows.Forms.Button btn_frg1;
        private System.Windows.Forms.Label lb_fg2;
    }
}