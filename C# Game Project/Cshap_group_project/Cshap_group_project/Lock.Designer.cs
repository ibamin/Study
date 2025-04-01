namespace hello0731
{
    partial class Lock
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
            comboBox1 = new System.Windows.Forms.ComboBox();
            comboBox2 = new System.Windows.Forms.ComboBox();
            comboBox3 = new System.Windows.Forms.ComboBox();
            comboBox4 = new System.Windows.Forms.ComboBox();
            button1 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            comboBox1.Location = new System.Drawing.Point(634, 135);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(37, 23);
            comboBox1.TabIndex = 8;
            comboBox1.MouseHover += comboBox1_MouseHover;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            comboBox2.Location = new System.Drawing.Point(634, 179);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(37, 23);
            comboBox2.TabIndex = 9;
            comboBox2.MouseHover += comboBox2_MouseHover;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            comboBox3.Location = new System.Drawing.Point(634, 228);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new System.Drawing.Size(37, 23);
            comboBox3.TabIndex = 10;
            comboBox3.MouseHover += comboBox3_MouseHover;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            comboBox4.Location = new System.Drawing.Point(634, 276);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new System.Drawing.Size(37, 23);
            comboBox4.TabIndex = 11;
            comboBox4.SelectedIndexChanged += comboBox4_SelectedIndexChanged;
            comboBox4.MouseHover += comboBox4_MouseHover;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Goldenrod;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(634, 317);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(39, 23);
            button1.TabIndex = 12;
            button1.Text = "●";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("궁서체", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(516, 52);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 19);
            label1.TabIndex = 13;
            label1.Text = "       ";
            // 
            // Lock
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            BackgroundImage = Cshap_group_project.Properties.Resources.Lvr_lock_21;
            ClientSize = new System.Drawing.Size(814, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Lock";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Lock";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}