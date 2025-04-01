using Cshap_group_project;
using Pr0731;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test;

namespace hello0731
{
    public partial class LivingRoom : Form
    {
        inventory inven = new inventory();
        F2 f2;
        Underground underground;
        Form2 toilet;
        Lock lck = new Lock();
        Endding ended;

        DateTime start = DateTime.Now;
        public int timerNum = 0;
        public int MirrorNum = 0;

        public int BoxNum = 0;
        public int BoxLock = 2;

        public int MirrorItem = 0;
        public static int KnifeItem = 0;


        public int BoxOpen = 0;
        public int fridgeNum = 0;

        public static int Key_UnderGround = 0;


        public static int MirrorAc = 0;

        public LivingRoom(inventory inven, F2 f2, Underground underground, Form2 toilet)
        {
            InitializeComponent();
            this.KeyDown += Open_Inven;
            KeyPreview = true;
            this.inven = inven;
            this.f2 = f2;
            this.underground = underground;
            this.toilet = toilet;
            f2.Visible = false;
            underground.Visible = false;
            toilet.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lck.Locker != DialogResult.OK)
                lck.ShowDialog();
            if (lck.Locker == DialogResult.OK)
                toilet.ShowDialog(); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (fridgeNum == 0)
            {
                lb_Text.Text = "냉장고가 있다. 아직 열 필요가 없을것 같다.";
                //  timer3.Start();
            }
            else
            {
                fridge fg = new fridge(inven, KnifeItem);
                fg.ShowDialog();
            }
        }


        // 버튼 클릭시 하단에 하얀 글씨로 텍스트 나옴.
        private void button1_Click_1(object sender, EventArgs e)
        {
            bool tf = true;
            for (int i = 0; i < inven.buttons.Count; i++)
            {
                if (inven.buttons[i].Name == "Under_Paper")
                {
                    this.Visible = false;
                    f2.ShowDialog();
                    this.Visible = true;
                    tf = false;
                }
            }
            if (tf)
                timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //timerNum  0으로 초기화 후,
            timerNum++;
            lb_Text.Text = "키가 없어 2층 서재에 올라 갈 수 없다";

            if (timerNum > 30)       // 타이머 속성: 100ms    //  30 = 3초 
            {
                timer1.Stop();
                lb_Text.Text = "";      //3초가 지나면 텍스트 띄워졌던 텍스트 없어짐
                timerNum = 0;           //timerNum 초기화
            }
        }
        /*
        private void btn_Gls_Click(object sender, EventArgs e)
        {
            MirrorNum++;
            if (MirrorNum <= 4)
            {
                lb_Text.Text = "깨진 거울이다. 만지면 다칠 것 같다.\n위험해 보이니 건들지 말자.";
                timer2.Start();
            }
            if (MirrorNum == 5)
            {
                lb_Text.Text = "위험해 보이긴 해도 쓸만 해 보인다. 챙겨 갈까 ??";
                timer2.Start();
            }
            if (MirrorNum == 6)
            {
                lb_Text.Text = "깨진 거울을 획득하였다.";
                object tmp = sender;
                inven.New_Item(btn_Gls.Image, e);
                timer2.Start();


                MirrorItem = 1;
            }

            //if (inven.buttons.Exists(isStringEqualsbutton2.Image)) ;

        }
        */
        private void Open_Inven(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.I)
            {
                inven.ShowDialog();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            timerNum++;
            if (timerNum > 15)
            {
                timer2.Stop();
                lb_Text.Text = "";

                timerNum = 0;

            }




        }


        private void button5_Click_1(object sender, EventArgs e)
        {

        }

