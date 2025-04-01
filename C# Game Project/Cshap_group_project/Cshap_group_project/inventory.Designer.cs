using System.Runtime.InteropServices;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cshap_group_project
{
    partial class inventory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //버튼 둥글게
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect,
            int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inventory));
            btn_Observe = new Button();
            panel1 = new Panel();
            imageList1 = new ImageList(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Observe
            // 
            btn_Observe.BackColor = Color.Orange;
            btn_Observe.FlatStyle = FlatStyle.Flat;
            btn_Observe.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Observe.Location = new Point(275, 13);
            btn_Observe.Name = "btn_Observe";
            btn_Observe.Size = new Size(155, 94);
            btn_Observe.TabIndex = 19;
            btn_Observe.Text = "자세히보기";
            btn_Observe.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_Observe);
            panel1.Location = new Point(2, 372);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 117);
            panel1.TabIndex = 21;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "ladder_image.png");
            // 
            // inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(727, 493);
            Controls.Add(panel1);
            Name = "inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "inventory";
            FormClosing += inventory_FormClosing;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btn_Observe;
        private Panel panel1;
        private ImageList imageList1;
    }
}