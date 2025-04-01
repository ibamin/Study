namespace Cshap_group_project
{
    partial class mainscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainscreen));
            timer1 = new System.Windows.Forms.Timer(components);
            BackGround = new System.Windows.Forms.PictureBox();
            lbStart = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)BackGround).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 600;
            timer1.Tick += timer1_Tick;
            // 
            // BackGround
            // 
            BackGround.BackColor = System.Drawing.Color.BlanchedAlmond;
            BackGround.Image = (System.Drawing.Image)resources.GetObject("BackGround.Image");
            BackGround.Location = new System.Drawing.Point(0, -1);
            BackGround.Name = "BackGround";
            BackGround.Size = new System.Drawing.Size(972, 582);
            BackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            BackGround.TabIndex = 1;
            BackGround.TabStop = false;
            // 
            // lbStart
            // 
            lbStart.AutoSize = true;
            lbStart.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbStart.Location = new System.Drawing.Point(453, 461);
            lbStart.Name = "lbStart";
            lbStart.Size = new System.Drawing.Size(92, 27);
            lbStart.TabIndex = 2;
            lbStart.Text = "게임시작";
            lbStart.Click += lbStart_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbTitle);
            panel1.Controls.Add(lbStart);
            panel1.Controls.Add(BackGround);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(967, 581);
            panel1.TabIndex = 0;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lbTitle.Location = new System.Drawing.Point(449, 47);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(96, 50);
            lbTitle.TabIndex = 3;
            lbTitle.Text = "탈출";
            // 
            // mainscreen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(967, 581);
            Controls.Add(panel1);
            Name = "mainscreen";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)BackGround).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox BackGround;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitle;
    }
}