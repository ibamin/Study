using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cshap_group_project
{
    public partial class Underground : Form
    {
        inventory inventory_; //선언만


        public Underground()
        {
            InitializeComponent();
            inventory_ = new inventory();

        }
        public Underground(inventory inven)
        {
            InitializeComponent();
            inventory_ = inven; //초기화

        }


        //쪽지 클릭시



        //냉장고 클릭시
        private void button2_Click(object sender, EventArgs e)
        {
            Under_Fridge fridge = new Under_Fridge();
            fridge.ShowDialog();
        }

        //양동이 클릭시
        private void bucket_Click(object sender, EventArgs e)
        {
            //양동이 클릭시
            label6.Visible = true;
            label6.Text = "특이점은 없어보인다.";

        }

        //서랍 클릭시
        private void label1_Click(object sender, EventArgs e)//서랍
        {
            Inspace space = new Inspace(inventory_); //서랍안 공간으로 이동
            space.ShowDialog();
        }

        //쪽지 클릭시
        private void label2_Click(object sender, EventArgs e)//쪽지
        {
            int check = 0;
            for (int i = 0; i < inventory_.buttons.Count; i++)
            {
                if (inventory_.buttons[i].Name == "label2")
                {
                    check = 1;
                }
            }
            if (check == 0)
            {
                Under_Paper paper = new Under_Paper();
                paper.ShowDialog();
                label6.Visible = true;
                label6.Text = "쪽지를 획득했다.";
                PictureBox pb = new PictureBox();
                pb.Name = "label2";
                pb.Image = imageList1.Images[2];
                inventory_.New_Item(pb, e);
            }
            else
            {
                MessageBox.Show("이미 인벤토리에 있습니다.");
            }
        }
        //냉장고  클릭시
        private void lb_Fridge_Click(object sender, EventArgs e)
        {
            Under_Fridge fridge = new Under_Fridge();
            fridge.ShowDialog();
        }
        //긴 막대 클릭시
        private void label5_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label6.Text = "긴 막대를 휙득했다.";

            PictureBox pb = new PictureBox();
            pb.Name = "label5";
            pb.Image = imageList1.Images[0];
            inventory_.New_Item(pb, e);
        }
        //시체 1클릭시
        private void label1_Click_1(object sender, EventArgs e)
        {
            label6.Visible = true;
            label6.Text = "잔인하게 살해 당해져 있다.";
        }

        //마우스 커서 가져다 댈때
        private void label5_MouseEnter(object sender, EventArgs e)//막대기
        {
            label6.Visible = true;
            label6.Text = "이걸로 무언가 끌어 내릴수 있을거 같기도..?";
        }
        //마우스 커서 땔때
        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }
        //쪽지에 마우스 커서 가져다 댈때
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label6.Visible = true;
            label6.Text = "무언가 적혀있는 쪽지가 있다..";
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void bucket_MouseEnter(object sender, EventArgs e)
        {
            label6.Visible = true;
            label6.Text = "양동이에 무언가 가득 차 있다.";
        }

        private void bucket_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void label1_MouseEnter(object sender, EventArgs e)//시체 1
        {
            label6.Visible = true;
            label6.Text = "내 친구 준영...!!";
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void label4_MouseEnter(object sender, EventArgs e)//시체 2
        {
            label6.Visible = true;
            label6.Text = "내 친구 성구...!!";
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void label3_MouseEnter(object sender, EventArgs e)//키갖고 있는 시체
        {
            label6.Visible = true;
            label6.Text = "직장동료.. 중헌이.. 몸에 무언가 보인다";
        }

        private void label3_MouseLeave(object sender, EventArgs e)//
        {
            label6.Visible = false;
        }

        private void lb_space_MouseEnter(object sender, EventArgs e)//서랍
        {
            label6.Visible = true;
            label6.Text = "서랍인데 자물쇠로 굳게 잠겨있다";
            label6.Text = "자물쇠는 4자리 번호로 되어있다..";
        }

        private void lb_space_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)//타이머 안씀
        {

        }


        //단서 있는 시체를 클릭시.
        private void label3_Click(object sender, EventArgs e)
        {
            int check = 0;

            for (int i = 0; i < inventory_.buttons.Count; i++)
            {
                if (inventory_.buttons[i].Name == "label5")
                {
                    check = 1;
                }
            }
            if (check == 0)
            {
                MessageBox.Show("시체를 끌어내릴 무언가 필요하다.");
            }
            else
            {
                Deadbody deadbody = new Deadbody();
                deadbody.ShowDialog();

                if (deadbody.dialogResult == DialogResult.OK)
                {

                    label6.Visible = true;
                    label6.Text = "시체에 있는 단서를 발견했다.";

                    pictureBox1.Visible = true;
                }
            }


        }

        //냉장고 마우스 커서
        private void lb_Fridge_MouseEnter(object sender, EventArgs e)
        {
            label6.Visible = true;
            label6.Text = "냉장고";
        }

        private void lb_Fridge_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }


        //사진 커서 
        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label6.Visible = true;
            label6.Text = "무언가 사진이 보인다.";
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        //사진 클릭시
        private void label7_Click(object sender, EventArgs e)
        {
            Picture picture = new Picture();
            picture.ShowDialog();
        }


        //시체 2 클릭시
        private void label4_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label6.Text = "잔인하게 살해 당해져 있다.";
        }


        //거울 마우스 커서
        private void lb_mirror_MouseEnter(object sender, EventArgs e)
        {
            label6.Visible = true;
            label6.Text = "큰 거울이 보인다";
        }

        private void lb_mirror_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void lb_gotolibary_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Underground_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I)
            {
                inventory_.ShowDialog();
            }
        }

        private void lb_mirror_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label6.Text = "거울에 쪽지 같은게 비친거 같기도 하다.";
        }

        private void lb_gotolibary_MouseEnter(object sender, EventArgs e)
        {
            label6.Visible = true;
            label6.Text = "1층으로 가는 문이다.";
        }

        private void lb_gotolibary_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }
    }
}