        private void bt_Box_Click(object sender, EventArgs e)
        {
            BoxNum++;
            if (BoxNum == 1)
            {
                lb_Text.Text = "박스가 굉장히 두껍게 포장되어있다. \n무언가 도구로 뜯어야 할 것 같다.\n(박스를 옮길수는 없다.)";
                //  timer3.Start();
            }
            else if ((BoxNum >= 2) & (MirrorItem == 0) & (KnifeItem == 0))
            {
                lb_Text.Text = "박스가 굉장히 두껍게 포장되어있다. \n무언가 도구로 뜯어야 할 것 같다.\n(박스를 옮길수는 없다.)";
                //   timer3.Start();
            }
            else if ((BoxNum >= 2) & (MirrorItem > 0) & (KnifeItem == 0))
            {
                lb_Text.Text = "[깨진 거울 조각]으로 포장을 어느정도 뜯어냈다.\n하지만 다른 도구가 더 필요할 것 같다";
                // timer3.Start();
            }
            else if ((BoxNum >= 2) & (MirrorItem == 0) & (KnifeItem > 0))
            {
                lb_Text.Text = "[주방용 칼]로 포장을 어느정도 뜯어냈다.\n 하지만 다른 도구가 더 필요할 것 같다.";
            }
            else if ((BoxNum >= 2) & (MirrorItem > 0) & (KnifeItem > 0) & (BoxOpen == 0))
            {
                lb_Text.Text = "[깨진 거울조각]과 [주방용 칼]로\n단단하게 포장된 박스를 뜯어냈다\n한번 더 클릭하면 박스를 열 수 있다.\n";
                BoxOpen++;
            }
            else if ((BoxNum >= 2) & (MirrorItem > 0) & (KnifeItem > 0) & (BoxOpen != 0))
            {
                BoxOpen BxOp = new BoxOpen(inven);
                BxOp.ShowDialog();
            }

            /*
            if (BoxNum == 1)
            {
                lb_Text.Text = "박스가 굉장히 두껍게 포장되어있다. \n무언가 도구로 뜯어야 할 것 같다.";
            }
            else if ((BoxNum > 1) & (MirrorItem == 1))
            {
                lb_Text.Text = "깨진 거울 조각으로 포장을 어느정도 뜯어냈다.\n하지만 다른 도구가 필요할 것 같다";
            }
            */
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timerNum++;

            if (timerNum >= 19)
            {
                timer3.Stop();
                lb_Text.Text = "";

                timerNum = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lb_Text.Text = "비어있는 물잔 이다.";
            //  timer3.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lb_Text.Text = "창문이 열리지 않는다. 다른 방법을 찾아보자.";
            //timer3.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lb_Text.Text = "음식이 있다. 배는 너무 고프지만,\n음식이 상해 먹을 수 없다.";
            // timer3.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            lb_Text.Text = "화로가 있다.\n차갑게 식어있어 불을 \n다시 붙이기는 쉽지 않을 것 같다";
            //  timer3.Start();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //f
            TestQuiz TQ = new TestQuiz();
            TQ.ShowDialog();
            timer3.Start();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            lb_Text.Text = "음식의 레시피가 적혀있다.\n옆에 상한 음식의 레시피인듯 하다.\n냉장고에 뭐가 있는지 확인해볼까??";
            //timer3.Start();
            fridgeNum = 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DateTime end = DateTime.Now;
            Form12 lastquiz = new Form12(inven);
            if (toilet.last_quize == DialogResult.Cancel)
            {
                paper newpaer = new paper("아직 나의 이름을 찾아주지 않았어.,,");
                newpaer.ShowDialog();
            }
            else
            {
                lastquiz.label1.Text = "비밀번호는 3글자 입니다.";
                lastquiz.ShowDialog();
                
                if (lastquiz.last_quiz_check == DialogResult.OK)
                {
                    ended = new Endding(); // happy ending
                    ended.Show();

                }
               
                    TimeSpan timeElapsed = end - start;
                    TimeSpan thirtyMinutes = TimeSpan.FromMinutes(30);

                    if (timeElapsed > thirtyMinutes)
                    {
                        lb_Text.Text = "너무 늦은거 같다....\nBad Endding";
                    }
                    else
                    {
                        lb_Text.Text = "더러운 이집을 나갈 수 있게 되었다.";
                       
                    }
               
            }
        }

        private void btn_chair_Click(object sender, EventArgs e)
        {
            lb_Text.Text = " 의자가 넘어져있다.";
        }

        private void btn_edge_Click(object sender, EventArgs e)
        {
            lb_Text.Text = "먼지가 쌓인 구석이다.. \n별 볼일 없어보인다.";
            // timer3.Start();
        }

        private void btn_Gls_Click_1(object sender, EventArgs e)
        {
            MirrorNum++;
            /*
            if (MirrorNum <= 5)
            {
                lb_Text.Text = "깨진 거울이다. 만지면 다칠 것 같다.\n위험해 보이니 건들지 말자.";
                timer2.Start();
            }
            if (MirrorNum == 6)
            {
                lb_Text.Text = "위험해 보이긴 해도 쓸만 해 보인다.\n 챙겨 갈까 ??";
                timer2.Start();
            }
            if (MirrorNum == 7)
            {
                lb_Text.Text = "[깨진 거울]을 획득하였다.";
                object tmp = sender;
                PictureBox pb = new PictureBox();
                pb.Image = btn_Gls.Image;
                pb.Name = "깨진 거울";

                inven.New_Item(pb, e);
                timer2.Start();

                MirrorItem = 1;
            }
            */
            //if (inven.buttons.Exists(isStringEqualsbutton2.Image)) ;

            if (MirrorAc == 0)
            {
                lb_Text.Text = "깨진 거울이다. 만지면 다칠 것 같다.\n위험해 보이니 건들지 말자.";
            }
            else
            {
                lb_Text.Text = "[깨진 거울]을 획득하였다.";
                lb_Text.Text = "[깨진 거울]을 획득하였다.";
                object tmp = sender;
                PictureBox pb = new PictureBox();
                pb.Image = btn_Gls.Image;
                pb.Name = "깨진 거울";

                inven.New_Item(pb, e);
                MirrorItem = 1;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            bool tf = true;
            for (int i = 0; i < inven.buttons.Count; i++)
            {
                if (inven.buttons[i].Name == "지하실키")
                {
                    this.Visible = false;
                    underground.ShowDialog();
                    this.Visible = true;
                    tf = false;
                }
            }
            if (tf)
                lb_Text.Text = "지하실 열쇠가 없어 들어갈 수 없다.";
        }

        private void bt_pp_Click(object sender, EventArgs e)
        {
            lb_Text.Text = "집이 난장판이다.";
            // timer3.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lb_Text.Text = "옆에 화로에 쓰던 장작인것 같다.";
        }
    }
}
