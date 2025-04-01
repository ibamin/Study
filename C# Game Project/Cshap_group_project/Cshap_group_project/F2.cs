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
    public partial class F2 : Form
    {
        bool light = true;
        int key_point1 = 0, tick_count = 0;
        PictureBox temp_picture_box = new PictureBox();
        ImageList items = new ImageList();
        inventory inven;
        Temp library = new Temp();
        public EventHandler Btn_ADD;
        public F2()
        {
            InitializeComponent();
            lb_Message.Location = new Point(600, 682);
            this.KeyDown += Open_Inven;
            this.inven = new inventory();
            Btn_ADD += new EventHandler(inven.New_Item);
        }
        public F2(inventory inven)
        {
            InitializeComponent();
            lb_Message.Location = new Point(600, 682);
            this.KeyDown += Open_Inven;
            this.inven = inven;
            Btn_ADD += new EventHandler(inven.New_Item);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lb_Message.Text = "전기는 아직\n들어오는 것 같다.";
            if (light)
            {
                temp_picture_box.Image = this.BackgroundImage;
                this.BackgroundImage = pB_black.Image;
                lb_switch.BackColor = Color.Yellow;
                light = false;

            }
            else
            {
                this.BackgroundImage = temp_picture_box.Image;
                lb_switch.BackColor = Color.Transparent;
                light = true;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            bool tf = true;
            for (int i = 0; i < inven.buttons.Count; i++)
            {
                if (inven.buttons[i].Name == "Briefcase")
                {
                    library.ShowDialog();
                    tf = false;
                }
            }
            if (tf)
                lb_Message.Text = "알수없는 어려운 \n책들이 꽂혀있다.";
        }

        private void lb_ladder_Click(object sender, EventArgs e) //사다리 아이템 흭득
        {
            object tmp = sender;
            if (check("ladder"))
            {
                lb_Message.Text = "이미 찾은 아이템이다.";
            }
            else
            {
                PictureBox picture_box = new PictureBox();
                picture_box.Image = imageList1.Images[0];
                picture_box.Name = "ladder";
                inven.New_Item(picture_box, e);
                lb_Message.Text = "사다리를 주웠다.";
            }
        }

        private void lb_hiding_key_Click(object sender, EventArgs e) //황금키 흭득
        {
            if (check("Gold_Key"))
            {
                lb_Message.Text = "이미 찾은 아이템이다";
                key_point1 = -1;
            }
            else if (key_point1 == 0)
            {
                lb_Message.Text = "무언가 반짝이는\n물건이 보인다\n손을 넣어 5번 정도\n시도를 하면\n꺼낼 수 있을 거 같다. ";
                key_point1++;
                timer1.Start();
            }
            else if (key_point1 == 1)
            {
                lb_Message.Text = "1번째 시도 아직 \n감이 안잡힌다.";
            }
            else if (key_point1 == 2)
            {
                lb_Message.Text = "2번째 시도 손끝에 \n무언가 스쳤다.";
            }
            else if (key_point1 == 3)
            {
                lb_Message.Text = "3번째 시도 손가락에 걸어 \n올리다가 떨어졌다.";
            }else if (key_point1 == 4)
            {
                lb_Message.Text = "4번째 시도 다올렸는데 \n아쉽게 떨어졌다.";
            }
            else if (key_point1 == 5)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = imageList1.Images[1];
                pictureBox.Name = "Gold_Key";
                inven.New_Item(pictureBox, e);
                key_point1 = -1;
                tick_count = 0;
                lb_Message.Text = "반짝이는 열쇠를 얻었다.";
                timer1.Stop();
            }
            key_point1++;
        }

        //화장실 비밀번호에 대한 힌트 추가예정
        private void lb_red_book_Click(object sender, EventArgs e)
        {
            if (library.red_book)
            {
                string toilet_pass = "그/그녀는 항상 A+(4,5)를 받는 뛰어난 학생이었어...";
                paper newpaper = new paper(toilet_pass);
                newpaper.ShowDialog();
            }

            else
                lb_Message.Text = "뭔가 꺼림직한 책이다.\n O O O 고등학교 생활기록부 \n라고 적혀 있는거 같다.";
        }

        private void Open_Inven(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I)
            {
                inven.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (light)
            {
                temp_picture_box.Image = this.BackgroundImage;
                this.BackgroundImage = pB_black.Image;
                lb_switch.BackColor = Color.Yellow;
                light = false;
            }
            else
            {
                this.BackgroundImage = temp_picture_box.Image;
                lb_switch.BackColor = Color.Transparent;
                light = true;
            }
            tick_count++;
            if (tick_count == 15)
            {
                timer1.Stop();
                key_point1 = 0;
                tick_count = 0;
                goast temp = new goast();
                temp.BackgroundImage = imageList1.Images[2];
                temp.ShowDialog();
            }
        }

        private void lb_need_key1_Click(object sender, EventArgs e)
        {
            bool tf = true;
            for (int i = 0; i < inven.buttons.Count; i++)
            {
                if (inven.buttons[i].Name == "Gold_Key")
                {
                    paper newpaper = new paper("M O B L E");
                    newpaper.ShowDialog();
                    tf = false;
                    break;
                }
                else if (inven.buttons[i].Name == "Old_Key")
                {
                    lb_Message.Text = "오래된 열쇠로는 \n 열수 없을거 같다.";
                    tf = false;
                }
            }
            if (tf)
                lb_Message.Text = "서랍을 열 수 있는 열쇠가\n 필요한거 같다.";
        }

        private void lb_Briefcase_Click(object sender, EventArgs e) //서류 봉투 흭득
        {
            bool tf = true;
            for (int i = 0; i < inven.buttons.Count; i++)
            {
                if (check("Briefcase"))
                {
                    tf = false;
                    lb_Message.Text = "이미 찾은 아이템이다";
                    break;
                }

                if (inven.buttons[i].Name == "ladder")
                {
                    lb_Message.Text = "서류 봉투를 얻었다.";
                    PictureBox picture_box = new PictureBox();
                    picture_box.Image = imageList1.Images[4];
                    picture_box.Name = "Briefcase";
                    inven.New_Item(picture_box, e);
                    tf = false;
                    break;
                }
            }
            if (tf)
                lb_Message.Text = "너무 높은 곳에 있다.";
        }

        private void lb_hiding_key2_Click(object sender, EventArgs e) //오래된 열쇠 흭득
        {
            if (check("Old_Key"))
            {
                lb_Message.Text = "이미 찾은 아이템이다";
                key_point1 = -1;
            }
            else if (key_point1 == 0)
            {
                lb_Message.Text = "무언가 반짝이는\n물건이 보인다\n손을 넣어 5번 정도\n시도를 하면\n꺼낼 수 있을 거 같다. ";
                key_point1++;
                timer1.Start();
            }
            else if (key_point1 == 1)
            {
                lb_Message.Text = "1번째 시도 아직 \n감이 안잡힌다.";
            }
            else if (key_point1 == 2)
            {
                lb_Message.Text = "2번째 시도 손끝에 \n무언가 스쳤다.";
            }
            else if (key_point1 == 3)
            {
                lb_Message.Text = "3번째 시도 손가락에 걸어 \n올리다가 떨어졌다.";
            }
            else if (key_point1 == 4)
            {
                lb_Message.Text = "4번째 시도 다올렸는데 \n아쉽게 떨어졌다.";
            }
            else if (key_point1 == 5)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = imageList1.Images[3];
                pictureBox.Name = "Old_Key";
                inven.New_Item(pictureBox, e);
                key_point1 = -1;
                tick_count = 0;
                lb_Message.Text = "열쇠를 얻었다.";
                timer1.Stop();
            }
            key_point1++;
        }

        private void lb__Click(object sender, EventArgs e)
        {
            lb_Message.Text = "비어 있는 공간에 낡은\n책들이쓰러져있다.";
        }

        private void lb_story_paper_Click(object sender, EventArgs e) //스토리
        {
            string story = "나는 너를 잊지못해 너와 같이 찍은 사진을\n손이까져도....종이가 닳도록 보는게\n취미야";
            paper newpaper = new paper(story);
            newpaper.ShowDialog();
        }

        private void lb_Fake_library2_Click(object sender, EventArgs e)
        {
            lb_Message.Text = "의미 없는 잡동산이들만\n쌓여 있다";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            lb_Message.Text = "알수없는 어려운 \n책들이 꽂혀있다.";
        }

        //중복 아이템 체크
        bool check(string item_name)
        {
            for (int i = 0; i < inven.buttons.Count; i++)
            {
                if (inven.buttons[i].Name == item_name)
                    return true;
            }
            return false;
        }

        private void lb_gotoLivingRoom_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
