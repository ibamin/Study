namespace Pr0731
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            hint1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            lbhint1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            btn2 = new System.Windows.Forms.Button();
            lbhint5 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            imageList1 = new System.Windows.Forms.ImageList(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // hint1
            // 
            hint1.AutoSize = true;
            hint1.BackColor = System.Drawing.Color.Transparent;
            hint1.Font = new System.Drawing.Font("궁서체", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            hint1.ForeColor = System.Drawing.Color.Brown;
            hint1.Location = new System.Drawing.Point(262, 126);
            hint1.Name = "hint1";
            hint1.Size = new System.Drawing.Size(267, 240);
            hint1.TabIndex = 1;
            hint1.Text = "열 개의 빗\r\n\r\n세 가지 맛\r\n\r\n한 개의  ?";
            // 
            // textBox1
            // 
            textBox1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox1.Location = new System.Drawing.Point(282, 387);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(223, 46);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lbhint1
            // 
            lbhint1.AutoSize = true;
            lbhint1.BackColor = System.Drawing.Color.Black;
            lbhint1.Font = new System.Drawing.Font("궁서체", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbhint1.ForeColor = System.Drawing.Color.Firebrick;
            lbhint1.Location = new System.Drawing.Point(89, 35);
            lbhint1.Name = "lbhint1";
            lbhint1.Size = new System.Drawing.Size(644, 37);
            lbhint1.TabIndex = 7;
            lbhint1.Text = "범인의 이름은 ~(으)로 시작합니다.";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn2);
            panel1.Controls.Add(lbhint5);
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(806, 90);
            panel1.TabIndex = 8;
            // 
            // btn2
            // 
            btn2.BackColor = System.Drawing.Color.Black;
            btn2.Font = new System.Drawing.Font("궁서체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn2.ForeColor = System.Drawing.Color.Firebrick;
            btn2.Location = new System.Drawing.Point(700, 25);
            btn2.Name = "btn2";
            btn2.Size = new System.Drawing.Size(75, 37);
            btn2.TabIndex = 10;
            btn2.Text = "힌트";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // lbhint5
            // 
            lbhint5.AutoSize = true;
            lbhint5.BackColor = System.Drawing.Color.Black;
            lbhint5.Font = new System.Drawing.Font("궁서체", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbhint5.ForeColor = System.Drawing.Color.Firebrick;
            lbhint5.Location = new System.Drawing.Point(77, 33);
            lbhint5.Name = "lbhint5";
            lbhint5.Size = new System.Drawing.Size(0, 21);
            lbhint5.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbhint1);
            panel2.Location = new System.Drawing.Point(0, 459);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(806, 125);
            panel2.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "쪽지.jpg");
            // 
            // Form6
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(806, 584);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(hint1);
            Name = "Form6";
            Text = "Form6";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label hint1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbhint1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbhint5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.ImageList imageList1;
    }
}