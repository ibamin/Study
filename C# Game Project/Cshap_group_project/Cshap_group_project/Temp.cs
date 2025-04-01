using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Cshap_group_project
{
    public partial class Temp : Form
    {
        string collect = "moble";
        public bool red_book = false;
        goast goast1 = new goast();
        ImageList answer_image = new ImageList();
        List<PictureBox> answer = new List<PictureBox>();
        int time = 0;
        int cnt = 0;
        bool tf = true;
        public Temp()
        {
            InitializeComponent();

            answer.Add(pB_answer1);
            answer.Add(pB_answer2);
            answer.Add(pB_answer3);
            answer.Add(pB_answer4);
            answer.Add(pB_answer5);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            answer_image.Images.Add(pictureBox1.Image);
            textBox1.Text += "k";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            answer_image.Images.Add(pictureBox5.Image);
            textBox1.Text += "m";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            answer_image.Images.Add(pictureBox10.Image);
            textBox1.Text += "b";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            answer_image.Images.Add(pictureBox4.Image);
            textBox1.Text += "o";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            answer_image.Images.Add(pictureBox2.Image);
            textBox1.Text += "l";
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            answer_image.Images.Add(pictureBox7.Image);
            textBox1.Text += "e";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            answer_image.Images.Add(pictureBox6.Image);
            textBox1.Text += "u";
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            answer_image.Images.Add(pictureBox9.Image);
            textBox1.Text += "i";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            answer_image.Images.Add(pictureBox8.Image);
            textBox1.Text += "f";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            answer_image.Images.Add(pictureBox3.Image);
            textBox1.Text += "a";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            answer_image.Images.Add(pictureBox11.Image);
            textBox1.Text += "c";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            answer_image.Images.Add(pictureBox12.Image);
            textBox1.Text += "y";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "fuck")
            {
                goast1 = new goast();
                goast1.BackgroundImage = imageList1.Images[26];
                goast1.ShowDialog();
                textBox1.Text = "";
                answer_image = new ImageList();
            }
            if (textBox1.Text == "face")
            {
                goast1 = new goast();
                goast1.BackgroundImage = imageList1.Images[27];
                goast1.ShowDialog();
                textBox1.Text = "";
                answer_image = new ImageList();
            }
            if (textBox1.Text == "moble")
            {
                paper newpaper = new paper("우리의 생활기록부를 확인해줘,,,,");
                newpaper.ShowDialog();
                red_book = true;
                textBox1.Text = "";
                answer_image = new ImageList();
            }
            if (textBox1.Text.Length == 5)
            {
                textBox1.Text = "";
                answer_image = new ImageList();
            }
            answer_show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        void answer_show()
        {
            for (int i = 0; i < answer_image.Images.Count; i++)
            {
                answer[i].Image = answer_image.Images[i];
            }
        }
        private void Temp_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void pB_answer3_Click(object sender, EventArgs e)
        {

        }

        private void pB_answer5_Click(object sender, EventArgs e)
        {

        }
    }
}
