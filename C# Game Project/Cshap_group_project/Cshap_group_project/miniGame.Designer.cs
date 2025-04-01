namespace hello0731
{
    partial class miniGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(miniGame));
            hScrollBar1 = new System.Windows.Forms.HScrollBar();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            btn_Stop = new System.Windows.Forms.Button();
            lb_Score = new System.Windows.Forms.Label();
            pb_Game5 = new System.Windows.Forms.PictureBox();
            pb_Game6 = new System.Windows.Forms.PictureBox();
            pb_Game7 = new System.Windows.Forms.PictureBox();
            timer3 = new System.Windows.Forms.Timer(components);
            pb_Game8 = new System.Windows.Forms.PictureBox();
            label2 = new System.Windows.Forms.Label();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            lb_GameClear = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lb_score2 = new System.Windows.Forms.Label();
            lb_score1 = new System.Windows.Forms.Label();
            BgKnife = new System.Windows.Forms.PictureBox();
            pb_Game4 = new System.Windows.Forms.PictureBox();
            pb_Game3 = new System.Windows.Forms.PictureBox();
            pb_Game2 = new System.Windows.Forms.PictureBox();
            pb_Game1 = new System.Windows.Forms.PictureBox();
            timer_msb = new System.Windows.Forms.Timer(components);
            btn_knife = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pb_Game5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Game6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Game7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Game8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BgKnife).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Game4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Game3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Game2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Game1).BeginInit();
            SuspendLayout();
            // 
            // hScrollBar1
            // 
            hScrollBar1.LargeChange = 1;
            hScrollBar1.Location = new System.Drawing.Point(-14, 28);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new System.Drawing.Size(812, 55);
            hScrollBar1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // timer2
            // 
            timer2.Interval = 1;
            // 
            // btn_Stop
            // 
            btn_Stop.BackColor = System.Drawing.SystemColors.ButtonShadow;
            btn_Stop.FlatAppearance.BorderSize = 0;
            btn_Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_Stop.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Stop.ForeColor = System.Drawing.Color.DimGray;
            btn_Stop.Location = new System.Drawing.Point(676, 428);
            btn_Stop.Name = "btn_Stop";
            btn_Stop.Size = new System.Drawing.Size(89, 30);
            btn_Stop.TabIndex = 4;
            btn_Stop.Text = "Hit";
            btn_Stop.UseVisualStyleBackColor = false;
            btn_Stop.Click += btn_Stop_Click;
            // 
            // lb_Score
            // 
            lb_Score.AutoSize = true;
            lb_Score.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_Score.ForeColor = System.Drawing.Color.White;
            lb_Score.Location = new System.Drawing.Point(379, 35);
            lb_Score.Name = "lb_Score";
            lb_Score.Size = new System.Drawing.Size(46, 23);
            lb_Score.TabIndex = 5;
            lb_Score.Text = "- - -";
            // 
            // pb_Game5
            // 
            pb_Game5.BackColor = System.Drawing.Color.Red;
            pb_Game5.Location = new System.Drawing.Point(3, 14);
            pb_Game5.Name = "pb_Game5";
            pb_Game5.Size = new System.Drawing.Size(809, 11);
            pb_Game5.TabIndex = 10;
            pb_Game5.TabStop = false;
            // 
            // pb_Game6
            // 
            pb_Game6.BackColor = System.Drawing.Color.Red;
            pb_Game6.Location = new System.Drawing.Point(0, 84);
            pb_Game6.Name = "pb_Game6";
            pb_Game6.Size = new System.Drawing.Size(809, 12);
            pb_Game6.TabIndex = 11;
            pb_Game6.TabStop = false;
            // 
            // pb_Game7
            // 
            pb_Game7.BackColor = System.Drawing.Color.Silver;
            pb_Game7.Location = new System.Drawing.Point(0, 11);
            pb_Game7.Name = "pb_Game7";
            pb_Game7.Size = new System.Drawing.Size(13, 72);
            pb_Game7.TabIndex = 13;
            pb_Game7.TabStop = false;
            // 
            // timer3
            // 
            timer3.Interval = 40;
            timer3.Tick += timer3_Tick;
            // 
            // pb_Game8
            // 
            pb_Game8.BackColor = System.Drawing.Color.Red;
            pb_Game8.Location = new System.Drawing.Point(785, 13);
            pb_Game8.Name = "pb_Game8";
            pb_Game8.Size = new System.Drawing.Size(10, 83);
            pb_Game8.TabIndex = 19;
            pb_Game8.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(280, 94);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(304, 32);
            label2.TabIndex = 20;
            label2.Text = "칼 / 횟수에 따른 유리 변화";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new System.Drawing.Point(0, -3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            splitContainer1.Panel1.Controls.Add(lb_GameClear);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(lb_score2);
            splitContainer1.Panel1.Controls.Add(lb_score1);
            splitContainer1.Panel1.Controls.Add(lb_Score);
            splitContainer1.Panel1.Controls.Add(btn_Stop);
            splitContainer1.Panel1.Controls.Add(BgKnife);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = System.Drawing.Color.Brown;
            splitContainer1.Panel2.Controls.Add(pb_Game4);
            splitContainer1.Panel2.Controls.Add(pb_Game3);
            splitContainer1.Panel2.Controls.Add(pb_Game2);
            splitContainer1.Panel2.Controls.Add(pb_Game1);
            splitContainer1.Panel2.Controls.Add(pb_Game8);
            splitContainer1.Panel2.Controls.Add(pb_Game5);
            splitContainer1.Panel2.Controls.Add(hScrollBar1);
            splitContainer1.Panel2.Controls.Add(pb_Game6);
            splitContainer1.Panel2.Controls.Add(pb_Game7);
            splitContainer1.Size = new System.Drawing.Size(794, 592);
            splitContainer1.SplitterDistance = 469;
            splitContainer1.TabIndex = 22;
            // 
            // lb_GameClear
            // 
            lb_GameClear.AutoSize = true;
            lb_GameClear.BackColor = System.Drawing.Color.Crimson;
            lb_GameClear.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lb_GameClear.ForeColor = System.Drawing.Color.GhostWhite;
            lb_GameClear.Location = new System.Drawing.Point(23, 94);
            lb_GameClear.Name = "lb_GameClear";
            lb_GameClear.Size = new System.Drawing.Size(0, 32);
            lb_GameClear.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("궁서", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(472, 432);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(185, 21);
            label3.TabIndex = 28;
            label3.Text = "유리를 깰 수 있다.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("궁서", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(459, 394);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(332, 21);
            label1.TabIndex = 27;
            label1.Text = "검은 상자에 맞춰 버튼을 클릭하면";
            // 
            // lb_score2
            // 
            lb_score2.AutoSize = true;
            lb_score2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_score2.ForeColor = System.Drawing.Color.White;
            lb_score2.Location = new System.Drawing.Point(443, 35);
            lb_score2.Name = "lb_score2";
            lb_score2.Size = new System.Drawing.Size(31, 25);
            lb_score2.TabIndex = 23;
            lb_score2.Text = "회";
            // 
            // lb_score1
            // 
            lb_score1.AutoSize = true;
            lb_score1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lb_score1.ForeColor = System.Drawing.Color.White;
            lb_score1.Location = new System.Drawing.Point(309, 35);
            lb_score1.Name = "lb_score1";
            lb_score1.Size = new System.Drawing.Size(50, 25);
            lb_score1.TabIndex = 22;
            lb_score1.Text = "타격";
            // 
            // BgKnife
            // 
            BgKnife.BackColor = System.Drawing.Color.Transparent;
            BgKnife.BackgroundImage = Cshap_group_project.Properties.Resources.Lvr_Knife;
            BgKnife.Image = (System.Drawing.Image)resources.GetObject("BgKnife.Image");
            BgKnife.Location = new System.Drawing.Point(-14, 35);
            BgKnife.Name = "BgKnife";
            BgKnife.Size = new System.Drawing.Size(805, 502);
            BgKnife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            BgKnife.TabIndex = 21;
            BgKnife.TabStop = false;
            // 
            // pb_Game4
            // 
            pb_Game4.BackColor = System.Drawing.Color.Black;
            pb_Game4.Location = new System.Drawing.Point(365, 84);
            pb_Game4.Name = "pb_Game4";
            pb_Game4.Size = new System.Drawing.Size(50, 12);
            pb_Game4.TabIndex = 26;
            pb_Game4.TabStop = false;
            // 
            // pb_Game3
            // 
            pb_Game3.BackColor = System.Drawing.Color.Black;
            pb_Game3.Location = new System.Drawing.Point(365, 15);
            pb_Game3.Name = "pb_Game3";
            pb_Game3.Size = new System.Drawing.Size(50, 10);
            pb_Game3.TabIndex = 25;
            pb_Game3.TabStop = false;
            // 
            // pb_Game2
            // 
            pb_Game2.BackColor = System.Drawing.Color.Black;
            pb_Game2.Location = new System.Drawing.Point(405, 19);
            pb_Game2.Name = "pb_Game2";
            pb_Game2.Size = new System.Drawing.Size(10, 78);
            pb_Game2.TabIndex = 24;
            pb_Game2.TabStop = false;
            // 
            // pb_Game1
            // 
            pb_Game1.BackColor = System.Drawing.Color.Black;
            pb_Game1.Location = new System.Drawing.Point(365, 15);
            pb_Game1.Name = "pb_Game1";
            pb_Game1.Size = new System.Drawing.Size(10, 81);
            pb_Game1.TabIndex = 23;
            pb_Game1.TabStop = false;
            // 
            // btn_knife
            // 
            btn_knife.Image = Cshap_group_project.Properties.Resources.Lvr_Knife1;
            btn_knife.Location = new System.Drawing.Point(931, 179);
            btn_knife.Name = "btn_knife";
            btn_knife.Size = new System.Drawing.Size(344, 490);
            btn_knife.TabIndex = 23;
            btn_knife.Text = "button1";
            btn_knife.UseVisualStyleBackColor = true;
            // 
            // miniGame
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ButtonFace;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            ClientSize = new System.Drawing.Size(792, 584);
            Controls.Add(btn_knife);
            Controls.Add(splitContainer1);
            Name = "miniGame";
            Text = "miniGame";
            Load += miniGame_Load;
            ((System.ComponentModel.ISupportInitialize)pb_Game5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Game6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Game7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Game8).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BgKnife).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Game4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Game3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Game2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Game1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.Label lb_Score;
        private System.Windows.Forms.PictureBox pb_Game5;
        private System.Windows.Forms.PictureBox pb_Game6;
        private System.Windows.Forms.PictureBox pb_Game7;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pb_Game8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pb_Game4;
        private System.Windows.Forms.PictureBox pb_Game3;
        private System.Windows.Forms.PictureBox pb_Game2;
        private System.Windows.Forms.PictureBox pb_Game1;
        private System.Windows.Forms.PictureBox BgKnife;
        private System.Windows.Forms.Label lb_score2;
        private System.Windows.Forms.Label lb_score1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer_msb;
        private System.Windows.Forms.Label lb_GameClear;
        private System.Windows.Forms.Button btn_knife;
    }
}