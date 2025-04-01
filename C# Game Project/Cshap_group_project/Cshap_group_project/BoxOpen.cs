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
    public partial class BoxOpen : Form
    {
        inventory inven = new inventory();
        public int BoxOpenNum = 0;
        public BoxOpen(inventory inven)
        {
            InitializeComponent();
            this.inven = inven;
        }
        /*
        private void box_hint2_Click(object sender, EventArgs e)
        {
            lb_BxOp.Text = "[지하실 열쇠] 를 획득하였다.";
            LivingRoom.Key_UnderGround = 1;
            timer_BxOp.Start();
        }
        */

        private void timer_BxOp_Tick(object sender, EventArgs e)
        {
            BoxOpenNum++;


            if (BoxOpenNum > 300)
            {
                lb_BxOp.Text = "";
                timer_BxOp.Stop();

                BoxOpenNum = 0;
            }
        }

        private void box_hint1_MouseHover(object sender, EventArgs e)
        {
            lb_hint1.Text = "2 = 6\n3 = 12\n4 = 20\n5 = 30\n6 = 42\n9 = ??\n\n무슨 의미인지 모르겠지만 기억 해둬야 할것같다.\n박스를 다시 열면 또 볼 수 있다.";
        }

        private void box_hint1_MouseLeave(object sender, EventArgs e)
        {
            lb_hint1.Text = "";
        }
        /*
        private void btn_Key_Click(object sender, EventArgs e)
        {
            lb_BxOp.Text = "[지하실 열쇠] 를 획득하였다.";
            LivingRoom.Key_UnderGround = 1;
            timer_BxOp.Start();

            object tmp = sender;
            PictureBox pb = new PictureBox();
            pb.Image = btn_Key.Image;
            pb.Name = btn_Key.Name;

            inven.New_Item(pb, e);






        }
        */
        private void box_hint1_Click(object sender, EventArgs e)
        {

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            lb_hint1.Text = "2 = 6\n3 = 12\n4 = 20\n5 = 30\n6 = 42\n9 = ?0\n\n무슨 의미인지 모르겠지만 기억 해둬야 할것같다.\n박스를 다시 열면 또 볼 수 있다.";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            lb_hint1.Text = "";
        }

        private void btn_Key_Click_1(object sender, EventArgs e)
        {
            lb_BxOp.Text = "[지하실 열쇠] 를 획득하였다.";
            LivingRoom.Key_UnderGround = 1;
            timer_BxOp.Start();

            object tmp = sender;
            PictureBox pb = new PictureBox();
            pb.Image = btn_Key.Image;
            pb.Name = "지하실키";

            inven.New_Item(pb, e);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
