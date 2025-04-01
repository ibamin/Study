using Cshap_group_project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pr0731
{
    public partial class Form9 : Form
    {

        private const int PictureBoxSize = 150; // PictureBox 크기
        private int score = 0; // 점수
        private Random random = new Random();
        inventory Inventory_;
        public Form9()
        {
            InitializeComponent();
        }
        public Form9(inventory inventory)
        {
            InitializeComponent();
            Inventory_ = inventory;
        }
        private void Form9_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = random.Next(0, this.ClientSize.Width - PictureBoxSize);
            int y = random.Next(0, this.ClientSize.Height - PictureBoxSize);
            pictureBox1.Location = new Point(x, y);



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            score++;
            lbScore.Text = "Score: " + score;

            if (score == 5)
            {
                timer1.Stop();
                MessageBox.Show("아이템 나사를 획득했다");
                DialogResult = DialogResult.OK;
                //매개변수를 위한 객체생성
                PictureBox pb = new PictureBox();
                pb.Name = "screw"; //나사
                pb.Image = ImageList.Images[0];
                Inventory_.New_Item(pb, e);
                this.Close();
            }



        }


        private void lbScore_Click(object sender, EventArgs e)
        {

        }
    }
}
