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
    public partial class Form2 : Form
    {
        int time = 0;
        int it1 = 0; //세면대 아이템
        int it2 = 0; //욕조 아이템
        int it6 = 0; // 욕조 손잡이 (나사)
        public DialogResult last_quize = DialogResult.Cancel;
        inventory inventory;

        public Form2(inventory inven)
        {
            InitializeComponent();

            // 아이템을 배경에 맞게 투명화 
            item1.Parent = pictureBox1;
            item1.BackColor = Color.Transparent;

            item2.Parent = pictureBox1;
            item2.BackColor = Color.Transparent;

            item3.Parent = pictureBox1;
            item3.BackColor = Color.Transparent;

            item4.Parent = pictureBox1;
            item4.BackColor = Color.Transparent;

            item5.Parent = pictureBox1;
            item5.BackColor = Color.Transparent;

            item6.Parent = pictureBox1;
            item6.BackColor = Color.Transparent;

            inventory = inven;
        }

        private void item1_Click(object sender, EventArgs e) // 하수구 클릭 -> 쪽지 발견

        {
            Form3 window3 = new Form3();


            if (window3.ShowDialog() == DialogResult.OK)
                lbtext.Text = "욕실 바닥에서 비밀번호가 적힌 쪽지를 발견했다.";

            else
                lbtext.Text = "욕실 바닥에 무언가 있는 듯 하다.";
        }

        private void item2_Click(object sender, EventArgs e) //거울 클릭 -> 귀신사진
        {
            Form4 window4 = new Form4(inventory);
            if (window4.ShowDialog() == DialogResult.OK)
            {

                lbtext.Text = "세면대와 관련된 밧줄을 획득했다.";
                it1++;
            }

            else
                lbtext.Text = "거울에 무언가 있는 듯 하다.";
        }

        private void item3_Click(object sender, EventArgs e) // 세면대 클릭 -> 힌트1
        {

            if (it1 == 1)
            {
                Form5 window5 = new Form5(inventory);

                if (window5.ShowDialog() == DialogResult.OK)
                {

                    lbtext.Text = "범인에 대한 힌트가 적힌 쪽지를 찾았다";
                }
            }


            else // 아이템을 찾지 못했다면
                lbtext.Text = "세면대에서 힌트를 얻으려면 밧줄을 찾아야해";


        }

        private void item5_Click(object sender, EventArgs e) //욕조 클릭 -> 힌트2
        {
            //DialogResult a = DialogResult.Cancel;
            Form12 window12 = new Form12(inventory);
            //window12.ShowDialog();

            //Form8 window8 = new Form8();
            if (window12.ShowDialog() == DialogResult.OK)
            {
                lbtext.Text = "욕조 안에서 힌트가 적힌 쪽지를 발견했다";
                last_quize = DialogResult.OK;
                //a = window12.a;
            }


            /*
            
            if (a == DialogResult.OK)
            {
                Form7 form7 = new Form7();
                form7.ShowDialog();
                it2++;
            }
            
            */

            else
            {
                lbtext.Text = "비밀번호를 풀어야 힌트를 얻을 수 있을 것 같다.";
            }

        }

        private void item4_Click(object sender, EventArgs e) // 변기 클릭 -> 귀신사진
        {
            Form9 window9 = new Form9(inventory);


            if (window9.ShowDialog() == DialogResult.OK)
            {
                lbtext.Text = "욕조 손잡이와 관련된 나사를 획득했다.";
                it6++;
            }

            else
                lbtext.Text = "변기에 무언가 있는 듯 하다.";
            /*
            if (a == DialogResult.OK)
            {
                Form7 form7 = new Form7();
                form7.ShowDialog();
            }
            */
        }

        private void item6_Click(object sender, EventArgs e) // 욕조 물 틀기 -> 힌트3
        {

            if (it6 == 0)
            {
                lbtext.Text = "욕조 손잡이에서 힌트를 얻으려면 나사가 필요해";
            }

            if (it6 == 1)
            {
                Form10 window10 = new Form10(inventory);
                window10.ShowDialog();
                lbtext.Text = "욕조 손잡이에서 힌트가 적힌 쪽지를 발견했다.";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I)
            {
                inventory.ShowDialog();
            }
        }

        private void Moon_Click(object sender, EventArgs e) //화장실 문 클릭시 거실로 이동
        {
            this.Visible = false;
        }
    }
}
