namespace Pr0731
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            item8 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // item8
            // 
            item8.AutoSize = true;
            item8.BackColor = System.Drawing.Color.Transparent;
            item8.Location = new System.Drawing.Point(331, 358);
            item8.Name = "item8";
            item8.Size = new System.Drawing.Size(31, 30);
            item8.TabIndex = 1;
            item8.Text = "      \r\n      ";
            item8.Click += item8_Click;
            // 
            // Form7
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(532, 491);
            Controls.Add(item8);
            ForeColor = System.Drawing.SystemColors.ControlText;
            Name = "Form7";
            Text = "Form7";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label item8;
    }
}