using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cshap_group_project
{
    public partial class Under_Fridge : Form
    {
        int count;
        public Image originalBack;
        PictureBox pictureBox1;
        Button btn;
        private Warning previousForm;


        public Under_Fridge()
        {
            InitializeComponent();
            this.count = 0;
            originalBack = this.BackgroundImage;
            //CreateButton();
        }

        //private void CreateButton()
        //{

        //}

        private void label1_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 1)
                this.BackgroundImage = imageList1.Images[0];
            else
                this.BackgroundImage = originalBack;

            if (count == 5)
            {
                btn = new Button();
                pictureBox1 = new PictureBox();
                pictureBox1.Image = imageList1.Images[2];
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                btn.BackgroundImage = pictureBox1.Image;
                btn.Size = pictureBox1.Size;
                btn.Location = new Point(300, 30);
                this.Controls.Add(btn);
                btn.Click += Btn_Click;
            }

        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            if (previousForm != null && !previousForm.IsDisposed)
            {
                previousForm.Close();
            }

            Warning warning = new Warning();
            warning.Show();

            previousForm = warning;
          
        }


        private void btn_Click(object sender, EventArgs e)
        {
            // 버튼을 클릭했을 때 동작할 코드를 작성합니다.

            Warning warning = new Warning();
            warning.ShowDialog();
        }






    }





}




