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

namespace hello0731
{
    public partial class miniGame : Form
    {
        inventory inven = new inventory();
        string image_path = "C:\\Users\\rob99\\OneDrive\\바탕 화면\\Main_Project\\Cshap_group_project\\Cshap_group_project\\bin";
        public int GameTimer = 0;
        public int GamePoint = 0;
        public int timer3Num = 0;

        // public int KnifeItem;

        public miniGame(inventory inven, int KnifeItem)
        {
            InitializeComponent();
            this.inven = inven;

            if (hScrollBar1.Value <= 1)
                timer1.Start();
            // BgKnife.Load(@"C:\c#\gls_img\gls2");

            //      if (hScrollBar1.Value >= 99)
            //   timer2.Start();

        }
        /*
        public void GlassImg(int x)
        {
            if (x <= 2)
            {
                BgKnife.Load(@"C:\c#\gls_img\gls0_new");
            }
            else if (x <= 4)
            {
                BgKnife.Load(@"C:\c#\gls_img\gls1");
            }
            else if (x >= 5)
            {
                BgKnife.Load(@"C:\c#\gls_img\gls2");

            }
        }
        */

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameTimer++;
            hScrollBar1.Value++;

            if (hScrollBar1.Value >= 100)
            {
                timer1.Stop();
                GameTimer = 0;
                hScrollBar1.Value = 0;

                timer1.Start();
            }
        }



        private void btn_Stop_Click(object sender, EventArgs e)
        {
            if ((hScrollBar1.Value >= 47) & (hScrollBar1.Value <= 52))
            {
                GamePoint++;
                timer3.Start();
                lb_Score.Text = GamePoint.ToString() + "/5";
            }
            else
            {
                GamePoint = 0;
                lb_Score.Text = GamePoint.ToString() + "/5";
            }

            //GlassImg(GamePoint);
            if (GamePoint <= 2)
            {
                BgKnife.Load(image_path+"\\gls0_new.png");
            }
            else if (GamePoint <= 4)
            {
                BgKnife.Load(@image_path + "\\gls1.png");
            }
            else if (GamePoint >= 5)
            {
                BgKnife.Load(@image_path + "\\gls2.png");

                lb_GameClear.Text = "주방용칼 을 획득하였다.\n더이상 냉장고에 볼 일은 없는것 같다.";




                object tmp = sender;
                // inven.New_Item(btn_knife.Image, e);
                PictureBox pb = new PictureBox();
                pb.Image = btn_knife.Image;
                pb.Name = "btn_knife";

                inven.New_Item(pb, e);


                LivingRoom.KnifeItem = 1;


            }



        }

        private void pb_game2_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3Num++;

            if (timer3Num == 1)
            {
                pb_Game1.BackColor = Color.Yellow;
                pb_Game2.BackColor = Color.Yellow;
                pb_Game3.BackColor = Color.Yellow;
                pb_Game4.BackColor = Color.Yellow;

            }
            if (timer3Num == 8)
            {
                pb_Game1.BackColor = Color.Lime;
                pb_Game2.BackColor = Color.Lime;
                pb_Game3.BackColor = Color.Lime;
                pb_Game4.BackColor = Color.Lime;

            }
            if (timer3Num >= 20)
            {
                timer3Num = 0;
                timer3.Stop();
            }


        }

        private void miniGame_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
